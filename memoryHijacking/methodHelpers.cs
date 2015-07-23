using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;

namespace GrayStorm
{
    #region storageInformationHelpers
    /// <summary>
    /// All of the global static variables we need for the project will be declared here. Namely, the array list of storageInformation. 
    /// </summary>
    public static class methodHelpers
    {
        //publics for the class for methodInformation. 
        public static List<StorageInformation> StorageInformationArrayList = new List<StorageInformation>();

        public static Delegate methodInfoToDelegate(System.Reflection.MethodInfo methodIN)
        {
            Delegate signatureOfTarget = signatures.getSignature(methodIN);
            return signatureOfTarget;
        }

        //Boring linear search to find the index of the targeted method. O(N). 
        public static int containedInList(MethodInfo selectedMethod)
        {
            int x;
            for (x = 0; x < StorageInformationArrayList.Count; x++)
            {
                if (StorageInformationArrayList[x].methodSignature == selectedMethod)
                    return x;
            }
            return -1;
        }


    }
    #endregion storageInformationHelpers
}
