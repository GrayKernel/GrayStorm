using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrayStorm
{
    public class CToAsmAttackChain
    {
        #region x86 attack chains
        /// <summary>
        //Cleanup for the payload to restore the origional method. 
        //Requires 12 bytes for 32bit. 
        /// </summary>
        /// <param name="containedIndex">The index in StorageInformation of the Method that will be changed</param>
        /// <param name="methodPointer">The pure IntPtr of the Method that is changing</param>
        /// <param name="indexToStartCleaning">The index in the payload of where 12 bytes can be written.</param>
        static public void payloadCleaner(int containedIndex, IntPtr methodPointer, int indexToStartCleaning)
        {
            int returnMethod = (int)methodPointer.ToInt64();
            int length = GrayStorm.assemblyHelpers.holder.Length - indexToStartCleaning;
            GrayStorm.assemblyHelpers.holder[length] = 0xba; //mov edx
            GrayStorm.assemblyHelpers.holder[length + 1] = (byte)(containedIndex);
            GrayStorm.assemblyHelpers.holder[length + 2] = (byte)(containedIndex >> 8);
            GrayStorm.assemblyHelpers.holder[length + 3] = (byte)(containedIndex >> 16);
            GrayStorm.assemblyHelpers.holder[length + 4] = (byte)(containedIndex >> 24); //contained index
            GrayStorm.assemblyHelpers.holder[length + 5] = 0xb8; //mov eax
            GrayStorm.assemblyHelpers.holder[length + 6] = (byte)(returnMethod);
            GrayStorm.assemblyHelpers.holder[length + 7] = (byte)(returnMethod >> 8);
            GrayStorm.assemblyHelpers.holder[length + 8] = (byte)(returnMethod >> 16);
            GrayStorm.assemblyHelpers.holder[length + 9] = (byte)(returnMethod >> 24); //move eax to returnMethod address
            GrayStorm.assemblyHelpers.holder[length + 10] = 0xff;
            GrayStorm.assemblyHelpers.holder[length + 11] = 0xd0;    //call eax
        }

        /// <summary>
        //Create the new method prelude that will be plotted over the target method.
        /// </summary>
        /// <param name="payloadAddress">The address of the payload. Will be converted into a 7 byte preleude.</param>
        /// <returns></returns>
        static public byte[] newPrelude(IntPtr payloadAddress)
        {
            int payloadIntPtr = (int)payloadAddress.ToInt64();
            byte[] newMemory = new byte[8];
            newMemory[0] = 0xb8;
            newMemory[1] = (byte)(payloadIntPtr);
            newMemory[2] = (byte)(payloadIntPtr >> 8);
            newMemory[3] = (byte)(payloadIntPtr >> 16);
            newMemory[4] = (byte)(payloadIntPtr >> 24); //move eax to payload address
            newMemory[5] = 0xff;
            newMemory[6] = 0xd0; //call eax
            newMemory[7] = 0xc3; //ret
            return newMemory;
        }

        //TODO: 64bit attack
        //20 bytes needed for 64bit theoretically 
        /// <param name="containedIndex">The index in StorageInformation of the Method that will be changed</param>
        /// <param name="methodPointer">The pure IntPtr of the Method that is changing</param>
        /// <param name="indexToStartCleaning">The index in the payload of where 12 bytes can be written.</param>
        static public void payloadCleaner64(int containedIndex, IntPtr methodPointer, int indexToStartCleaning)
        {
            Int64 returnMethod = (Int64)methodPointer.ToInt64();
            int length = GrayStorm.assemblyHelpers.holder.Length - indexToStartCleaning;
            GrayStorm.assemblyHelpers.holder[length] = 0x48;//xor rax, rax
            GrayStorm.assemblyHelpers.holder[length + 1] = 0x31;//xor rax, rax
            GrayStorm.assemblyHelpers.holder[length + 2] = 0xc0;//xor rax, rax
            GrayStorm.assemblyHelpers.holder[length + 3] = 0xba;//mov edx, #
            GrayStorm.assemblyHelpers.holder[length + 4] = (byte)(containedIndex);
            GrayStorm.assemblyHelpers.holder[length + 5] = (byte)(containedIndex >> 8);
            GrayStorm.assemblyHelpers.holder[length + 6] = (byte)(containedIndex >> 16);
            GrayStorm.assemblyHelpers.holder[length + 7] = (byte)(containedIndex >> 24); //contained index
            GrayStorm.assemblyHelpers.holder[length + 8] = 0x48;//mov rax, #
            GrayStorm.assemblyHelpers.holder[length + 9] = 0xb8;//mov edx, #
            GrayStorm.assemblyHelpers.holder[length + 10] = (byte)(returnMethod);//move rax to returnMethod address
            GrayStorm.assemblyHelpers.holder[length + 11] = (byte)(returnMethod >> 8);
            GrayStorm.assemblyHelpers.holder[length + 12] = (byte)(returnMethod >> 16);
            GrayStorm.assemblyHelpers.holder[length + 13] = (byte)(returnMethod >> 24);
            GrayStorm.assemblyHelpers.holder[length + 14] = (byte)(returnMethod >> 32);
            GrayStorm.assemblyHelpers.holder[length + 15] = (byte)(returnMethod >> 40);
            GrayStorm.assemblyHelpers.holder[length + 16] = (byte)(returnMethod >> 48);
            GrayStorm.assemblyHelpers.holder[length + 17] = (byte)(returnMethod >> 56);
            GrayStorm.assemblyHelpers.holder[length + 18] = 0xff;//call rax
            GrayStorm.assemblyHelpers.holder[length + 19] = 0xd0;
        }


        /// <summary>
        //Create the new method prelude that will be plotted over the target method.
        /// </summary>
        /// <param name="payloadAddress">The address of the payload. Will be converted into a 7 byte preleude.</param>
        /// <returns></returns>
        static public byte[] newPrelude64(IntPtr payloadAddress)
        {
            Int64 payloadIntPtr = (Int64)payloadAddress.ToInt64();
            byte[] newMemory = new byte[12];
            newMemory[0] = 0x48;
            newMemory[1] = 0xb8;
            newMemory[2] = (byte)(payloadIntPtr);
            newMemory[3] = (byte)(payloadIntPtr >> 8);
            newMemory[4] = (byte)(payloadIntPtr >> 16);
            newMemory[5] = (byte)(payloadIntPtr >> 24);
            newMemory[6] = (byte)(payloadIntPtr >> 32);
            newMemory[7] = (byte)(payloadIntPtr >> 40);
            newMemory[8] = (byte)(payloadIntPtr >> 48);
            newMemory[9] = (byte)(payloadIntPtr >> 56); //move rax to payload address
            newMemory[10] = 0xff;
            newMemory[11] = 0xd0; //call rax
            return newMemory;
        }
        #endregion x86 attack chains
    }
}
