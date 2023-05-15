using Gamanet.C4.SDK.Framework4.Communication;
using System;

namespace Gamanet.C4.Driver.SimpleDriver.Packets.Output
{
    internal abstract class OutputPacketBase : IOutputBinaryPacket, IWaitablePacket
    {
        private const byte START_BYTE = 0x9f;
        private readonly byte _packetId;

        protected OutputPacketBase(byte packetId)
        {
            _packetId = packetId;
        }

        public byte[] GetRawBytes()
        {
            var dataPayload = GetDataPayload();
            int payloadLenght = dataPayload.Length;
            int ptr = 0;

            var r = new byte[payloadLenght + 4];
            r[ptr++] = START_BYTE;
            r[ptr++] = _packetId;
            r[ptr++] = (byte)dataPayload.Length;

            // copy data payload
            Buffer.BlockCopy(dataPayload, 0, r, ptr, dataPayload.Length);
            ptr += dataPayload.Length;

            // compute checksum
            var crc = ComputeCrc(ref r, 1);
            r[ptr++] = crc;

            return r;
        }

        public override string ToString()
        {
            return GetType().Name;
        }

        protected abstract byte[] GetDataPayload();

        private static byte ComputeCrc(ref byte[] r, int startIndex)
        {
            byte crc = 0;
            for (int i = startIndex; i < r.Length; i++)
            {
                crc ^= r[i];
            }

            return crc;
        }
    }
}
