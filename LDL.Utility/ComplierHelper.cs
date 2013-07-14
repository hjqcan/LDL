using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;

namespace LDL.Utility
{
    public class ComplierHelper
    {
        /// <summary>
        /// 动态编译表达式
        /// </summary>
        public static object ComplierCode(string expression)
        {
            string code = WrapExpression(expression);

            CSharpCodeProvider csharpCodeProvider = new CSharpCodeProvider();

            //编译的参数
            CompilerParameters compilerParameters = new CompilerParameters();
            //compilerParameters.ReferencedAssemblies.AddRange();
            compilerParameters.CompilerOptions = "/t:library";
            compilerParameters.GenerateInMemory = true;
            //开始编译
            CompilerResults compilerResults = csharpCodeProvider.CompileAssemblyFromSource(compilerParameters, code);
            if (compilerResults.Errors.Count > 0)
                throw new Exception("编译出错！");

            Assembly assembly = compilerResults.CompiledAssembly;
            Type type = assembly.GetType("ExpressionCalculate");
            MethodInfo method = type.GetMethod("Calculate");
            return method.Invoke(null, null);

        }

        private static string WrapExpression(string expression)
        {
            string code = @"
                using System;

                class ExpressionCalculate
                {

                    public static object Calculate()
                    {
                        return {0};
                    }
                }
            ";

            return code.Replace("{0}", expression);
        }
    }
}
