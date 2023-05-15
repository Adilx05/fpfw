namespace Gamanet.C4.Driver.SimpleDriver.Packets.Output
{
    internal class GetTimeRequest : OutputPacketBase
    {
        private const byte PACKET_ID = 0x01;

        public GetTimeRequest()
            : base(PACKET_ID)
        { }

        protected override byte[] GetDataPayload()
        {
            return new byte[0];
        }
    }
}