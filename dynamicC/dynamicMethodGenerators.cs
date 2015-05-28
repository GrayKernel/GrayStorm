using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;


namespace GrayStorm.dynamicC
{
    class dynamicMethodGenerators
    {
        public static DynamicMethod CreateTestMethod(MethodInfo targetIN)
        {
            string name = targetIN.Name;
            ParameterInfo[] myArray = targetIN.GetParameters();
            List<Type> args = new List<Type>();

            foreach (ParameterInfo MyParam in myArray)
                args.Add(MyParam.ParameterType);
            if (targetIN.ReturnType != typeof(void))
            {
                args.Add(targetIN.ReturnType);
            }

            DynamicMethod dynamicMethod =
            new DynamicMethod(
                name,
                MethodAttributes.Static | MethodAttributes.Public,
                CallingConventions.Standard,
                targetIN.ReturnType,
                args.ToArray(),
                targetIN.Module,
                false
                );

            //test method
            Type[] showParameters = { typeof(String) };
            MethodInfo simpleShow = typeof(System.Windows.Forms.MessageBox).GetMethod("Show", showParameters);

            // emit 
            ILGenerator ilgen = dynamicMethod.GetILGenerator();
            ilgen.Emit(OpCodes.Ldstr, "Testing Dynamic Methods");
            ilgen.Emit(OpCodes.Call, simpleShow);
            ilgen.Emit(OpCodes.Pop);
            ilgen.Emit(OpCodes.Ret);
            // Need to call create delegate 
            Action action = dynamicMethod.CreateDelegate(typeof(Action)) as Action;
            //dynamicMethod.Invoke(null, new object[] { });
            return dynamicMethod;
        }
    }
}
