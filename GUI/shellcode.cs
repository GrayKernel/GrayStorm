using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace GrayStorm
{
    public partial class shellcode : UserControl
    {
        #region init
        GrayStorm.dataBox payload;

        public shellcode()
        {
            InitializeComponent();
        }

        public void loadShellcode()
        {
            foreach (var payloads in GrayStorm.shellcodes.payloads.payloadsList())
                payloads_LB.Items.Add(payloads);

            foreach (var metaPayloads in GrayStorm.shellcodes.payloads.metaSploitList())
                metaSploit_LB.Items.Add(metaPayloads);
        }
        #endregion init

        #region listBox selecting
        private void payloads_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (payloads_LB.SelectedIndex == -1)
                return;
            object shellcode = payloads_LB.SelectedItem;
            displayPayload(shellcode);
            metaSploit_LB.SelectedIndex = -1;
        }

        private void metaSploit_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metaSploit_LB.SelectedIndex == -1)
                return;
            object shellcode = metaSploit_LB.SelectedItem;
            displayPayload(shellcode);
            payloads_LB.SelectedIndex = -1;
        }

        private void displayPayload(object shellcode)
        {
            shellcode_RTB.Clear();
            payload = shellcode as GrayStorm.dataBox;
            if (shellcode is GrayStorm.dataBox)
            {
                if (disassemble_CB.Checked)
                {
                    beaEngine.disassemble disasm = new beaEngine.disassemble();
                    unsafe
                    {
                        //Prevent garbage collector from relocating a movable variable for the duration of the disassembly and get the IntPtr of a byte array. 
                        fixed (byte* pointer = payload.data)
                        {
                            IntPtr offset = (IntPtr)pointer;
                            disasm.disassembler(payload.data, this.shellcode_RTB, offset);
                        }
                    }
                }
                else
                {
                    foreach (byte opcode in payload.data)
                    {
                        shellcode_RTB.AppendText(String.Format("0x{0:X2}\n", opcode));

                    }
                }
            }
        }
        #endregion listBox selecting

        #region inject shellcode
        private void fireShellcode_BT_Click(object sender, EventArgs e)
        {
            if (metaSploit_LB.SelectedIndex != -1 || payloads_LB.SelectedIndex != -1)
            {
                GrayStorm.assemblyHelpers.holder = payload.data;
            }
            else
                return;

            int containedIndex = methodHelpers.containedInList(GrayStorm.domainTraverser.currentMethod);
            if (containedIndex == -1)
                return;
            
            methodHelpers.StorageInformationArrayList[containedIndex].dumped = false;

            if (hookMethod_CB.Checked && IntPtr.Size == 4)
                hookTargetMethod(containedIndex);
            else if (hookMethod_CB.Checked && IntPtr.Size == 8)
                hookTargetMethod64(containedIndex);
            else
            {
                try
                {
                    DialogResult dialogResult = DialogResult.Yes;
                    if (payload.data.Length >= methodHelpers.StorageInformationArrayList[containedIndex].oldMethod.Length)
                    {
                        dialogResult = MessageBox.Show("Length of shellcode is longer than the origional memory... Continue?", "Warning", MessageBoxButtons.YesNo);
                    }
                    if (dialogResult == DialogResult.Yes)
                    {
                        methodHijacking.writeAMethod(methodHelpers.StorageInformationArrayList[containedIndex].methodIntPtr);
                    }
                }
                catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.ToString()); }
            }
        }

        private void hookTargetMethod(int containedIndex)
        {
            int indexToStartCleaning = payload.indexToStartCleaning;

            //payload cannot be used with this attack chain if there is no proper index to store reset assembly. 
            if (indexToStartCleaning == 0)
            {
                System.Windows.Forms.MessageBox.Show("Payload doesn't support hooking");
                return;
            }
            MethodInfo safeCall = typeof(shellcode).GetMethod("returnOldMethod", BindingFlags.Public | BindingFlags.Static);
            IntPtr safeCallPtr = (IntPtr)safeCall.MethodHandle.GetFunctionPointer().ToInt64();

            CToAsmAttackChain.payloadCleaner(containedIndex, safeCallPtr, indexToStartCleaning);
            IntPtr payloadAddress = assemblyHelpers.VirtualAlloc(GrayStorm.assemblyHelpers.holder);
            System.Runtime.InteropServices.Marshal.Copy(GrayStorm.assemblyHelpers.holder, 0, payloadAddress, GrayStorm.assemblyHelpers.holder.Length);

            byte[] newMemory = CToAsmAttackChain.newPrelude(payloadAddress);
            GrayStorm.assemblyHelpers.holder = newMemory;
            methodHijacking.writeAMethod(methodHelpers.StorageInformationArrayList[containedIndex].methodIntPtr);
        }

        //method called in the hook phase of the CToAsmAttack cycle. 
        public static void returnOldMethod(int somePtr, int selectedIndex)
        {
            GrayStorm.assemblyHelpers.holder = methodHelpers.StorageInformationArrayList[selectedIndex].oldMethod;
            methodHijacking.writeAMethod(methodHelpers.StorageInformationArrayList[selectedIndex].methodIntPtr);
            try
            {

                methodHelpers.StorageInformationArrayList[selectedIndex].methodDelegate.DynamicInvoke(null, new object[] { });
            }
            catch { }
        } 

        //TODO
        private void hookTargetMethod64(int containedIndex)
        {
            //int indexToStartCleaning = payload.indexToStartCleaning;
            ////payload cannot be used with this attack chain if there is no proper index to store reset assembly. 
            //if (indexToStartCleaning == 0)
            //{
            //    System.Windows.Forms.MessageBox.Show("Payload doesn't support hooking");
            //    return;
            //}

            //MethodInfo safeCall = typeof(shellcodeGUI).GetMethod("returnOldMethod", BindingFlags.NonPublic | BindingFlags.Instance);
            //IntPtr safeCallPtr = (IntPtr)safeCall.MethodHandle.GetFunctionPointer().ToInt64();

            //CToAsmAttackChain.payloadCleaner64(containedIndex, safeCallPtr, indexToStartCleaning);
            //IntPtr payloadAddress = assemblyHelpers.VirtualAlloc(memoryHijacker.assemblyHelpers.holder);
            //System.Runtime.InteropServices.Marshal.Copy(memoryHijacker.assemblyHelpers.holder, 0, payloadAddress, memoryHijacker.assemblyHelpers.holder.Length);

            //byte[] newMemory = CToAsmAttackChain.newPrelude64(payloadAddress);
            //GrayStorm.assemblyHelpers.holder = newMemory;
            //methodHijacking.writeAMethod(methodHelpers.StorageInformationArrayList[containedIndex].methodIntPtr);
        }

     

        #endregion inject shellcode

        #region restore code
        private void restoreCode_BT_Click(object sender, EventArgs e)
        {
            int containedIndex = GrayStorm.methodHelpers.containedInList(domainTraverser.currentMethod);
            if (containedIndex == -1)
                return;
            try
            {
                GrayStorm.assemblyHelpers.holder = methodHelpers.StorageInformationArrayList[containedIndex].oldMethod;
                methodHijacking.writeAMethod(methodHelpers.StorageInformationArrayList[containedIndex].methodIntPtr);
                methodHelpers.StorageInformationArrayList[containedIndex].dumped = false;
         
            }
            catch { }
        }
        #endregion restore code

        #region newShellcode
        private void createShellcode_BT_Click(object sender, EventArgs e)
        {
            byte[] shellcode;
            string insertedShellcode = createShellcode_RTB.Text;
            bool metaSploit = false;
            int offset = 0;
            shellcode_RTB.Clear();
            insertedShellcode = insertedShellcode.Replace("\\x", string.Empty);
            insertedShellcode = insertedShellcode.Replace("0x", string.Empty);
            insertedShellcode = insertedShellcode.Replace(", ", string.Empty);
            insertedShellcode = insertedShellcode.Replace("\n", string.Empty);
            insertedShellcode = System.Text.RegularExpressions.Regex.Replace(insertedShellcode, @"\W+", "");
            shellcode = new byte[insertedShellcode.Length];

            try
            {
                for (int i = 0; i < insertedShellcode.Length; i += 2)
                    shellcode[i / 2] = Convert.ToByte(insertedShellcode.Substring(i, 2), 16);
                if (payloads_LB.SelectedIndex == -1 && metaSploit_LB.SelectedIndex == -1)
                    return;
                else if (payloads_LB.SelectedIndex == -1)
                    metaSploit = true;
                else
                    metaSploit = false;

                //remove those tailing 0's
                int lastIndex = Array.FindLastIndex(shellcode, b => b != 0);
                Array.Resize(ref shellcode, lastIndex + 1);
            }
            catch
            {
                shellcode_RTB.AppendText("Invalid shellcode detected. Only use shellcode in the form of \n\"\\x##\" \n\"0x##\" \n##\n Shellcode must have 0x##, assembler does not support 0x# operands");
                return;
            }

            try
            {
                offset = Convert.ToInt32(hookOffset_TB.Text);
            }
            catch
            {
                shellcode_RTB.AppendText("Payload hook offset not in the correct format.\n Please make it a value. -1 means there is none");
                return;
            }

            dataBox newPayload = new dataBox(payloadName_TB.Text, shellcode, offset);

            if (metaSploit)
            {
                metaSploit_LB.Items.Add(newPayload);
            }
            else
                payloads_LB.Items.Add(newPayload);
        }
        #endregion newShellcode
    }
}
