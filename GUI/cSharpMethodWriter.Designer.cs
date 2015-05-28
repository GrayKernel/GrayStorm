namespace GrayStorm
{
    partial class cSharpMethodWriter
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cSharpCode_RTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.method_TB = new System.Windows.Forms.TextBox();
            this.class_TB = new System.Windows.Forms.TextBox();
            this.nameSpace_TB = new System.Windows.Forms.TextBox();
            this.testMethod = new System.Windows.Forms.CheckBox();
            this.addDll_Butt = new System.Windows.Forms.Button();
            this.compile_Butt = new System.Windows.Forms.Button();
            this.errs_RTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cSharpCode_RTB
            // 
            this.cSharpCode_RTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cSharpCode_RTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cSharpCode_RTB.Location = new System.Drawing.Point(0, 0);
            this.cSharpCode_RTB.Name = "cSharpCode_RTB";
            this.cSharpCode_RTB.Size = new System.Drawing.Size(508, 217);
            this.cSharpCode_RTB.TabIndex = 9;
            this.cSharpCode_RTB.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Input the namespace, class for the above. Also if testing a method input a single" +
    " method from the dynamic c# code";
            // 
            // method_TB
            // 
            this.method_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.method_TB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.method_TB.Location = new System.Drawing.Point(3, 275);
            this.method_TB.Name = "method_TB";
            this.method_TB.Size = new System.Drawing.Size(166, 20);
            this.method_TB.TabIndex = 13;
            this.method_TB.Text = "Method";
            // 
            // class_TB
            // 
            this.class_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.class_TB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.class_TB.Location = new System.Drawing.Point(3, 249);
            this.class_TB.Name = "class_TB";
            this.class_TB.Size = new System.Drawing.Size(166, 20);
            this.class_TB.TabIndex = 12;
            this.class_TB.Text = "Class";
            // 
            // nameSpace_TB
            // 
            this.nameSpace_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nameSpace_TB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nameSpace_TB.Location = new System.Drawing.Point(6, 223);
            this.nameSpace_TB.Name = "nameSpace_TB";
            this.nameSpace_TB.Size = new System.Drawing.Size(163, 20);
            this.nameSpace_TB.TabIndex = 11;
            this.nameSpace_TB.Text = "Namespace";
            // 
            // testMethod
            // 
            this.testMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.testMethod.AutoSize = true;
            this.testMethod.Location = new System.Drawing.Point(6, 308);
            this.testMethod.Name = "testMethod";
            this.testMethod.Size = new System.Drawing.Size(146, 17);
            this.testMethod.TabIndex = 18;
            this.testMethod.Text = "test method after creation";
            this.testMethod.UseVisualStyleBackColor = true;
            // 
            // addDll_Butt
            // 
            this.addDll_Butt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addDll_Butt.Location = new System.Drawing.Point(0, 331);
            this.addDll_Butt.Name = "addDll_Butt";
            this.addDll_Butt.Size = new System.Drawing.Size(511, 24);
            this.addDll_Butt.TabIndex = 17;
            this.addDll_Butt.Text = "Add Dlls";
            this.addDll_Butt.UseVisualStyleBackColor = true;
            this.addDll_Butt.Click += new System.EventHandler(this.addDll_Butt_Click);
            // 
            // compile_Butt
            // 
            this.compile_Butt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.compile_Butt.Location = new System.Drawing.Point(0, 355);
            this.compile_Butt.Name = "compile_Butt";
            this.compile_Butt.Size = new System.Drawing.Size(511, 25);
            this.compile_Butt.TabIndex = 16;
            this.compile_Butt.Text = "Compile";
            this.compile_Butt.UseVisualStyleBackColor = true;
            this.compile_Butt.Click += new System.EventHandler(this.compile_Butt_Click);
            // 
            // errs_RTB
            // 
            this.errs_RTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.errs_RTB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.errs_RTB.Location = new System.Drawing.Point(0, 380);
            this.errs_RTB.Name = "errs_RTB";
            this.errs_RTB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errs_RTB.Size = new System.Drawing.Size(511, 54);
            this.errs_RTB.TabIndex = 15;
            this.errs_RTB.Text = "";
            // 
            // cSharpMethodWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.testMethod);
            this.Controls.Add(this.addDll_Butt);
            this.Controls.Add(this.compile_Butt);
            this.Controls.Add(this.errs_RTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.method_TB);
            this.Controls.Add(this.class_TB);
            this.Controls.Add(this.nameSpace_TB);
            this.Controls.Add(this.cSharpCode_RTB);
            this.Name = "cSharpMethodWriter";
            this.Size = new System.Drawing.Size(511, 434);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox cSharpCode_RTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox method_TB;
        private System.Windows.Forms.TextBox class_TB;
        private System.Windows.Forms.TextBox nameSpace_TB;
        private System.Windows.Forms.CheckBox testMethod;
        private System.Windows.Forms.Button addDll_Butt;
        private System.Windows.Forms.Button compile_Butt;
        private System.Windows.Forms.RichTextBox errs_RTB;

    }
}
