namespace Gamanet.C4.Driver.SimpleDriver.Packets.Input
{
    [PacketType(0xE1)]
    internal class Ack : InputPacketBase
    {
        public Ack(byte[] dataPayload) { }
    }
}
