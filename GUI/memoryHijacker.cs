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
    public partial class memoryHijacker : UserControl
    {
        public memoryHijacker()
        {
            InitializeComponent();

        }
        public StorageInformation currentMethod;

        #region buttons

        public void dumpAsm_BT_Click(object sender, EventArgs e)
        {
            editor_RTB.Clear();
            IntPtr trueIntPtr = IntPtr.Zero;
            Delegate targetMethodDelegate = null;

            if (domainTraverser.currentMethod == null || domainTraverser.currentMethod.Name.Contains("Dispose"))
                return;
            int containedIndex = methodHelpers.containedInList(domainTraverser.currentMethod);
            if (containedIndex == -1 || methodHelpers.StorageInformationArrayList[containedIndex].dumped != true)
            {
                methodDumping dumper = new methodDumping();
                byte[] memory;
                if (containedIndex != -1)
                {
                    memory = dumper.dumpAMethod(methodHelpers.StorageInformationArrayList[containedIndex].methodIntPtr);
                    grayStorm._addrOfMethod_TB.Text = methodHelpers.StorageInformationArrayList[containedIndex].methodIntPtr.ToString("X");
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
                    grayStorm._addrOfMethod_TB.Text = domainTraverser.currentMethod.MethodHandle.GetFunctionPointer().ToString("X");
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
                        grayStorm._addrOfMethod_TB.Text = methodHelpers.StorageInformationArrayList[containedIndex].methodIntPtr.ToString("X");
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

        public void getIL_BT_Click(object sender, EventArgs e)
        {
            if (domainTraverser.currentMethod == null)
                return;
            editor_RTB.Clear();
            formatOutput formatOutput = new formatOutput();
            foreach (ILInstruction instruciton in ILInstructionLoader.GetInstructions(domainTraverser.currentMethod))
            {
                editor_RTB.AppendText(instruciton.Offset.ToString("X4") + " " + instruciton.OpCode + " " + formatOutput.setUpDataFormat(instruciton) + "\n");
            }
        }

        private void fireMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dynamicMethods_LB.SelectedItem != null)
            {
                MethodInfo customMethod = dynamicMethods_LB.SelectedItem as MethodInfo;
                methodInvoking.fireMethod(customMethod.MethodHandle.GetFunctionPointer(), 0);
            }
        }

        private void changeCallAddressFromCuscomC0xFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntPtr cSharpIntPtr = getAddressForFire();
            assemblyControlFlow.replaceDwordCall(cSharpIntPtr);
        }

        private void changeCallAddressFromCuscomC0xE8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntPtr cSharpIntPtr = getAddressForFire();
            assemblyControlFlow.replaceE8Call(cSharpIntPtr);
        }

        private void changeCallAddressFromCachedMethod0xFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hierarchyViewer.savedCachePtr == -1)
                return;
            assemblyControlFlow.replaceDwordCall(methodHelpers.StorageInformationArrayList[hierarchyViewer.savedCachePtr].methodIntPtr);
        }

        private void changeCallAddressFromCachedMethod0xE8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hierarchyViewer.savedCachePtr == -1)
                return;
            assemblyControlFlow.replaceE8Call(methodHelpers.StorageInformationArrayList[hierarchyViewer.savedCachePtr].methodIntPtr);
        }

        private void getILCustomCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedMethod = dynamicMethods_LB.SelectedItem as MethodInfo;
            if (selectedMethod == null)
                return;
            editor_RTB.Clear();
            formatOutput formatOutput = new formatOutput();
            foreach (ILInstruction instruciton in ILInstructionLoader.GetInstructions(selectedMethod))
            {
                editor_RTB.AppendText(instruciton.Offset.ToString("X4") + " " + instruciton.OpCode + " " + formatOutput.setUpDataFormat(instruciton) + "\n");
            }
        }


        private void dumpAssemblyCustomCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedMethod = dynamicMethods_LB.SelectedItem as MethodInfo;
             methodDumping dumper = new methodDumping();
             methodInvoking invokeMethods = new methodInvoking();
                byte[] memory;
                if (selectedMethod != null)
                {
                    System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(selectedMethod.MethodHandle); //JIT the method! 
                    Delegate targetMethodDelegate = invokeMethods.getMethodDelegate(domainTraverser.currentMethod); //Get the Delegate of the method.                    
                    IntPtr trueIntPtr = invokeMethods.getIntPtrFromDelegate(targetMethodDelegate);
                    memory = dumper.dumpAMethod(trueIntPtr);
                    if (memory == null)
                    {
                        editor_RTB.AppendText(String.Format("COULD NOT READ MEMORY\n"));
                        return;
                    }
                    else
                    {
                        foreach (byte b in memory)
                        {
                            editor_RTB.AppendText(String.Format("0x{0:X2}\n", b));
                        }
                    }
                }
        }
        #endregion buttons

        #region helpers
        public void setDisassembleChecked()
        {
            disassemble_CB.Checked = true;
        }

        public void setDisassembleUnchecked()
        {
            disassemble_CB.Checked = false;
        }

        private IntPtr getAddressForFire()
        {
            var selectedMethod = dynamicMethods_LB.SelectedItem as MethodInfo;
            if (selectedMethod == null)
                return IntPtr.Zero;
            IntPtr trueIntPtr = IntPtr.Zero;
            Delegate targetMethodDelegate = null;
            methodInvoking invokeMethods = new methodInvoking();
            targetMethodDelegate = invokeMethods.getMethodDelegate(selectedMethod); //Get the Delegate of the method.                    
            trueIntPtr = invokeMethods.getIntPtrFromDelegate(targetMethodDelegate);
            return trueIntPtr;
        }
        #endregion helpers


       

     
    

        

     

    

       
      
    }
}

