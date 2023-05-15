using Gamanet.C4.SDK.Framework4.Communication;
using System;

namespace Gamanet.C4.Driver.SimpleDriver.Packets
{
    internal class SimpleDevicePacketParser : IPacketParser
    {
        private const byte START_BYTE = 0x9f;

        public bool TryParse(byte[] bytes, out IInputPacket packet, out int eaten)
        {
            packet = null;
            eaten = 0;

            // check minimum length
            if (bytes.Length < 4)
            {
                // incmplete data
                return false;
            }

            var startIndex = Array.IndexOf(bytes, START_BYTE);
            var packetCode = bytes[startIndex + 1];
            var dataLenght = bytes[startIndex + 2];

            var lastByteIndex = startIndex + 3 + dataLenght;
            if (bytes.Length < lastByteIndex)
            {
                // incmplete data
                return false;
            }

            var dataPayload = new byte[dataLenght];
            Buffer.BlockCopy(bytes, startIndex + 3, dataPayload, 0, dataLenght);

            var computedCrc = ComputeCrc(ref bytes, startIndex + 1, lastByteIndex);
            var packetCrc = bytes[lastByteIndex];

            if (computedCrc != packetCrc)
            {
                // CRC does not match
                return false;
            }

            // create packets
            packet = PacketFactory.GetPacket(packetCode, dataPayload);

            eaten = lastByteIndex;
            return true;
        }

        private static byte ComputeCrc(ref byte[] r, int startIndex, int endIndex)
        {
            byte crc = 0;
            for (int i = startIndex; i < r.Length && i < endIndex; i++)
            {
                crc ^= r[i];
            }

            return crc;
        }
    }
}