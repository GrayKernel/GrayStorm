using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrayStorm.GUI
{
    public partial class memoryHijacker : UserControl
    {
        public memoryHijacker()
        {
            InitializeComponent();
        }

        public StorageInformation currentMethod;
        private void dumpAsm_BT_Click(object sender, EventArgs e)
        {
              editor_RTB.Clear();
            IntPtr trueIntPtr = IntPtr.Zero;
            Delegate targetMethodDelegate = null;

            if (domainTraverser.currentMethod == null)
                return;
            int containedIndex = methodHelpers.containedInList(domainTraverser.currentMethod);
            if (containedIndex == -1 || methodHelpers.StorageInformationArrayList[containedIndex].dumped != true)
            {
                methodDumping dumper = new methodDumping();
                byte[] memory;
                if (containedIndex != -1)
                {
                    memory = dumper.dumpAMethod(methodHelpers.StorageInformationArrayList[containedIndex].methodIntPtr);
                    realAddress_LB.Text = methodHelpers.StorageInformationArrayList[containedIndex].methodIntPtr.ToString("X");
                    if (memory == null)
                    {
                        editor_RTB.AppendText(String.Format("COULD NOT READ MEMORY\n"));
                        return;
                    }
                    else
                    {
                        methodHelpers.StorageInformationArrayList[containedIndex].memory = memory;
                        methodHelpers.StorageInformationArrayList[containedIndex].dumped = true;
                    }
                }
                else
                {
                    methodInvoking invokeMethods = new methodInvoking();
                    System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(domainTraverser.currentMethod.MethodHandle); //JIT the method! 
                    targetMethodDelegate = invokeMethods.getMethodDelegate(domainTraverser.currentMethod); //Get the Delegate of the method.                    
                    trueIntPtr = invokeMethods.getIntPtrFromDelegate(targetMethodDelegate);
                    memory = dumper.dumpAMethod(trueIntPtr);
                    if (memory == null)
                    {
                        editor_RTB.AppendText(String.Format("COULD NOT READ MEMORY\n"));
                        return;
                    }
                    else
                    {
                        currentMethod = new StorageInformation();
                        currentMethod.memory = memory;
                        currentMethod.methodSignature = domainTraverser.currentMethod;
                        currentMethod.dumped = true;
                        currentMethod.methodIntPtr = trueIntPtr;
                        currentMethod.oldMethod = currentMethod.memory;
                        currentMethod.methodDelegate = targetMethodDelegate;
                        methodHelpers.StorageInformationArrayList.Add(currentMethod);
                        containedIndex = methodHelpers.StorageInformationArrayList.Count - 1;
                        realAddress_LB.Text = methodHelpers.StorageInformationArrayList[containedIndex].methodIntPtr.ToString("X");
                    }
                }
            }

            if (disassemble_CB.Checked)
            {
                beaEngine.disassemble disasm = new beaEngine.disassemble();
                disasm.disassembler(methodHelpers.StorageInformationArrayList[containedIndex].memory, this.editor_RTB, methodHelpers.StorageInformationArrayList[containedIndex].methodIntPtr);
            }
            else
            {
                foreach (byte b in methodHelpers.StorageInformationArrayList[containedIndex].memory)
                {
                    editor_RTB.AppendText(String.Format("0x{0:X2}\n", b));
                }
            }
    }
    }
}

