using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace GrayStorm
{
    class methodInvoking
    {
        #region callMethod
        //1.) get the signature of the target. (Static/Non-Satic, Return/Non-Return, Arguments)
        public Delegate getMethodDelegate(MethodInfo methodIN)
        {
            Delegate targetMethodDelegate = null;

            if (methodIN.IsStatic)
                System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(methodIN.MethodHandle); //JIT the method!      

            targetMethodDelegate = signatures.getSignature(methodIN);

            return targetMethodDelegate;
        }

        //2.) Get the function pointer from the Delehate
        public IntPtr getIntPtrFromDelegate(Delegate targetIN)
        {
            try
            {
                return (IntPtr)targetIN.Method.MethodHandle.GetFunctionPointer().ToInt64();
            }
            catch { return IntPtr.Zero; }
        }

        //3.) Call the method if needed/wanted.
        public static void fireMethod(IntPtr methodAddress, int whichCall)
        {
            if (whichCall == 0)
                assemblyHelpers.callATrueIntPtr(methodAddress, assemblyHelpers.call_a_fun_ptr);
            else if (whichCall == 1)
                assemblyHelpers.callATrueIntPtr(methodAddress, assemblyHelpers.call_a_fun_ptr_INT3);
        }
        #endregion callMethod
    }
}
