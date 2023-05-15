namespace Gamanet.C4.Driver.SimpleDriver.Packets.Output
{
    internal class GetOutputStatus : OutputPacketBase
    {
        private const byte PACKET_ID = 0x04;

        private readonly byte _hardwareAddress;

        public GetOutputStatus(byte hardwareAddress) 
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