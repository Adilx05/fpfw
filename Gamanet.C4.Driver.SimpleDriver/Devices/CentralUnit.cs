using Gamanet.C4.Driver.SimpleDriver.Packets.Input;
using Gamanet.C4.Driver.SimpleDriver.Packets.Output;
using Gamanet.C4.SDK.Framework4.Common.Extension;
using Gamanet.C4.SDK.Framework4.Communication;
using Gamanet.C4.SDK.Framework4.Device.Builder;
using Gamanet.C4.SimpleInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gamanet.C4.Driver.SimpleDriver.Devices
{
    public partial class CentralUnit : IHandleConnectionChanges
    {
        private static TimeSpan _deviceTimeDiffTreshold = TimeSpan.FromMinutes(5);

        public Dictionary<byte, Input> Inputs { get; private set; }
        public Dictionary<byte, Output> Outputs { get; private set; }

        private IDriverTracer _log;

        public void InitializeCommunication()
        {
            var packetProcessor = DriverContext.GetService<IPacketProcessor>();
            var periodicalPacket = new GetTimeRequest();

            packetProcessor.SendPeriodicalPacket(periodicalPacket, 1.min(), OnGetTimeResponse, new GetTimeResponseConext(packetProcessor));
        }

        public void OnReconnect()
        {
            DriverContext.StatusSender.Idle(this);
        }

        partial void OnInitialized(SimpleDeviceV1 simpleDevice, IDriverContext driverContext)
        {
            var mySubtree = driverContext.DeviceTree.GetSubtree(Id).Select(d => d.Device).ToArray();

            Inputs = mySubtree.OfType<Input>().ToDictionary(d => d.HardwareAddress);
            Outputs = mySubtree.OfType<Output>().ToDictionary(d => d.HardwareAddress);

            _log = driverContext.TraceLog;
        }

        private ConfirmationResult OnGetTimeResponse(IInputPacket inputPacket, IResponseContext responseContext)
        {
            if (inputPacket is GetTimeResponse response)
            {
                var context = (GetTimeResponseConext)responseContext.State;
                var deviceTime = response.DeviceTime;

                var now = DateTime.Now;
                var deviceTimeDiff = now - deviceTime;

                _log.Trace($"Diff between device and driver is {deviceTimeDiff}");

                if (deviceTimeDiff > _deviceTimeDiffTreshold)
                {
                    _log.Trace($"Difference between device time and driver is more then {_deviceTimeDiffTreshold}. Synronizing device time");

                    // set time
                    SendSetTimePacket(context.PacketProcessor, deviceTimeDiff);
                }

                return ConfirmationResult.Handled;
            }

            return ConfirmationResult.Unhandled;
        }

        private void SendSetTimePacket(IPacketProcessor packetProcessor, TimeSpan deviceTimeDiff)
        {
            packetProcessor.SendPriorPacket(new SetTimeRequest(), OnSetTimeReponse, new SetTimeResponseConext(deviceTimeDiff));
        }

        private ConfirmationResult OnSetTimeReponse(IInputPacket inputPacket, IResponseContext responseContext)
        {
            if (inputPacket is Ack || inputPacket is Nack)
            {
                var context = (SetTimeResponseConext)responseContext.State;
                DriverContext.DeviceLog.TimeDifferenceWarningTooBig(this, context.DeviceTimeDiff);
                return ConfirmationResult.Handled;
            }

            return ConfirmationResult.Unhandled;
        }

        private class SetTimeResponseConext
        {
            public SetTimeResponseConext(TimeSpan deviceTimeDiff)
            {
                DeviceTimeDiff = deviceTimeDiff;
            }

            public TimeSpan DeviceTimeDiff { get; }
        }

        private class GetTimeResponseConext
        {
            public GetTimeResponseConext(IPacketProcessor packetProcessor)
            {
                PacketProcessor = packetProcessor;
            }

            public IPacketProcessor PacketProcessor { get; }
        }
    }
}
