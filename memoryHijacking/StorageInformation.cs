using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace GrayStorm
{
    public class StorageInformation
    {
        public MethodInfo methodSignature { get; set; }
        public bool dumped { get; set; }
        public byte[] memory { get; set; }
        public byte[] oldMethod { get; set; }
        public IntPtr methodIntPtr { get; set; }
        public IntPtr originalIntPtr { get; set; }
        public Delegate methodDelegate { get; set; }
    }
}
