using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrayStorm
{
    class methodDumping
    {
        public byte[] dumpAMethod(IntPtr methodIntPtrIn)
        {
            //now read functions memory
            byte[] memory = assemblyHelpers.DumpAFunction(methodIntPtrIn);
            if (memory.Length == 0)
                return null;
            return memory;
        }
    }
}
