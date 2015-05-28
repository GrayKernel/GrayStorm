using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;

namespace GrayStorm.GUI
{
    public partial class MethodEditor : UserControl
    {
        public MethodEditor()
        {
            InitializeComponent();
        }

        #region buttons

        ArrayList methodArgs = new ArrayList();
        FieldInfo[] fields;
        PropertyInfo[] properties;
        private void addArgumentButton_Click(object sender, EventArgs e)
        {
            string s = null;

            if (!String.IsNullOrEmpty(addArgsTextBox.Text))
            {

                methodArgs.Add(addArgsTextBox.Text);
                foreach (var item in methodArgs)
                {
                    s += " " + item.ToString();
                }
            }
            else
                addArgumentButton.Text = "Enter Argument";

            enteredArgsLabel.Text = s;
        }

        private void callConstructorButt_Click(object sender, EventArgs e)
        {
            int numberOfArgs = domainTraverser.currentConstructor.GetParameters().Length;
            addArgsTextBox.Text = "Click new constructor or method.";
            if (domainTraverser.currentConstructor != null && methodArgs.Count == numberOfArgs)
            {
                object item = null;
                if (numberOfArgs == 0)
                    item = Activator.CreateInstance(domainTraverser.typeInfo);
                else
                {
                    ParameterInfo[] constructorParams = domainTraverser.currentConstructor.GetParameters();
                    object[] argObjects = new object[methodArgs.Count];
                    string stringType = "";
                    int i = 0;
                    foreach (object ob in methodArgs)
                    {
                        if (ob != null)
                        {
                            stringType = constructorParams[i].ParameterType.Name;
                            try
                            {
                                argObjects[i] = parseObject(ob, stringType);
                            }
                            catch (Exception Exception)
                            {
                                System.Windows.Forms.MessageBox.Show("Constructor err: " + Exception.Message);
                                clearArgsButt_Click(null, null);
                                return;
                            }
                            i++;
                        }
                    }

                    addArgsTextBox.Text = "";
                    if (argObjects.Length < numberOfArgs)
                    {
                        System.Windows.Forms.MessageBox.Show("Too Few Arguments.");
                    }
                    else
                    {
                        try
                        {
                            item = domainTraverser.currentConstructor.Invoke(argObjects);
                        }
                        catch (Exception ex) { string exx = ex.Message; }
                    }
                    enteredArgsLabel.Text = "Entered Args";
                }
                objectsListBox.Items.Add(item);
                methodArgs.Clear();
            
            }
            else
                System.Windows.Forms.MessageBox.Show("Too Few Arguments.");
        }

        private void addObjectButton_Click(object sender, EventArgs e)
        {
            methodArgs.Add(objectsListBox.SelectedItem);
        }
        #endregion buttons

        #region events
        private void objectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            domainTraverser.curObject = objectsListBox.SelectedItem;

            if (domainTraverser.curObject != null)
            {
                fieldsListBox.Items.Clear();
                instanceMethodListBox.Items.Clear();
                propertiesListBox.Items.Clear();

                try
                {
                    foundObject objectFound = domainTraverser.curObject as foundObject;
                    if (objectFound != null)
                    {
                        setConstant.Text = objectFound.addrOfObj.ToString("X");
                        domainTraverser.curObject = objectFound.targetObject;
                    }

                    if (domainTraverser.curObject != null)
                    {
                        MethodInfo[] instanceMethods = domainTraverser.curObject.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                        instanceMethodListBox.Items.AddRange(instanceMethods);

                        fields = domainTraverser.curObject.GetType().GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                        fieldsListBox.Items.AddRange(fields);

                        properties = domainTraverser.curObject.GetType().GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
                        propertiesListBox.Items.AddRange(properties);
                    }
                }
                catch (Exception) { }
            }
        }

