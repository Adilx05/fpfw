using System;

namespace Gamanet.C4.Driver.SimpleDriver.Packets.Output
{
    internal class SetTimeRequest : OutputPacketBase
    {
        private const byte PACKET_ID = 0x05;

        public SetTimeRequest() : base(PACKET_ID)
        { }

        protected override byte[] GetDataPayload()
        {
            // in order to set the most precise as possible, take Now here, where actual packet is about to be sent
            var now = DateTime.Now;
            return new byte[]
            {
                (byte)(now.Year  -2000),
                (byte)now.Month,
                (byte)now.Day,
                (byte)now.Hour,
                (byte)now.Minute,
                (byte)now.Second,
            };
        }
    }
}