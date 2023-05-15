using Gamanet.C4.Driver.SimpleDriver.Packets.Input;
using Gamanet.C4.SDK.Framework4.Communication.PacketFactories;

namespace Gamanet.C4.Driver.SimpleDriver.Packets
{
    internal static class PacketFactory
    {
        private static readonly Factory<InputPacketBase, PacketTypeAttribute, byte> _packets
           = new Factory<InputPacketBase, PacketTypeAttribute, byte>();

        public static InputPacketBase GetPacket(byte packetId, byte[] dataPayload)
        {
            return _packets.Resolve(packetId, dataPayload);
        }
    }
}
