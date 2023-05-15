using Gamanet.C4.SDK.Framework4.Communication;

namespace Gamanet.C4.Driver.SimpleDriver.Packets.Input
{
    internal abstract class InputPacketBase : IInputPacket
    {
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
