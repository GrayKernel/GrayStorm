using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;


namespace GrayStorm
{
    public static class ILInstructionLoader
    {
        public static IEnumerable<ILInstruction> GetInstructions(MethodBase methodBase)
        {
            MethodBody methodBody = methodBase.GetMethodBody();

            byte[] bytes;
            if (methodBody != null)
            {
                bytes = methodBody.GetILAsByteArray();
            }
            else
            {
                bytes = new byte[] { };
            }


            int offset = 0;

            while (offset < bytes.Length)
            {
                ILInstruction instruction = new ILInstruction();
                instruction.Offset = offset;

                short code = (short)bytes[offset++];
                if (code == 0xfe)
                {
                    code = (short)(bytes[offset++] | 0xfe00);
                }

                instruction.OpCode = ILOpCodeTranslator.GetOpCode(code);

                switch (instruction.OpCode.OperandType)
                {
                    case OperandType.InlineBrTarget:
                        offset += 4;
                        break;

                    case OperandType.InlineField:
                        offset += 4;
                        break;

                    case OperandType.InlineI:
                        offset += 4;
                        break;

                    case OperandType.InlineI8:
                        offset += 8;
                        break;

                    case OperandType.InlineMethod:
                        int metaDataToken = bytes.GetInt32(offset);

                        Type[] genericMethodArguments = null;
                        if (methodBase.IsGenericMethod == true)
                        {
                            genericMethodArguments = methodBase.GetGenericArguments();
                        }

                        instruction.Data = methodBase.Module.ResolveMethod(metaDataToken, methodBase.DeclaringType.GetGenericArguments(), genericMethodArguments);
                        offset += 4;
                        break;

                    case OperandType.InlineNone:
                        break;

                    case OperandType.InlineR:
                        offset += 8;
                        break;

                    case OperandType.InlineSig:
                        offset += 4;
                        break;

                    case OperandType.InlineString:
                        offset += 4;
                        break;

                    case OperandType.InlineSwitch:
                        int count = bytes.GetInt32(offset) + 1;
                        offset += 4 * count;
                        break;

                    case OperandType.InlineTok:
                        offset += 4;
                        break;

                    case OperandType.InlineType:
                        offset += 4;
                        break;

                    case OperandType.InlineVar:
                        offset += 2;
                        break;

                    case OperandType.ShortInlineBrTarget:
                        offset += 1;
                        break;

                    case OperandType.ShortInlineI:
                        offset += 1;
                        break;

                    case OperandType.ShortInlineR:
                        offset += 4;
                        break;

                    case OperandType.ShortInlineVar:
                        offset += 1;
                        break;

                    default:
                        throw new NotImplementedException();
                }

                yield return instruction;
            }
        }
    }
}
