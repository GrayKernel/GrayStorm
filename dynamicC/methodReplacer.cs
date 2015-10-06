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
        public static void replaceIL(MethodInfo originalMethod, MethodInfo newMethod)
        {
            //make new user inputted method
            //MethodInfo newMethod = liveMethod.userInputMethod();
            if (newMethod == null || originalMethod == null)
                return;

            // Jit the method if not already
            RuntimeHelpers.PrepareMethod(newMethod.MethodHandle);

            //replace non-dynaically 
            ReplaceMethod(newMethod, originalMethod, false);
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
        /// <param name="dynamicPtr">Whether or not the dynamicMethod is dynamic</param>
        public static void ReplaceMethod(MethodInfo replacementMethod, MethodInfo originalMethod, bool dynamicPtr)
        {
            IntPtr dynamicIntPtr = IntPtr.Zero;
            IntPtr originalMethodIntPtr = IntPtr.Zero;

            unsafe
            {
                originalMethodIntPtr = (IntPtr)(((int*)originalMethod.MethodHandle.Value.ToPointer() + 2));

                if (!dynamicPtr)
                    dynamicIntPtr = (IntPtr)(((int*)replacementMethod.MethodHandle.Value.ToPointer() + 2));
                else
                    dynamicIntPtr = getDynamicIntPtr(replacementMethod);

                ulong* overwriteIntPtr = (ulong*)originalMethodIntPtr.ToPointer();
                if (dynamicPtr)
                {
                    if (IntPtr.Size == 8)
                    {
                        *overwriteIntPtr = (ulong)dynamicIntPtr.ToInt64();
                    }
                    else
                    {
                            *overwriteIntPtr = (uint)dynamicIntPtr.ToInt32();
                    }
                }
                else
                    *overwriteIntPtr = *((uint*)dynamicIntPtr.ToPointer());
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