        private void fieldsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fieldsListBox.SelectedItem != null)
            {
                fieldValuePlacerholder.Text = "";
                try
                {
                    object fieldData;
                    object meh;
                    FieldInfo temp = fields[fieldsListBox.SelectedIndex];
                    if (temp != null)
                        fieldData = temp.GetValue(domainTraverser.curObject);
                    else
                        fieldData = null;

                    if (fieldData != null)
                    {
                        meh = fieldData;
                        fieldValuePlacerholder.Text = meh.ToString();
                    }
                    else
                        fieldValuePlacerholder.Text = "Cannot eval field";
                }
                catch
                {
                    fieldValuePlacerholder.Text = "Cannot eval field";
                }
            }
        }

        private void propertiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (propertiesListBox.SelectedItem != null)
            {
                propertyValuePlaceholder.Text = "";
                propertyValueTextBox.Text = "";
                try
                {
                    object fieldData;
                    PropertyInfo temp = properties[propertiesListBox.SelectedIndex];
                    if (temp != null)
                        fieldData = temp.GetValue(domainTraverser.curObject, null);
                    else
                        fieldData = null;

                    if (fieldData != null)
                    {
                        var meh = fieldData;
                        propertyValuePlaceholder.Text = meh.ToString();
                    }
                    else
                        propertyValuePlaceholder.Text = "Cannot eval field";

                }
                catch
                {
                    fieldValuePlacerholder.Text = "Cannot eval field";
                }
            }
        }

        private void changePropertyValueButt_Click(object sender, EventArgs e)
        {
            try
            {
                if (propertiesListBox.SelectedItem != null)
                {
                    object x = 0;

                    Type myType = domainTraverser.curObject.GetType();
                    string propertyName = propertiesListBox.SelectedItem.ToString();
                    propertyName = propertyName.Substring(propertyName.IndexOf(" ") + 1);

                    PropertyInfo info = domainTraverser.curObject.GetType().GetProperty(propertyName);
                    string stringType = propertiesListBox.SelectedItem.ToString();
                    stringType = stringType.Substring(0, stringType.LastIndexOf(" ")).Trim();

                    x = parseObject(stringType.GetType(), propertyValueTextBox.Text);
                    info.SetValue(domainTraverser.curObject, x, null);
                    propertiesListBox_SelectedIndexChanged(null, null);
                }
            }
            catch (Exception f)
            {
                System.Windows.Forms.MessageBox.Show("Unable to use this variable " + f.Message);
            }
        }

        private void changeFieldValueButt_Click(object sender, EventArgs e)
        {
            try
            {
                if (fieldsListBox.SelectedItem != null)
                {
                    object x = 0;

                    Type myType = domainTraverser.curObject.GetType();
                    string fieldName = fieldsListBox.SelectedItem.ToString();
                    fieldName = fieldName.Substring(fieldName.IndexOf(" ") + 1);

                    FieldInfo info = domainTraverser.curObject.GetType().GetField(fieldName);
                    string stringType = fieldsListBox.SelectedItem.ToString();
                    stringType = stringType.Substring(0, stringType.LastIndexOf(" ")).Trim();

                    object ob = fieldValueTextBox.Text;
                    x = parseObject(stringType.GetType(), fieldValueTextBox.Text);
                    info.SetValue(domainTraverser.curObject, x);
                    fieldsListBox_SelectedIndexChanged(null, null);
                }
            }
            catch (Exception f)
            {
                System.Windows.Forms.MessageBox.Show("Unable to use this variable " + f.Message);
            }
        }

        private void getAllObjects_Click(object sender, EventArgs e)
        {
            if (domainTraverser.curObject != null)
                objectHunter.heapObjects.getAddresses(objectsListBox);
        }

        private void callInstanceMethodButt_Click(object sender, EventArgs e)
        {
            if (instanceMethodListBox.SelectedItem != null)
            {
                try
                {
                    Delegate instanceTestMethod = signatures.getSignature(instanceMethodListBox.SelectedItem as MethodInfo, domainTraverser.curObject);
                    //if (cb_fireAllObjects.Checked)
                    //{
                    //    foreach (object obj in objectsListBox.Items)
                    //    {
                    //        foundObject objectFound = obj as foundObject;
                    //        if (objectFound == null)
                    //            continue;
                    //        if (objectFound.GetType() == typeof(foundObject))
                    //        {
                    //            doInstanceCall(objectFound);
                    //        }
                    //    }
                    //}
                    //   else
                    //  {
                    // System.Threading.Thread call = new System.Threading.Thread
                    // (
                    //      () =>
                    //    {
                    //    instanceTestMethod = signatures.getSignature(instanceMethodListBox.SelectedItem as MethodInfo, curObject);
                    //   System.Threading.Thread call = new System.Threading.Thread
                    //  (
                    //   () =>
                    //  {
                    try { makeMethodCall(instanceTestMethod); }
                    catch { }
                    // }
                    //  );

                    // call.Start();
                    // System.Threading.Thread.Sleep(100);
                    // call.Abort();
                    //  }
                }
                catch (Exception ex) { string lol = ex.Message; }
                //changeObjTree();
            }
        }

        private void callMethod_Click(object sender, EventArgs e)
        {
            if (methodListBox.SelectedItem != null)
            {
                makeMethodCall(signatures.getSignature(methodListBox.SelectedItem as MethodInfo));
            }
        }

        private void removeObjectButt_Click(object sender, EventArgs e)
        {
            objectsListBox.Items.Remove(objectsListBox.SelectedItem);
            instanceMethodListBox.Items.Clear();
            fieldsListBox.Items.Clear();
            propertiesListBox.Items.Clear();
        }


        private void methodListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion events

        #region helperMethods
        //TODO ADD INTPTR FUNCS
        private object parseObject(object ob, string stringType)
        {
            try
            {
                if (ob.ToString().Equals("null"))
                {
                    return null;
                }
                else if (stringType.Equals("Int32"))
                {
                    return Convert.ToInt32(ob);
                }
                else if (stringType.Equals("UInt32"))
                {
                    return Convert.ToUInt32(ob);
                }
                else if (stringType.Equals("Int16"))
                {
                    return Convert.ToInt16(ob);
                }
                else if (stringType.Equals("UInt16"))
                {
                    return Convert.ToUInt16(ob);
                }
                else if (stringType.Equals("Int64"))
                {
                    return Convert.ToInt64(ob);
                }
                else if (stringType.Equals("UInt64"))
                {
                    return Convert.ToUInt64(ob);
                }
                else if (stringType.Equals("Boolean"))
                {
                    return Convert.ToBoolean(ob);
                }
                else if (stringType.Equals("Byte"))
                {
                    return Convert.ToByte(ob);
                }
                else if (stringType.Equals("SByte"))
                {
                    return Convert.ToSByte(ob);
                }
                else if (stringType.Equals("Char"))
                {
                    return Convert.ToChar(ob);
                }
                else if (stringType.Equals("Double"))
                {
                    return Convert.ToDouble(ob);
                }
                else if (stringType.Equals("Single"))
                {
                    return Convert.ToSingle(ob);
                }
                else if (stringType.Equals("String"))
                {
                    return Convert.ToString(ob);
                }
                else if (stringType.Equals("DateTime"))
                {
                    return Convert.ToDateTime(ob);
                }
                else if (stringType.Equals("Decimal"))
                {
                    return Convert.ToDecimal(ob);
                }
                else
                    return null;
            }
            catch { throw; }
        }

        private void clearArgsButt_Click(object sender, EventArgs e)
        {
            enteredArgsLabel.Text = "";
            methodArgs.Clear();
            addArgsTextBox.Text = "Pick new Constructor or Method";
        }

        public void makeMethodCall(Delegate methodToCall)
        {
            addArgsTextBox.Text = "Click new constructor or method.";
            object[] argObjects = new object[methodArgs.Count];
            if (argObjects.Length != domainTraverser.currentConstructor.GetParameters().Length)
            {
                System.Windows.Forms.MessageBox.Show("Wrong arguments");
                methodArgs.Clear();
                enteredArgsLabel.Text = "Entered Args";
                return;
            }
            string stringType = "";
            int i = 0;
            ParameterInfo[] instancePars = methodToCall.Method.GetParameters();
            foreach (object ob in methodArgs)
            {
                if (ob != null)
                {
                    stringType = instancePars[i].ParameterType.Name;
                    try
                    {
                        argObjects[i] = parseObject(ob, stringType);
                    }
                    catch (Exception Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Constructor err: " + Exception.Message);
                        clearArgsButt_Click(null, null);
                        return;
                    }
                    i++;
                }
            }

            object[] returned = null;
            object returned_Temp = null;

            if (argObjects.Length == 0)
            {
                returned_Temp = methodToCall.DynamicInvoke();
            }
            else
            {
                returned_Temp = methodToCall.DynamicInvoke(argObjects);
            }

            if (methodToCall.Method.ReturnParameter.ParameterType != typeof(void))
            {
                returned = new object[1];
                returned[0] = returned_Temp;
            }

            if (returned != null)
            {
                objectsListBox.Items.Add(returned[0]);
            }

            enteredArgsLabel.Text = "Entered Args";
            methodArgs.Clear();
        }

        #endregion helperMethods


    }
}
