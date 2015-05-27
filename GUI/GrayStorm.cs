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

        public static Label _methodLabel_LB;
        public static Label _constructorLabel_LB;
        hierarchyViewer _hierarchyViewer;
        shellcode _shellcode;
        
        public grayStorm()
        {
            InitializeComponent();
            _hierarchyViewer = hierarchyViewer1;
            _hierarchyViewer.loadhierarchyViewer();

            _shellcode = shellcodeTAB;
            _shellcode.loadShellcode();

            _methodLabel_LB = methodLabel_LB;
            _constructorLabel_LB = constructorLabel_LB;
        }

      
    }
}
