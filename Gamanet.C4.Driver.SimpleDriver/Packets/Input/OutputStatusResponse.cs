namespace Gamanet.C4.Driver.SimpleDriver.Packets.Input
{
    [PacketType(0xA4)]
    internal class OutputStatusResponse : InputPacketBase
    {
        public OutputStatusResponse(byte[] dataPayload)
        {
            Address = dataPayload[0];
            OutputStatus = (OutputStatus)dataPayload[1];
        }

        public byte Address { get; }

        public OutputStatus OutputStatus { get; }
    }
}
