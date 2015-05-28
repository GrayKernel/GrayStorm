using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;

namespace GrayStorm
{
    class formatOutput
    {
        public string setUpDataFormat(ILInstruction instruction)
        {
            MethodInfo methodInfo = instruction.Data as MethodInfo;
            if (methodInfo != null)
            {
                return FormatDataMethod(instruction, methodInfo);
            }

            ConstructorInfo constructorInfo = instruction.Data as ConstructorInfo;
            if (constructorInfo != null)
            {
                return FormatDataConstructor(constructorInfo);
            }

            return null;
        }

        private string FormatDataMethod(ILInstruction instruciton, MethodInfo selectedMethod)
        {
            if (instruciton.Data == null) return "";
            bool isFirst = true;
            StringBuilder sb = new StringBuilder();

            sb.Append(WhatTypeIsIt(selectedMethod.ReturnType));
            sb.Append(" ");
            sb.Append(WhatTypeIsIt(selectedMethod.DeclaringType));
            sb.Append(".");
            sb.Append(selectedMethod.Name);
            sb.Append("(");
            isFirst = true;
            foreach (ParameterInfo parameterInfo in selectedMethod.GetParameters())
            {
                if (isFirst == true) isFirst = false;
                else sb.Append(", ");

                sb.Append(WhatTypeIsIt(parameterInfo.ParameterType));
            }
            sb.Append(")");

            return sb.ToString();
        }

        private string FormatDataConstructor(ConstructorInfo constructorInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(WhatTypeIsIt(constructorInfo.DeclaringType));
            sb.Append(constructorInfo.Name);
            sb.Append("(");
            bool isFirst = true;
            foreach (ParameterInfo parameterInfo in constructorInfo.GetParameters())
            {
                if (isFirst == true) isFirst = false;
                else sb.Append(", ");

                sb.Append(WhatTypeIsIt(parameterInfo.ParameterType));
                sb.Append(" ");
                sb.Append(parameterInfo.Name);
            }
            sb.Append(")");

            return sb.ToString();
        }

        private string WhatTypeIsIt(Type type)
        {
            bool isFirst = true;
            if (type.IsGenericType == false)
            {

                return type.FullName;
            }
            else
            {
                Type genericType = type.GetGenericTypeDefinition();

                StringBuilder sb = new StringBuilder();

                sb.Append(genericType.FullName);
                sb.Append("[");
                foreach (Type parameterType in type.GetGenericArguments())
                {
                    if (isFirst == true) isFirst = false;
                    else sb.Append(", ");

                    sb.Append(WhatTypeIsIt(parameterType as Type));
                }
                sb.Append("]");

                return sb.ToString();
            }
        }
    }
}
