using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrayStorm
{
    public class foundObject
    {
        public object targetObject;
        public string name;
        public IntPtr addrOfObj;

        public override string ToString()
        {
            return name;
        }
    }
}
