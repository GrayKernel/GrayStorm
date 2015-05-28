using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GrayStorm
{
    public static class ByteArrayExtensions
    {
        public static int GetInt32(this byte[] bytes, int index)
        {
            return
                bytes[index + 0] |
                bytes[index + 1] << 8 |
                bytes[index + 2] << 16 |
                bytes[index + 3] << 24;
        }
    }
}
