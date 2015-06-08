using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrayStorm
{
    public class assemblyHelpers
    {
        #region WINAPI Imports
        // just magic numbers
        [Flags()]
        public enum AllocationType : uint
        {
            COMMIT = 0x1000,
            RESERVE = 0x2000,
            RESET = 0x80000,
            LARGE_PAGES = 0x20000000,
            PHYSICAL = 0x400000,
            TOP_DOWN = 0x100000,
            WRITE_WATCH = 0x200000
        }

        // just magic numbers
        [Flags()]
        public enum MemoryProtection : uint
        {
            EXECUTE = 0x10,
            EXECUTE_READ = 0x20,
            EXECUTE_READWRITE = 0x40,
            EXECUTE_WRITECOPY = 0x80,
            NOACCESS = 0x01,
            READONLY = 0x02,
            READWRITE = 0x04,
            WRITECOPY = 0x08,
            GUARD_Modifierflag = 0x100,
            NOCACHE_Modifierflag = 0x200,
            WRITECOMBINE_Modifierflag = 0x400
        }

        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool VirtualProtect(IntPtr lpAddress, uint dwSize, uint flNewProtect, out uint lpflOldProtect);

        // windows call to alloc space in the process
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr VirtualAlloc(IntPtr lpAddress, UIntPtr dwSize, AllocationType flAllocationType, MemoryProtection flProtect);

        // windows call to free space in the process
        [System.Runtime.InteropServices.DllImport("kernel32")]
        public static extern bool VirtualFree(IntPtr lpAddress, UInt32 dwSize, UInt32 dwFreeType);
        #endregion WINAPI Imports

        #region virtualAlloc
        //Virtual alloc and marshal copy shellcode to an IntPtr. 
        public static IntPtr VirtualAlloc(byte[] shellcodeIN)
        {
            IntPtr virtualMemory = VirtualAlloc(IntPtr.Zero, new UIntPtr((uint)shellcodeIN.Length), AllocationType.COMMIT | AllocationType.RESERVE, MemoryProtection.EXECUTE_READWRITE);
            System.Runtime.InteropServices.Marshal.Copy(shellcodeIN, 0, virtualMemory, shellcodeIN.Length);
            return virtualMemory;
        }

        #endregion

        #region readFunction
        public delegate void dumpMemoryFunction_ByteArray(IntPtr targetIN, IntPtr memoryIntPtrIN, int sizeOfDataIN);

        public static byte[] DumpAFunction(IntPtr target)
        {
            byte[] memory = new byte[0];
            int tries = 0;
            try
            {
                while (memory.Length < 1 && tries != 4)
                {
                    memory = readFunction(target);
                    tries++;
                }
            }
            catch
            {
            }
            int lastIndex = Array.FindLastIndex(memory, b => b != 0);
            Array.Resize(ref memory, lastIndex + 1);
            return memory;
        }

        public static byte[] readFunction(IntPtr assForeMan)
        {
            IntPtr ptrTemp = new IntPtr(assForeMan.ToInt64());
            byte[] memory = new byte[500];
            int t = 0;
            bool c3 = false;
            for (int i = 0; i < memory.Length; i++)
            {
                memory[i] = System.Runtime.InteropServices.Marshal.ReadByte(new IntPtr(ptrTemp.ToInt64() + i));

                if (memory[i] == 0xc3)
                {
                    c3 = true;
                }
                else if (c3 && memory[i] == 0x00)
                {
                    t++;
                    if (t == 3)
                        break;
                }
                else
                {
                    c3 = false;
                    t = 0;
                }
            }
            int lastIndex = Array.FindLastIndex(memory, b => b == 0xc3);
            Array.Resize(ref memory, lastIndex + 1);
            return memory;
        }
        #endregion

        #region callingMethodWithShellcode
        public delegate void launchShellCodeIntPtr(IntPtr target);

        public static void callATrueIntPtr(IntPtr intPtrToFire, byte[] callingMethodIN)
        {
            IntPtr p = VirtualAlloc(callingMethodIN);
            launchShellCodeIntPtr fireShellcode = (launchShellCodeIntPtr)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(p, typeof(launchShellCodeIntPtr));
            try
            {
                fireShellcode(intPtrToFire);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in callATrueIntPtr because of " + ex.Message);
            }
            VirtualFree(p, 0, 0x8000);
        }

        #endregion

        #region writeShellcode
        public delegate void writeMemoryFunction_ByteArray(IntPtr targetIN, IntPtr memoryIntPtrIN);

        public static void writeDynamicShellcode(IntPtr methodToOverWrite)
        {
            writeFunction(holder, methodToOverWrite);
        }

        //dirty deeds! 
        public static void writeFunction(byte[] ShellCodeInGoodOut, IntPtr assForeMan)
        {
            IntPtr ptrTemp = new IntPtr(assForeMan.ToInt64());
            uint old;
            VirtualProtect(ptrTemp, (uint)8, 0x40, out old);

            for (int i = 0; i < ShellCodeInGoodOut.Length; i++)
            {
                IntPtr temp = new IntPtr(ptrTemp.ToInt64() + i);
                System.Runtime.InteropServices.Marshal.WriteByte(temp, ShellCodeInGoodOut[i]);
            }
        }
        #endregion

        #region read, calling and writing shellcode

        public static void set64bit()
        {
            call_a_fun_ptr = call_a_fun_ptr_64;
            call_a_fun_ptr_INT3 = call_a_fun_ptr_INT3_64;
        }

        static public byte[] holder = new byte[]
        {        
            0x00
        };

        /// <summary>
        /// Takes an IntPtr as an argument and will call it. 
        /// </summary>
        static public byte[] call_a_fun_ptr = new byte[]
        {          
            0x60, //pushad
            0x55,//push ebp
            0x89, 0xe5, //mov ebp, esp
            0x8b, 0x44, 0x24, 0x28,  //mov eax, [esp + 28]
            0xff, 0xd0, //call eax
            0x89, 0xec,//mov esp, ebp
            0x5d, //pop ebp
            0x61, //popad
            0xc3//ret
        };

        static public byte[] call_a_fun_ptr_64 = new byte[]
        {          
            0x55, 0x50, 0x53, 0x52, 0x56, 0x57, 0x55, 0x54, 0x41, 0x50, 0x41, 0x51,
            0x41, 0x52, 0x41, 0x53, 0x41, 0x54, 0x41, 0x55, 0x41, 0x56, 0x41, 0x57,
            0x48, 0x89, 0xe5, 0xff, 0xd1, 0x48, 0x89, 0xec, 0x41, 0x5f, 0x41, 0x5e,
            0x41, 0x5d, 0x41, 0x5c, 0x41, 0x5b, 0x41, 0x5a, 0x41, 0x59, 0x41, 0x58,
            0x5c, 0x5d, 0x5f, 0x5e, 0x5a, 0x5b, 0x58, 0x5d, 0xc3
        };

        static public byte[] call_a_fun_ptr_INT3 = new byte[]
        {    
            0xcc, 0xcc, //Int3
            0x60, //pushad
            0x55,//push ebp
            0x89, 0xe5, //mov ebp, esp
            0x8b, 0x44, 0x24, 0x28,  //mov eax, [esp + 28]
            0xff, 0xd0, //call eax
            0x89, 0xec,//mov esp, ebp
            0x5d, //pop ebp
            0x61, //popad
            0xc3//ret
        };

        static public byte[] call_a_fun_ptr_INT3_64 = new byte[]
        {          
            0xcc,0xcc,   0x55, 0x50, 0x53, 0x52, 0x56, 0x57, 0x55, 0x54, 0x41, 0x50, 0x41, 0x51,
            0x41, 0x52, 0x41, 0x53, 0x41, 0x54, 0x41, 0x55, 0x41, 0x56, 0x41, 0x57,
            0x48, 0x89, 0xe5, 0xff, 0xd1, 0x48, 0x89, 0xec, 0x41, 0x5f, 0x41, 0x5e,
            0x41, 0x5d, 0x41, 0x5c, 0x41, 0x5b, 0x41, 0x5a, 0x41, 0x59, 0x41, 0x58,
            0x5c, 0x5d, 0x5f, 0x5e, 0x5a, 0x5b, 0x58, 0x5d, 0xc3
        };

        #endregion memoryReadingShellcode
    }
}
