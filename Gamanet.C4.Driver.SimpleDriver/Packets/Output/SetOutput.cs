namespace Gamanet.C4.Driver.SimpleDriver.Packets.Output
{
    internal class SetOutput : OutputPacketBase
    {
        private const byte PACKET_ID = 0x03;

        private readonly byte _outputAddress;
        private readonly bool _on;

        public SetOutput(byte outputAddress, bool on)
            : base(PACKET_ID)
        {
            _outputAddress = outputAddress;
            _on = on;
        }

        protected override byte[] GetDataPayload()
        {
            return new byte[] { _outputAddress, _on ? (byte)1 : (byte)0 };
        }
    }
}