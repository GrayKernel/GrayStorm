using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Reflection.Emit;

namespace GrayStorm.dynamic_C
{
    class methodReplacer
    {
        public static void replaceIL(MethodInfo replacementMethod, MethodInfo newMethod)
        {
            //make new user inputted method
            //MethodInfo newMethod = liveMethod.userInputMethod();
            if (newMethod == null || replacementMethod == null)
                return;

            // Jit the method if not already
            RuntimeHelpers.PrepareMethod(newMethod.MethodHandle);

            //replace non-dynaically 
            ReplaceMethod(newMethod, replacementMethod, false);
        }

        public static void DynamicreplaceIL(MethodInfo replacementMethod, int containedIndex)
        {
            // Jit the method if not already
            RuntimeHelpers.PrepareMethod(replacementMethod.MethodHandle);

            //create a dynamic method
            DynamicMethod dynamicMethod = dynamicC.dynamicMethodGenerators.CreateTestMethod(replacementMethod);

            ReplaceMethod(replacementMethod, replacementMethod, true);
        }

        /// <summary>
        /// http://blog.naver.com/techshare/100115994763
        /// </summary>
        /// <param name="dynamicMethod">the destination dynamicMethod/IntPtr</param>
        /// <param name="replacementMethod">the source method/IntPtr</param>
        public static void ReplaceMethod(MethodInfo dynamicMethod, MethodInfo replacementMethod, bool dynamicPtr)
        {
            IntPtr dynamicIntPtr = IntPtr.Zero;

            if (dynamicPtr)
                dynamicIntPtr = getDynamicIntPtr(dynamicMethod);

            IntPtr methodIntPtr;
            unsafe
            {


                //x64 place holder
                if (IntPtr.Size == 8)
                {
                    methodIntPtr = (IntPtr)(((int*)replacementMethod.MethodHandle.Value.ToPointer() + 2));
                    if (!dynamicPtr)
                        dynamicIntPtr = (IntPtr)(((int*)dynamicMethod.MethodHandle.Value.ToPointer() + 2));

                    ulong* overwriteIntPtr = (ulong*)methodIntPtr.ToPointer();
                    if (dynamicPtr)
                        *overwriteIntPtr = (ulong)dynamicIntPtr.ToInt64();
                    else
                        *overwriteIntPtr = *((uint*)dynamicIntPtr.ToPointer());
                }
                //x86
                else
                {
                    methodIntPtr = (IntPtr)(((int*)replacementMethod.MethodHandle.Value.ToPointer() + 2));
                    if (!dynamicPtr)
                        dynamicIntPtr = (IntPtr)(((int*)dynamicMethod.MethodHandle.Value.ToPointer() + 2));

                    uint* overwriteIntPtr = (uint*)methodIntPtr.ToPointer();

                    if (dynamicPtr)
                        *overwriteIntPtr = (uint)dynamicIntPtr.ToInt32();
                    else
                        *overwriteIntPtr = *((uint*)dynamicIntPtr.ToPointer());
                }
            }
        }

        public static IntPtr getDynamicIntPtr(MethodBase dunamicInfo)
        {
            RuntimeMethodHandle handle;
            MethodInfo getMethodDescriptorInfo = typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.NonPublic | BindingFlags.Instance);
            handle = (RuntimeMethodHandle)getMethodDescriptorInfo.Invoke(dunamicInfo, null);
            RuntimeHelpers.PrepareMethod(handle);
            return handle.GetFunctionPointer();
        }
    }
}
