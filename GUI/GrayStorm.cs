using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrayStorm
{
    public partial class grayStorm : Form
    {

        public static TextBox _methodLabel_TB;
        public static TextBox _constructorLabel_TB;
        public static TextBox _addrOfMethod_TB;
        public static TextBox _addrOfConstructor_TB;
        hierarchyViewer _hierarchyViewer;
        shellcode _shellcode;
        public static memoryHijacker _memoryHijacker;
        
        public grayStorm()
        {
            InitializeComponent();
            _hierarchyViewer = hierarchyViewer1;
            _hierarchyViewer.loadhierarchyViewer();

            _shellcode = shellcodeTAB;
            _shellcode.loadShellcode();

            _memoryHijacker = memoryHijacker1;

            _methodLabel_TB = selectedMethod_TB;
            _constructorLabel_TB = selectedConstructor_TB;

            _addrOfMethod_TB = addrOfMethod_TB;
            _addrOfConstructor_TB = addrOfConstructor_TB;

            this.Text = "Gray Storm: CLR " + Environment.Version.ToString().ElementAt(0);
        }

      
    }
}
