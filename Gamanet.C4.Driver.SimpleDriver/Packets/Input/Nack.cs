namespace Gamanet.C4.Driver.SimpleDriver.Packets.Input
{
    [PacketType(0xE2)]
    internal class Nack : InputPacketBase
    {
        public Nack(byte[] dataPayload) { }
    }
}
