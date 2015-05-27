using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace GrayStorm.beaEngine
{
    class disassemble
    {
        #region disassemble
        /// <param name="rip">The instruction pointer to start disassembly on</param>
        /// <param name="pid">The PID to the process to get memory from</param>
        /// <param name="disasmBox">The listbox to dump disasm to</param>
        /// <param name="methodIntPtr">The trueIntPtr of the Method that we want to attack so that our jmp,call,etc are at the correct offsets.</param>
        public void disassembler(byte[] bytesToDisassam, System.Windows.Forms.RichTextBox disasmBox, IntPtr methodIntPtr)
        {
            try
            {
                var disasm = new Disasm();
                IntPtr disasmPtr = Marshal.AllocHGlobal(Marshal.SizeOf(disasm));

                int result = 0;

                if (IntPtr.Size == 8)
                {
                    disasm.Archi = 64;
                }
                else
                    disasm.Archi = 32;

                disasm.Options = 0x200; //display in NASM syntax

                int size = bytesToDisassam.Length;
                //IntPtr executionPointer = System.Runtime.InteropServices.Marshal.AllocHGlobal(size);
                //   System.Runtime.InteropServices.Marshal.Copy(bytesToDisassam, 0, executionPointer, size);
                disasm.EIP = methodIntPtr;

                var EIPrange = (methodIntPtr.ToInt64() + size / 2);

                while (true)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(disasm, disasmPtr, false);
                    if (IntPtr.Size == 8)
                    {

                        result = BeaEngine.Disasm64(disasmPtr);
                        Marshal.PtrToStructure(disasmPtr, disasm);
                    }
                    else
                        result = BeaEngine.Disasm(disasm);


                    //Marshal.PtrToStructure(disasmPtr, disasm);
                    if (result == (int)BeaConstants.SpecialInfo.UNKNOWN_OPCODE)
                    {
                        disasmBox.AppendText("Beaengine error: unknown opcode \n");
                        break;
                    }

                    disasmBox.AppendText("0x" + disasm.Instruction.Opcode.ToString("X") + " " + disasm.CompleteInstr.ToString() + "\n");

                    if (disasm.Instruction.Opcode.ToString("X") == "C3")
                        break;

                    disasm.EIP = new IntPtr(disasm.EIP.ToInt64() + result);

                }
            }
            catch (Exception ex)
            {
                disasmBox.AppendText("Beaengine error: " + ex.Message.ToString() + "\n");
            }
        }
        #endregion disassemble
    }
}
