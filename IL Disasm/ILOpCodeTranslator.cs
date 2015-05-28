using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace GrayStorm
{
    internal static class ILOpCodeTranslator
    {
        private static Dictionary<short, OpCode> _opCodes = new Dictionary<short, OpCode>();

        static ILOpCodeTranslator()
        {
            Initialize();
        }


        public static OpCode GetOpCode(short value)
        {
            return _opCodes[value];
        }


        private static void Initialize()
        {
            foreach (FieldInfo fieldInfo in typeof(OpCodes).GetFields())
            {
                OpCode opCode = (OpCode)fieldInfo.GetValue(null);

                _opCodes.Add(opCode.Value, opCode);
            }
        }
    }
}
