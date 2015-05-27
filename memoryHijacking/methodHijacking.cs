using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;


namespace GrayStorm
{
    class methodHijacking
    {
        public static void writeAMethod(IntPtr methodIntPtr)
        {
            assemblyHelpers.writeDynamicShellcode(methodIntPtr);
        }
    }
}
