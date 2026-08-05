public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte prefix;
        byte[] payload;

        if (reading >= 0 && reading <= 65_535)
        {
            prefix = 2;
            payload = BitConverter.GetBytes((ushort)reading);
        }

        else if (reading >= -32_768 && reading <= -1)
        {
            prefix = 254;
            payload = BitConverter.GetBytes((short)reading);
        }

        else if (reading >= 65_536 && reading <= 2_147_483_647)
        {
            prefix = 252;
            payload = BitConverter.GetBytes((int)reading);
        }

        else if (reading >= 2_147_483_648 && reading <= 4_294_967_295)
        {
            prefix = 4;
            payload = BitConverter.GetBytes((uint)reading);
        }

        else if (reading >= -2_147_483_648 && reading <= -32_769)
        {
            prefix = 252;
            payload = BitConverter.GetBytes((int)reading);
        }

        else
        {
            prefix = 248;
            payload = BitConverter.GetBytes(reading);
        }

        byte[] buffer = new byte[9];
        buffer[0] = prefix;

        for (int i = 0; i < payload.Length; i++)
        {
            buffer[i + 1] = payload[i];
        }

        return buffer;
    }

    public static long FromBuffer(byte[] buffer)
    {
        byte prefix = buffer[0];

        switch (prefix)
        {
            case 2:
                return BitConverter.ToUInt16(buffer, 1);

            case 254: 
                return BitConverter.ToInt16(buffer, 1);

            case 4:
                return BitConverter.ToUInt32(buffer, 1);

            case 252: 
                return BitConverter.ToInt32(buffer, 1);

            case 248: 
                return BitConverter.ToInt64(buffer, 1);

            default:
                return 0;
        }
    }
}
