namespace Gamanet.C4.Driver.SimpleDriver.Packets.Input
{
    [PacketType(0xA2)]
    internal class InputStatusResponse : InputPacketBase
    {
        public InputStatusResponse(byte[] dataPayload)
        {
            Address = dataPayload[0];
            InputStatus = (InputStatus)dataPayload[1];
        }

        public byte Address { get; }

        public InputStatus InputStatus { get; }
    }
}
