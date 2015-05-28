using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace GrayStorm
{
    public partial class cSharpMethodWriter : UserControl
    {
        private List<string> assemblyReferences = new List<string>();
        public cSharpMethodWriter()
        {
            InitializeComponent();
            cSharpCode_RTB.Text = "using System; \n namespace customCSharp \n { \t\n class customClass  \t\n { \t\n } \n }";
            nameSpace_TB.Text = "customCSharp";
            class_TB.Text = "customClass";
        }


        //TODO FIX METHODS APPEARING MORE THAN ONCE IN LISTING 
        private void compile_Butt_Click(object sender, EventArgs e)
        {
            MethodInfo compiledCSharp;
            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateInMemory = true;

            foreach (string refAsm in assemblyReferences)
                parameters.ReferencedAssemblies.Add(refAsm);

            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                try
                {
                    string location = assembly.Location;
                    if (!String.IsNullOrEmpty(location))
                    {
                        parameters.ReferencedAssemblies.Add(location);
                    }
                }
                catch (NotSupportedException)
                {
                    //  this happens for dynamic assemblies, so just ignore it. 
                }

                CompilerResults results = provider.CompileAssemblyFromSource(parameters, cSharpCode_RTB.Text);
                errs_RTB.Clear();

                if (results.Errors.HasErrors)
                {
                    foreach (CompilerError error in results.Errors)
                    {
                        errs_RTB.AppendText(String.Format("Error Line {0} -> ({1}): {2}\n", error.Line, error.ErrorNumber, error.ErrorText));
                    }
                    return;
                }

                Type binaryFunction = results.CompiledAssembly.GetType(nameSpace_TB.Text + "." + class_TB.Text);
                if (binaryFunction == null)
                {
                    errs_RTB.AppendText("Adding Methods failed... no existing namespace and class");
                }
                else
                {
                    if (testMethod.Checked)
                    {
                        compiledCSharp = binaryFunction.GetMethod(method_TB.Text, BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
                        if (compiledCSharp == null)
                        {
                            errs_RTB.AppendText("Method does not exist");
                            return;
                        }
                        else
                            compiledCSharp.Invoke(null, new object[] { });
                    }
                    foreach (MethodInfo method in binaryFunction.GetMethods(BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                        dynamicC.userCreatedMethods.userCreatedMethodsList.Add(method);

                    errs_RTB.AppendText("Methods added to userCreatedMethodsList.\n");
                    grayStorm._memoryHijacker.dynamicMethods_LB.Items.Clear();
                    grayStorm._memoryHijacker.dynamicMethods_LB.Items.AddRange(dynamicC.userCreatedMethods.userCreatedMethodsList.ToArray());
                    grayStorm._memoryHijacker.dynamicMethods_LB.Refresh();
                }
            }
        }

        private void addDll_Butt_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog file = new OpenFileDialog();
            file.Multiselect = true;
            file.Filter = "dll files (*.dll)|*.dll";
            file.Title = "Select a dll/exe code base";
            file.ShowDialog();
            assemblyReferences.Add(file.FileName);
        }
    }
}
