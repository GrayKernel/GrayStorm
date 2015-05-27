using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
using System.Linq.Expressions;

namespace GrayStorm
{
    public class signatures
    {
        public static Delegate getSignature(MethodInfo targetMethod, object target = null)
        {
            ParameterInfo[] myArray = targetMethod.GetParameters();
            List<Type> args = new List<Type>();

            foreach (ParameterInfo MyParam in myArray)
                args.Add(MyParam.ParameterType);

            Type delegateType;
            if (targetMethod.ReturnType == typeof(void))
            {
                try
                {
                    delegateType = Expression.GetActionType(args.ToArray());
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                args.Add(targetMethod.ReturnType);
                try
                {
                    delegateType = Expression.GetFuncType(args.ToArray());
                }
                catch
                {
                    return null;
                }

            }
            try
            {
                if (delegateType != null)
                {
                    Delegate methodDelegate = null;
                    System.Threading.Thread call = new System.Threading.Thread
                    (
                   () =>
                   {
                       try { methodDelegate = Delegate.CreateDelegate(delegateType, target, targetMethod); }
                       catch { }
                   }
                     );
                    call.Start();
                    System.Threading.Thread.Sleep(100);
                    call.Abort();
                    return methodDelegate;
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
