using Gamanet.C4.Driver.SimpleDriver.Packets.Input;
using Gamanet.C4.Driver.SimpleDriver.Packets.Output;
using Gamanet.C4.SDK.Enums.Devices;
using Gamanet.C4.SDK.Framework4.Communication;
using Gamanet.C4.SDK.Framework4.Device.Builder;
using Gamanet.C4.SDK.Framework4.Device.Interfaces;
using Gamanet.C4.SimpleInterfaces;
using System;

namespace Gamanet.C4.Driver.SimpleDriver.Devices
{
    public partial class Output : ICommandHandler, IHandleConnectionChanges
    {
        /// <summary>
        /// Holds actual status. Used to prevent reporting same status over and over
        /// </summary>
        private OutputStatus? _actualStatus;

        public CentralUnit CentralUnit { get; private set; }

        partial void OnInitialized(SimpleDeviceV1 simpleDevice, IDriverContext driverContext)
        {
            CentralUnit = (CentralUnit)DriverContext.DeviceTree.GetNode(Id).Parent.Device;
        }

        public void HandleCommand(SimpleCommandV1 cmd, Guid userId)
        {
            if (cmd == null) return;
            var packetProcessor = DriverContext.GetService<IPacketProcessor>();

            if (cmd.CategoryId == CommandCategory.DeviceOn)
            {
                packetProcessor.SendPriorPacket(
                    new SetOutput(HardwareAddress, true),
                    OnSetOutputResponse,
                    new SetOutputResponseContext(cmd.CategoryId, userId));
            }
            else if (cmd.CategoryId == CommandCategory.DeviceOff)
            {
                packetProcessor.SendPriorPacket(
                    new SetOutput(HardwareAddress, false),
                    OnSetOutputResponse,
                    new SetOutputResponseContext(cmd.CategoryId, userId));
            }
        }

        public void OnReconnect()
        {
            _actualStatus = null;
        }

        public void InitializeCommunication()
        {
            _actualStatus = null;

            var packetProcessor = DriverContext.GetService<IPacketProcessor>();
            var periodicalPacket = new GetOutputStatus(HardwareAddress);

            packetProcessor.SendPeriodicalPacket(periodicalPacket, CentralUnit.PollRate, OnOutputStatusResponse, null);
        }

        public void ConnectionLost()
        {

        }

        private ConfirmationResult OnOutputStatusResponse(IInputPacket inputPacket, IResponseContext responseContext)
        {
            if (inputPacket is OutputStatusResponse response)    // check type of response
            {
                if (response.Address == HardwareAddress)        // is it for me?
                {
                    HandleStatus(response.OutputStatus);
                    return ConfirmationResult.Handled;
                }
            }
            else if (inputPacket is Nack)
            {
                var op = (GetOutputStatus)responseContext.OutputPacket;
                if (op.HardwareAddress == HardwareAddress)
                {
                    HandleStatus(OutputStatus.Unknown);
                    return ConfirmationResult.Handled;
                }
            }

            return ConfirmationResult.Unhandled;
        }

        private void HandleStatus(OutputStatus value)
        {
            if (value == OutputStatus.Active)
            {
                if (_actualStatus != OutputStatus.Active)
                {
                    // first time is not logged
                    if (_actualStatus != null)
                    {
                        DriverContext.DeviceLog.DeviceTurnedOn(this);
                    }

                    DriverContext.StatusSender.Activated(this);
                }
            }
            else if (value == OutputStatus.Inactive)
            {
                if (_actualStatus != OutputStatus.Inactive)
                {
                    // first time is not logged
                    if (_actualStatus != null)
                    {
                        DriverContext.DeviceLog.DeviceTurnedOff(this);
                    }

                    DriverContext.StatusSender.Idle(this);
                }
            }
            else if (value == OutputStatus.Unknown)
            {
                if (_actualStatus != OutputStatus.Unknown)
                {
                    DriverContext.StatusSender.Unknown(this);
                }
            }

            _actualStatus = value;
        }

        private ConfirmationResult OnSetOutputResponse(IInputPacket inputPacket, IResponseContext responseContext)
        {
            if (inputPacket is Ack)
            {
                return ConfirmationResult.HandledAndRemove;
            }

            if (inputPacket is Nack)
            {
                var context = (SetOutputResponseContext)responseContext.State;
                DriverContext.DeviceLog.CommandFailed(
                    this,
                    context.CommandCategoryId,
                    string.Empty,
                    context.UserId);

                return ConfirmationResult.HandledAndRemove;
            }

            return ConfirmationResult.Unhandled;
        }

        private class SetOutputResponseContext
        {
            public SetOutputResponseContext(Guid commandCategoryId, Guid userId)
            {
                CommandCategoryId = commandCategoryId;
                UserId = userId;
            }

            public Guid CommandCategoryId { get; }

            public Guid UserId { get; }
        }
    }
}