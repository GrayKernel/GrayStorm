using System;
using System.Reflection;
using System.Reflection.Emit;

namespace GrayStorm
{
    public sealed class ILInstruction
    {
        public int Offset
        {
            get;
            set;
        }


        public OpCode OpCode
        {
            get;
            set;
        }


        public object Data
        {
            get;
            set;
        }

    }

}
