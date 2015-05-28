using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrayStorm.objectHunter
{
    public static class heapObjects
    {
        #region init
        public static char clrVersion = '4';
        public static int clrSub = 1;
        public static int constant = 50000;//can be adjusted.. need better signature :( just till true?

        public delegate IntPtr getMethodTableDel(IntPtr objectIN);

        public static void getAddresses(System.Windows.Forms.ListBox objectsListBox)
        {
            //see if clr is version 2 or 4
            clrVersion = Environment.Version.ToString().ElementAt(0);

            object thisObject = domainTraverser.curObject;
            object foundObject = null;
            IntPtr obj = IntPtr.Zero;
            IntPtr methodTable = IntPtr.Zero;
            List<IntPtr> matchedObjects = null;
            objectsListBox.Items.Clear();
            objectsListBox.Items.Add(thisObject);

            //if (thisObject.GetType() == typeof(foundObject))
            //{
            //    foundObject thisFoundObject = thisObject as foundObject;
            //    thisObject = thisFoundObject.targetObject;
            //}

            //set subAmount on stack for each clr version
            if (IntPtr.Size == 4 && clrVersion == '2')
            {
                if (clrVersion == '2')
                    clrSub = 1;
                else if (clrVersion == '4')
                    clrSub = 2;
            }

            if (IntPtr.Size == 4)
            {
                obj = getObjectAddr(thisObject);
                System.Windows.Forms.MessageBox.Show("OG Object is at " + obj.ToString("X"));

                methodTable = getObjectMethodTable(obj, getMethodTablex86);

                if (methodTable == IntPtr.Zero)
                    return;

                Console.WriteLine("OG Object is at " + obj.ToString("X"));
                Console.WriteLine("method table is at " + methodTable.ToString("X"));

                System.Windows.Forms.MessageBox.Show("OG Object is at " + obj.ToString("X"));
                System.Windows.Forms.MessageBox.Show("method table is at " + methodTable.ToString("X"));

                matchedObjects = getAllObjects(obj, methodTable, getMethodTablex86, getMethodTablex86);
            }
            else if (IntPtr.Size == 8)
            {
                obj = getObjectAddr64(thisObject);
                System.Windows.Forms.MessageBox.Show("OG Object is at " + obj.ToString("X"));

                methodTable = getObjectMethodTable(obj, getMethodTablex64);
                System.Windows.Forms.MessageBox.Show("OG MEtodTable is at " + methodTable.ToString("X"));

                //TODO FIX 3rd ENTRY 
                matchedObjects = getAllObjects(obj, methodTable, getMethodTablex64, getMethodTablex64);
            }


            //unsure if this foreach is needed right now... just take matchedObjects to array?
            foreach (IntPtr actualObj in matchedObjects)
            {
                if (actualObj != null)
                {
                    if (IntPtr.Size == 4)
                        foundObject = GetInstance(actualObj);
                    else if (IntPtr.Size == 8)
                        foundObject = GetInstance64(actualObj);

                    //avoid all the thinLocked objects
                    // var lockedBySomeoneElse = !System.Threading.Monitor.TryEnter(foundObject);
                    // if (!lockedBySomeoneElse)
                    // {
                    //  System.Threading.Monitor.Exit(foundObject);
                    //methodEditorGUI.intptrs.Items.Add(actualObj.ToInt64().ToString("X"));
                    foundObject objTarget = new foundObject();
                    objTarget.targetObject = foundObject;
                    objTarget.name = thisObject.ToString();
                    objTarget.addrOfObj = actualObj;
                    objectsListBox.Items.Add(objTarget);
                    //}
                }
            }
            System.Windows.Forms.MessageBox.Show("num of objects is " + objectsListBox.Items.Count);
        }
        #endregion init

        #region x86

        //Put wantedObject on the stack and grab its value as an IntPtr. 
        //The stack is weird when actually running.
        //In Visual Studio, the location of refer is known and is easy to use
        //as (objectPointer+1) but these values are not present during runtime.
        public static IntPtr getObjectAddr(object wantedObject)
        {
            if (wantedObject == null)
                return IntPtr.Zero;

            IntPtr objectPointer = IntPtr.Zero;
            unsafe
            {
                // System.Windows.Forms.MessageBox.Show("Address of objectPointer:" + (uint)(&objectPointer) + " " + *(&objectPointer));
                //System.Windows.Forms.MessageBox.Show("Address of refer:" + (uint)(&objectPointer- 3) + " " + *(&objectPointer - 3));
                objectPointer = *(&objectPointer - 3);
            }
            return objectPointer;
        }

        static public byte[] getMethodTablex86 = new byte[] 
        {
            0x8b, 0x44, 0x24, 0x04, //mov eax, [esp+4] (arg1 on the stack is the object table)
            0x8b, 0x00, //mov eax, [eax]] (first 4 bytes are the MethodTable) 
            0xc3       //ret (return methodTable for comparsion) 
        };

        static public byte[] get3rdEntryx32 = new byte[]
        {
            0xc3
        };

        public static object GetInstance(IntPtr ptrIN)
        {
            object refer = ptrIN.GetType();
            IntPtr pointer = ptrIN;

            unsafe
            {
                (*(&pointer - clrSub)) = *(&pointer); //move the pointer of our object into the actual object on the stack! This tricks the Framework to think that "object" was declared here! 
            }
            //System.Windows.Forms.MessageBox.Show(refer.ToString());
            return refer;
        }
        #endregion

        #region x64

        public static IntPtr getObjectAddr64(object wantedObject)
        {
            if (wantedObject == null)
                return IntPtr.Zero;

            IntPtr objectPointer = (IntPtr)4;
            object refer = wantedObject;
            IntPtr objectPointer2 = (IntPtr)8;

            unsafe
            {
                //System.Windows.Forms.MessageBox.Show("Address of objectPointer:" + (uint)(&objectPointer) + " address of objectPointer 2 " + (uint)(&objectPointer2));
                objectPointer = *(&objectPointer + clrSub);
            }

            return objectPointer;
        }

        static public byte[] getMethodTablex64 = new byte[] 
        {
            0x48, 0x8b, 0x01, //mov rax, [rcx]
            0xc3              //ret
        };

        //call once the location of an object is known to check against it's 3rd table entry :) 
        static public byte[] get3rdEntryx64 = new byte[] 
        {
            0x48, 0x8b, 0x41, 0x08, 0x48, 0x83, 0xf8, 0x00,
            0x74, 0x03, 0x48, 0x8b,
            0x00, 0xc3
        };


        public static object GetInstance64(IntPtr wantedObject)
        {
            if (wantedObject == null)
                return IntPtr.Zero;

            IntPtr objectPointer = wantedObject;
            object refer = wantedObject.GetType();
            IntPtr objectPointer2 = (IntPtr)8;

            unsafe
            {
                //System.Windows.Forms.MessageBox.Show("Address of objectPointer:" + (uint)(&objectPointer) + " address of objectPointer 2 " + (uint)(&objectPointer2));
                *(&objectPointer + clrSub) = *(&objectPointer);
            }
            //System.Windows.Forms.MessageBox.Show(refer.ToString());
            return refer;
        }

        #endregion x64

        #region generic
        public static IntPtr getObjectMethodTable(IntPtr objectIN, byte[] methodFinderIN)
        {
            IntPtr p = assemblyHelpers.VirtualAlloc(methodFinderIN);
            IntPtr methodTable = IntPtr.Zero;
            getMethodTableDel fireShellcode = (getMethodTableDel)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(p, typeof(getMethodTableDel));

            try
            {
                uint lpflOldProtect = 0;
                assemblyHelpers.VirtualProtect(objectIN, (uint)IntPtr.Size, (uint)0x40, out lpflOldProtect);
                methodTable = fireShellcode(objectIN);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed to get MethodTable " + ex.Message);
                assemblyHelpers.VirtualFree(p, 0, 0x8000);
                return IntPtr.Zero;
            }
            assemblyHelpers.VirtualFree(p, 0, 0x8000);
            return methodTable;
        }

        /*Scan through heap and compare first four bytes of all objects to the method table pointer...
        requires more or less a brute force approach :( (for now) */
        public static List<IntPtr> getAllObjects(IntPtr firstObjectPointer, IntPtr methodTable, byte[] typeOfASM, byte[] entryIN)
        {
            List<IntPtr> matchedObjects = new List<IntPtr>();

            int counter = 1;
            int i = 0;
            int err = 0;
            uint lpflOldProtect = 0;
            IntPtr testObjectLocation = IntPtr.Zero;
            IntPtr testMethodTable = IntPtr.Zero;
            IntPtr test3rdEntry = IntPtr.Zero;
            IntPtr size = IntPtr.Zero;
            object WORK = null;
            IntPtr getMethodTablefuncPtr = assemblyHelpers.VirtualAlloc(typeOfASM);
            getMethodTableDel fireShellcode = (getMethodTableDel)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(getMethodTablefuncPtr, typeof(getMethodTableDel));


            IntPtr get3rdEntry = assemblyHelpers.VirtualAlloc(entryIN);
            getMethodTableDel getSecondRef = (getMethodTableDel)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(get3rdEntry, typeof(getMethodTableDel));

            IntPtr thirdTable = getSecondRef(firstObjectPointer);
            System.Windows.Forms.MessageBox.Show("Third entry at " + thirdTable.ToString("X"));




            //count down first until out of the heap 
            while (true)
            {
                try
                {
                    i = counter * IntPtr.Size;
                    counter++;
                    testObjectLocation = new IntPtr(firstObjectPointer.ToInt64() - i); //get a byte value to test on for an object 
                    //  assemblyHelpers.VirtualProtect(testObjectLocation, (uint)IntPtr.Size, (uint)0x04, out lpflOldProtect);
                    testMethodTable = fireShellcode(testObjectLocation);

                    if (testMethodTable == methodTable)
                    {
                        test3rdEntry = getSecondRef(testObjectLocation);
                        if (test3rdEntry == thirdTable)
                        {
                            Console.WriteLine("Object is at " + testObjectLocation.ToString("X"));

                            if (IntPtr.Size == 4)
                                WORK = GetInstance(testObjectLocation);
                            else if (IntPtr.Size == 8)
                                WORK = GetInstance64(testObjectLocation);

                            matchedObjects.Add(testObjectLocation);

                            Console.WriteLine("Object is at " + testObjectLocation.ToString("X"));
                        }
                    }

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Attempted to read or write protected memory") || ex.Message.Contains("AccessViolationException"))
                    {
                        err++;
                        if (err > 20)
                            break;
                    }
                }
            }

            System.Windows.Forms.MessageBox.Show(testObjectLocation.ToString("X"));
            counter = 1;
            err = 0;
            //count down first until out of the heap 
            while (true)
            {
                try
                {
                    i = counter * IntPtr.Size;
                    counter++;
                    testObjectLocation = new IntPtr(firstObjectPointer.ToInt64() + i); //get a byte value to test on for an object 
                    assemblyHelpers.VirtualProtect(testObjectLocation, (uint)IntPtr.Size, (uint)0x04, out lpflOldProtect);
                    testMethodTable = fireShellcode(testObjectLocation);

                    if (testMethodTable == methodTable)
                    {
                        test3rdEntry = getSecondRef(testObjectLocation);
                        if (test3rdEntry == thirdTable)
                        {
                            Console.WriteLine("Object is at " + testObjectLocation.ToString("X"));

                            if (IntPtr.Size == 4)
                                WORK = GetInstance(testObjectLocation);
                            else if (IntPtr.Size == 8)
                                WORK = GetInstance64(testObjectLocation);

                            matchedObjects.Add(testObjectLocation);

                            Console.WriteLine("Object is at " + testObjectLocation.ToString("X"));
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Attempted to read or write protected memory") || ex.Message.Contains("AccessViolationException"))
                    {
                        err++;
                        if (err > 20)
                            break;
                    }

                }
            }
            System.Windows.Forms.MessageBox.Show(testObjectLocation.ToString("X"));


            assemblyHelpers.VirtualFree(getMethodTablefuncPtr, 0, 0x8000);
            return matchedObjects;
        }
        #endregion generic
    }
}
