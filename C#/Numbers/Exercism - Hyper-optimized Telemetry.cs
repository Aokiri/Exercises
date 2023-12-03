// Link to this exercise: https://exercism.org/tracks/csharp/exercises/hyper-optimized-telemetry

using System;
using System.Linq;
using System.Collections.Generic;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        int primaryBytes = 256;
        int byteArrayLenght = 9;
        IEnumerable<byte> bytes = reading switch
        {
            < Int32.MinValue => BitConverter.GetBytes((long)reading).Prepend((byte)(primaryBytes - 8)),
            < Int16.MinValue => BitConverter.GetBytes((int)reading).Prepend((byte)(primaryBytes - 4)),
            < UInt16.MinValue => BitConverter.GetBytes((short)reading).Prepend((byte)(primaryBytes - 2)),
            <= UInt16.MaxValue => BitConverter.GetBytes((ushort)reading).Prepend((byte)2),
            <= Int32.MaxValue => BitConverter.GetBytes((int)reading).Prepend((byte)(primaryBytes - 4)),
            <= UInt32.MaxValue => BitConverter.GetBytes((uint)reading).Prepend((byte)4),
            _ => BitConverter.GetBytes(reading).Prepend((byte)(primaryBytes - 8))
        };

        return bytes.Concat(new byte[byteArrayLenght - bytes.Count()]).ToArray();
    }

    public static long FromBuffer(byte[] buffer) =>
        buffer[0] switch
        {
            256 - 8 or 4 or 2 => BitConverter.ToInt64(buffer, 1),
            256 - 4 => BitConverter.ToInt32(buffer, 1),
            256 - 2 => BitConverter.ToInt16(buffer, 1),
            _ => 0
        };
}