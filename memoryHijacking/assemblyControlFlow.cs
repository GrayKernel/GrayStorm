using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrayStorm
{
    public class assemblyControlFlow
    {
        #region 1337 code
        /// <summary>
        ///At the time of a call the dword register is called as such
        ///0xFF call dword [00189AC4h] which is 6 bytes of 0xFF,0x15,0xC4,0x9A,0x18,0x0
        ///I can then select the immediate value and use that as a selector to find the index into memory to set up a new relative call.
        ///Once the index in memory is located, I can use manipulation of the long type to calculate a new offset.
        ///I then place that offset into the location of the 0xFF by replacing the sequence with a "call immediate/0xE8" instruction. 
        /// </summary>
        public static void replaceDwordCall(IntPtr methodPointer)
        {
            string intPtrString;
            Int32 replaceAddress = 0;
            IntPtr methodAssembly;
            int containedIndex = -1;
            byte[] replacementIndex = null;
            int indexReplace;
            int count = 0;
            long dstAddress;
            long srcAddress;
            long newCallPtr;

            if (domainTraverser.currentMethod == null || methodPointer == IntPtr.Zero)
                return;

            containedIndex = methodHelpers.containedInList(domainTraverser.currentMethod);
            if (containedIndex == -1)
            {
                grayStorm._memoryHijacker.dumpAsm_BT_Click(null, null);
                containedIndex = methodHelpers.containedInList(domainTraverser.currentMethod);
            }
            methodAssembly = methodHelpers.StorageInformationArrayList[containedIndex].methodIntPtr;

            intPtrString = grayStorm._memoryHijacker.editor_RTB.SelectedText;
            grayStorm._memoryHijacker.editor_RTB.SelectionColor = System.Drawing.Color.White;
            grayStorm._memoryHijacker.editor_RTB.SelectionBackColor = System.Drawing.Color.Blue;
            intPtrString = intPtrString.Replace("\n", string.Empty);
            intPtrString = intPtrString.Replace("0x", string.Empty);
            intPtrString = intPtrString.Replace("h", string.Empty);
            replaceAddress = Convert.ToInt32(intPtrString, 16);

            if (grayStorm._memoryHijacker.disassemble_CB.Checked)
            {
                replacementIndex = BitConverter.GetBytes(replaceAddress);
            }
            else
            {
                replacementIndex = BitConverter.GetBytes(replaceAddress);
                Array.Reverse(replacementIndex);
            }

            Array.Resize(ref replacementIndex, 6);

            //call dword [0x########] conversion to little endian to make room for 0xff and 0x15
            for (count = 3; count >= 0; count--)
            {
                replacementIndex[count + 2] = replacementIndex[count];
            }
            replacementIndex[0] = 0xff;
            replacementIndex[1] = 0x15;

            indexReplace = PatternAt(methodHelpers.StorageInformationArrayList[containedIndex].oldMethod, replacementIndex);

            if (indexReplace < 0)
            {
                System.Windows.Forms.MessageBox.Show("Could not find the replacement index");
                return;
            }

            dstAddress = (long)((int)methodPointer.ToInt32());//new address to call
            srcAddress = (long)methodAssembly + indexReplace + 5; //memory location of caller + position of 0xFF + size of call sequence
            newCallPtr = dstAddress - srcAddress;

            //Call immediate and NOP to overwrite 6 bytes. 
            replacementIndex[0] = 0xe8;
            replacementIndex[1] = (byte)(newCallPtr);
            replacementIndex[2] = (byte)(newCallPtr >> 8);
            replacementIndex[3] = (byte)(newCallPtr >> 16);
            replacementIndex[4] = (byte)(newCallPtr >> 24);
            replacementIndex[5] = 0x90;

            //Write the new custom C# IntPtr over the existing index of the call. 
            for (count = 0; count <= 5; count++)
            {
                System.Runtime.InteropServices.Marshal.WriteByte(new IntPtr(methodAssembly.ToInt64() + indexReplace + count), replacementIndex[count]);
            }
        }

        /// <summary>
        /// Replace a 0xE8 call 
        /// dstAddress - methodFunPtr + callOffset + byteOffset = new destination address
        /// </summary>
        /// <param name="methodPointer"></param>
        public static void replaceE8Call(IntPtr methodPointer)
        {
            string intPtrString;
            Int32 replaceAddress = 0;
            IntPtr methodAssembly;
            int containedIndex = -1;
            byte[] replacementIndex = null;
            int indexReplace;
            int count = 0;
            long dstAddress;
            long srcAddress;
            long newCallPtr;

            if (domainTraverser.currentMethod == null || methodPointer == IntPtr.Zero)
                return;

            containedIndex = methodHelpers.containedInList(domainTraverser.currentMethod);
            if (containedIndex == -1)
            {
                grayStorm._memoryHijacker.dumpAsm_BT_Click(null, null);
                containedIndex = methodHelpers.containedInList(domainTraverser.currentMethod);
            }
            methodAssembly = methodHelpers.StorageInformationArrayList[containedIndex].methodIntPtr;

            intPtrString = grayStorm._memoryHijacker.editor_RTB.SelectedText;
            grayStorm._memoryHijacker.editor_RTB.SelectionColor = System.Drawing.Color.White;
            grayStorm._memoryHijacker.editor_RTB.SelectionBackColor = System.Drawing.Color.Blue;
            intPtrString = intPtrString.Replace("\n", string.Empty);
            intPtrString = intPtrString.Replace("0x", string.Empty);
            intPtrString = intPtrString.Replace("h", string.Empty);
            replaceAddress = Convert.ToInt32(intPtrString, 16);

            //call immediate conversion to little endian to make room
            if (grayStorm._memoryHijacker.disassemble_CB.Checked)
            {
                System.Windows.Forms.MessageBox.Show("Not yet supported, perform action in hex dump");
                return;
                //Need to get the real address that would be in the disassembly. :(
                //How? TODO
                // newCallPtr = (long)replaceAddress + (long)methodAssembly + 5 + 0; //restore the assembly dump by taking dst + methodAddr + 5 + offset?????? 
                // replaceAddress = Convert.ToInt32(newCallPtr);
                //  replacementIndex = BitConverter.GetBytes(replaceAddress);
            }
            else
            {
                replacementIndex = BitConverter.GetBytes(replaceAddress);
                Array.Reverse(replacementIndex);
            }

            indexReplace = PatternAt(methodHelpers.StorageInformationArrayList[containedIndex].oldMethod, replacementIndex);
            indexReplace -= 1; //because not matching on the 0xE8B
            if (indexReplace < 0)
            {
                System.Windows.Forms.MessageBox.Show("Could not find the replacement index");
                return;
            }

            dstAddress = (long)((int)methodPointer.ToInt32());//new address to call
            srcAddress = (long)methodAssembly + indexReplace + 5; //memory location of caller + position of 0xFF + size of call sequence
            newCallPtr = dstAddress - srcAddress;

            Array.Resize(ref replacementIndex, 5);
            //Call immediate and NOP to overwrite 5 bytes. 
            replacementIndex[0] = 0xe8;
            replacementIndex[1] = (byte)(newCallPtr);
            replacementIndex[2] = (byte)(newCallPtr >> 8);
            replacementIndex[3] = (byte)(newCallPtr >> 16);
            replacementIndex[4] = (byte)(newCallPtr >> 24);

            //Write the new custom C# IntPtr over the existing index of the call. 
            for (count = 0; count <= 4; count++)
            {
                System.Runtime.InteropServices.Marshal.WriteByte(new IntPtr(methodAssembly.ToInt64() + indexReplace + count), replacementIndex[count]);
            }
        }

        public static int PatternAt(byte[] source, byte[] pattern)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (source.Skip(i).Take(pattern.Length).SequenceEqual(pattern))
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion 1337 code
    }
}
