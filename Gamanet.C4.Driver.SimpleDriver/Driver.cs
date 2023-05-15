using Gamanet.C4.Driver.SimpleDriver.Devices;
using Gamanet.C4.Driver.SimpleDriver.Packets;
using Gamanet.C4.SDK.Enums.Devices;
using Gamanet.C4.SDK.Framework4.Communication;
using System;
using System.Linq;

namespace Gamanet.C4.Driver.SimpleDriver
{
    // todo - move to device, and generate partial method
    public interface IHandleConnectionChanges
    {
        void InitializeCommunication();
        
        void OnReconnect();
    }
    
    public partial class Driver
    {
        private IPacketProcessor _packetProcessor;

        public BusController BusController { get; private set; }

        partial void OnStart()
        {
            DriverContext.TraceLog.Trace("OnStart()");

            BusController = (BusController)DriverContext.DeviceTree.Root.Device;

            var link = new TcpClientLink();
            link.Init(DriverContext, BusController.Id, new SimpleDevicePacketParser());

            _packetProcessor = new PacketProcessor();
            _packetProcessor.StatusChanged += OnPacketProcessorStatusChanged;

            DriverContext.SetService<IPacketProcessor>(_packetProcessor);

            _packetProcessor.Init(
                DriverContext,
                link,
                BusController.Id,
                OnUnhandledPacket,
                DriverContext.CancellationToken);

            _packetProcessor.Start();
        }

        // use only one enum on status change
        // use 2 enums: real status of link and how I got it (first connect, reconnect)
        private void OnPacketProcessorStatusChanged(object sender, CommunicationStatusChangedArgs e)
        {
            DriverContext.TraceLog.Trace($"OnPacketProcessorStatusChanged: '{e}'");

            if (e.Origin == StatusChangeOrigin.LinkConnected)
            {
                foreach (var device in DriverContext.DeviceTree.GetAll().Select(d => d.Device).OfType<IHandleConnectionChanges>())
                    device.InitializeCommunication();
            }
            else if (e.Origin == StatusChangeOrigin.ProcessorConnected)
            {
                // initial connection was successful
                DriverContext.DeviceLog.DriverConnectedToDevice(BusController);
                DriverContext.StatusSender.Send(BusController.Id, DeviceStatusCategory.Idle);
                DriverContext.StatusSender.Send(BusController.CentralUnit.Id, DeviceStatusCategory.Idle);
            }
            else if (e.Origin == StatusChangeOrigin.Reconnect)
            {
                foreach (var device in DriverContext.DeviceTree.GetAll().Select(d => d.Device).OfType<IHandleConnectionChanges>())
                    device.OnReconnect();
            }
        }

        private void OnUnhandledPacket(IInputPacket inputPacket)
        {
            DriverContext.TraceLog.Trace($"OnUnhandledPacket(inputPacket='{inputPacket}')");
        }
    }
}