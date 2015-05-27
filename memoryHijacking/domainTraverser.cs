using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrayStorm
{
    public static class domainTraverser
    {
        public static System.Reflection.MethodInfo currentMethod
        {
            get;
            set;
        }

        public static System.Reflection.ConstructorInfo currentConstructor
        {
            get;
            set;
        }
    }
}
