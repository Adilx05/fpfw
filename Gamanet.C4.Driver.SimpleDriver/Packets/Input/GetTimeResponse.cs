using System;

namespace Gamanet.C4.Driver.SimpleDriver.Packets.Input
{
    [PacketType(0xA1)]
    internal class GetTimeResponse : InputPacketBase
    {
        public GetTimeResponse(byte[] dataPayload)
        {
            var year = dataPayload[0];
            var month = dataPayload[1];
            var day = dataPayload[2];
            var hour = dataPayload[3];
            var minute = dataPayload[4];
            var second = dataPayload[5];
            DeviceTime = new DateTime(year + 2000, month, day, hour, minute, second);
        }

        public DateTime DeviceTime { get; private set; }
    }
}
