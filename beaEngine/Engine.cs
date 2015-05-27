using System.Runtime.InteropServices;
using System;

namespace GrayStorm.beaEngine
{
    public class BeaEngine
    {
        #region P/Invoke
        [DllImport("BeaEngine.dll")]
        public static extern int Disasm([In, Out, MarshalAs(UnmanagedType.LPStruct)] Disasm disasm);

        [DllImport("BeaEngine64.dll", EntryPoint = "Disasm")]
        public static extern int Disasm64([In, Out] IntPtr diasm);
        #endregion P/Invoke
    }
}