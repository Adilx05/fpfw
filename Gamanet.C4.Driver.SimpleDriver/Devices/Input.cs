using Gamanet.C4.Driver.SimpleDriver.Packets.Input;
using Gamanet.C4.Driver.SimpleDriver.Packets.Output;
using Gamanet.C4.SDK.Framework4.Communication;
using Gamanet.C4.SDK.Framework4.Device.Builder;
using Gamanet.C4.SimpleInterfaces;

namespace Gamanet.C4.Driver.SimpleDriver.Devices
{
    public partial class Input : IHandleConnectionChanges
    {
        /// <summary>
        /// Holds actual status. Used to prevent reporting same status over and over
        /// </summary>
        private InputStatus? _actualStatus;

        public CentralUnit CentralUnit { get; private set; }

        partial void OnInitialized(SimpleDeviceV1 simpleDevice, IDriverContext driverContext)
        {
            CentralUnit = (CentralUnit)DriverContext.DeviceTree.GetNode(Id).Parent.Device;
        }

        public void InitializeCommunication()
        {
            _actualStatus = null;

            var packetProcessor = DriverContext.GetService<IPacketProcessor>();
            var periodicalPacket = new GetInputStatus(this.HardwareAddress);

            packetProcessor.SendPeriodicalPacket(periodicalPacket, CentralUnit.PollRate, OnInputStatusResponse, null);
        }

        public void ConnectionLost()
        {
            // nothing now
        }

        private ConfirmationResult OnInputStatusResponse(IInputPacket inputPacket, IResponseContext responseContext)
        {
            if (inputPacket is InputStatusResponse response)    // check type of response
            {
                if (response.Address == HardwareAddress)        // is it for me?
                {
                    HandleStatus(response.InputStatus);
                    return ConfirmationResult.Handled;
                }
            }
            else if (inputPacket is Nack)
            {
                var op = (GetInputStatus)responseContext.OutputPacket;
                if (op.HardwareAddress == HardwareAddress)
                {
                    HandleStatus(InputStatus.Unknown);
                    return ConfirmationResult.Handled;
                }
            }

            return ConfirmationResult.Unhandled;
        }

        private void HandleStatus(InputStatus value)
        {
            if (value == InputStatus.Active)
            {
                if (_actualStatus != InputStatus.Active)
                {
                    // first time is not logged
                    if (_actualStatus != null)
                    {
                        DriverContext.DeviceLog.Closed(this);
                    }

                    DriverContext.StatusSender.Activated(this);
                }
            }
            else if (value == InputStatus.Inactive)
            {
                if (_actualStatus != InputStatus.Inactive)
                {
                    // first time is not logged
                    if (_actualStatus != null)
                    {
                        DriverContext.DeviceLog.Opened(this);
                    }

                    DriverContext.StatusSender.Idle(this);
                }
            }
            else if (value == InputStatus.Unknown)
            {
                if (_actualStatus != InputStatus.Unknown)
                {
                    DriverContext.StatusSender.Unknown(this);
                }
            }

            _actualStatus = value;
        }

        public void OnReconnect()
        {
            _actualStatus = null;
        }
    }
}
