using Gamanet.C4.SDK.Framework4.Communication.PacketFactories;

namespace Gamanet.C4.Driver.SimpleDriver.Packets
{
    internal class PacketTypeAttribute : FactoryMarkerAttribute
    {
        private readonly byte _packetId;

        public PacketTypeAttribute(byte packetId)
        {
            _packetId = packetId;
        }

        protected override TIndex GetIndex<TIndex>()
        {
            return (TIndex)(object)_packetId;
        }
    }
}
