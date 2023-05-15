using Gamanet.C4.SDK.Framework4.Communication;

namespace Gamanet.C4.Driver.SimpleDriver.Packets.Output
{
    internal class GetInputStatus : OutputPacketBase
    {
        private const byte PACKET_ID = 0x02;

        private readonly byte _hardwareAddress;

        public GetInputStatus(byte hardwareAddress)
            : base(PACKET_ID)
        {
            _hardwareAddress = hardwareAddress;
        }

        public byte HardwareAddress => _hardwareAddress;

        protected override byte[] GetDataPayload()
        {
            return new byte[] { HardwareAddress };
        }
    }
}