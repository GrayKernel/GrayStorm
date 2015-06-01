namespace GrayStorm
{
    partial class grayStorm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(grayStorm));
            this.information_panel = new System.Windows.Forms.Panel();
            this.addrOfMethod_TB = new System.Windows.Forms.TextBox();
            this.addrOfMethod_L = new System.Windows.Forms.Label();
            this.selectedConstructor_TB = new System.Windows.Forms.TextBox();
            this.selectedMethod_TB = new System.Windows.Forms.TextBox();
            this.constructor_LB = new System.Windows.Forms.Label();
            this.methodSelected_LB = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.hierarchyViewer1 = new GrayStorm.hierarchyViewer();
            this.mainControl_TAB = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.memoryHijacker1 = new GrayStorm.memoryHijacker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.shellcodeTAB = new GrayStorm.shellcode();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cSharpMethodWriter1 = new GrayStorm.cSharpMethodWriter();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.methodEditor1 = new GrayStorm.GUI.MethodEditor();
            this.addrOfConstructor_TB = new System.Windows.Forms.TextBox();
            this.addrCon_L = new System.Windows.Forms.Label();
            this.information_panel.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.mainControl_TAB.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // information_panel
            // 
            this.information_panel.Controls.Add(this.addrOfConstructor_TB);
            this.information_panel.Controls.Add(this.addrCon_L);
            this.information_panel.Controls.Add(this.addrOfMethod_TB);
            this.information_panel.Controls.Add(this.addrOfMethod_L);
            this.information_panel.Controls.Add(this.selectedConstructor_TB);
            this.information_panel.Controls.Add(this.selectedMethod_TB);
            this.information_panel.Controls.Add(this.constructor_LB);
            this.information_panel.Controls.Add(this.methodSelected_LB);
            this.information_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.information_panel.Location = new System.Drawing.Point(0, 0);
            this.information_panel.Name = "information_panel";
            this.information_panel.Size = new System.Drawing.Size(845, 45);
            this.information_panel.TabIndex = 1;
            // 
            // addrOfMethod_TB
            // 
            this.addrOfMethod_TB.Location = new System.Drawing.Point(92, 22);
            this.addrOfMethod_TB.Name = "addrOfMethod_TB";
            this.addrOfMethod_TB.Size = new System.Drawing.Size(251, 20);
            this.addrOfMethod_TB.TabIndex = 6;
            this.addrOfMethod_TB.Text = "Address of Method";
            // 
            // addrOfMethod_L
            // 
            this.addrOfMethod_L.AutoSize = true;
            this.addrOfMethod_L.Location = new System.Drawing.Point(3, 24);
            this.addrOfMethod_L.Name = "addrOfMethod_L";
            this.addrOfMethod_L.Size = new System.Drawing.Size(83, 13);
            this.addrOfMethod_L.TabIndex = 5;
            this.addrOfMethod_L.Text = "Addr of Method:";
            // 
            // selectedConstructor_TB
            // 
            this.selectedConstructor_TB.Location = new System.Drawing.Point(467, 1);
            this.selectedConstructor_TB.Name = "selectedConstructor_TB";
            this.selectedConstructor_TB.Size = new System.Drawing.Size(253, 20);
            this.selectedConstructor_TB.TabIndex = 4;
            // 
            // selectedMethod_TB
            // 
            this.selectedMethod_TB.Location = new System.Drawing.Point(90, 0);
            this.selectedMethod_TB.Name = "selectedMethod_TB";
            this.selectedMethod_TB.Size = new System.Drawing.Size(253, 20);
            this.selectedMethod_TB.TabIndex = 3;
            // 
            // constructor_LB
            // 
            this.constructor_LB.AutoSize = true;
            this.constructor_LB.Location = new System.Drawing.Point(349, 0);
            this.constructor_LB.Name = "constructor_LB";
            this.constructor_LB.Size = new System.Drawing.Size(112, 13);
            this.constructor_LB.TabIndex = 2;
            this.constructor_LB.Text = "Constructor Selected: ";
            // 
            // methodSelected_LB
            // 
            this.methodSelected_LB.AutoSize = true;
            this.methodSelected_LB.Location = new System.Drawing.Point(3, 4);
            this.methodSelected_LB.Name = "methodSelected_LB";
            this.methodSelected_LB.Size = new System.Drawing.Size(94, 13);
            this.methodSelected_LB.TabIndex = 0;
            this.methodSelected_LB.Text = "Method Selected: ";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.information_panel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(845, 503);
            this.splitContainer2.SplitterDistance = 45;
            this.splitContainer2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.hierarchyViewer1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mainControl_TAB);
            this.splitContainer1.Size = new System.Drawing.Size(845, 454);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 0;
            // 
            // hierarchyViewer1
            // 
            this.hierarchyViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hierarchyViewer1.Location = new System.Drawing.Point(0, 0);
            this.hierarchyViewer1.Name = "hierarchyViewer1";
            this.hierarchyViewer1.Size = new System.Drawing.Size(279, 454);
            this.hierarchyViewer1.TabIndex = 0;
            // 
            // mainControl_TAB
            // 
            this.mainControl_TAB.Controls.Add(this.tabPage1);
            this.mainControl_TAB.Controls.Add(this.tabPage2);
            this.mainControl_TAB.Controls.Add(this.tabPage3);
            this.mainControl_TAB.Controls.Add(this.tabPage4);
            this.mainControl_TAB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainControl_TAB.Location = new System.Drawing.Point(0, 0);
            this.mainControl_TAB.Name = "mainControl_TAB";
            this.mainControl_TAB.SelectedIndex = 0;
            this.mainControl_TAB.Size = new System.Drawing.Size(562, 454);
            this.mainControl_TAB.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.memoryHijacker1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(554, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Memory Hijacker";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // memoryHijacker1
            // 
            this.memoryHijacker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryHijacker1.Location = new System.Drawing.Point(3, 3);
            this.memoryHijacker1.Name = "memoryHijacker1";
            this.memoryHijacker1.Size = new System.Drawing.Size(548, 422);
            this.memoryHijacker1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.shellcodeTAB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(554, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Shellcode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // shellcodeTAB
            // 
            this.shellcodeTAB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shellcodeTAB.Location = new System.Drawing.Point(3, 3);
            this.shellcodeTAB.Name = "shellcodeTAB";
            this.shellcodeTAB.Size = new System.Drawing.Size(548, 422);
            this.shellcodeTAB.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cSharpMethodWriter1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(554, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dynamic C#";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cSharpMethodWriter1
            // 
            this.cSharpMethodWriter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cSharpMethodWriter1.Location = new System.Drawing.Point(0, 0);
            this.cSharpMethodWriter1.Name = "cSharpMethodWriter1";
            this.cSharpMethodWriter1.Size = new System.Drawing.Size(554, 428);
            this.cSharpMethodWriter1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.methodEditor1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(554, 428);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Method Editor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // methodEditor1
            // 
            this.methodEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.methodEditor1.Location = new System.Drawing.Point(0, 0);
            this.methodEditor1.Name = "methodEditor1";
            this.methodEditor1.Size = new System.Drawing.Size(554, 428);
            this.methodEditor1.TabIndex = 0;
            // 
            // addrOfConstructor_TB
            // 
            this.addrOfConstructor_TB.Location = new System.Drawing.Point(467, 23);
            this.addrOfConstructor_TB.Name = "addrOfConstructor_TB";
            this.addrOfConstructor_TB.Size = new System.Drawing.Size(251, 20);
            this.addrOfConstructor_TB.TabIndex = 8;
            this.addrOfConstructor_TB.Text = "Addr of Constructor";
            // 
            // addrCon_L
            // 
            this.addrCon_L.AutoSize = true;
            this.addrCon_L.Location = new System.Drawing.Point(363, 24);
            this.addrCon_L.Name = "addrCon_L";
            this.addrCon_L.Size = new System.Drawing.Size(101, 13);
            this.addrCon_L.TabIndex = 7;
            this.addrCon_L.Text = "Addr of Constructor:";
            // 
            // grayStorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 503);
            this.Controls.Add(this.splitContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "grayStorm";
            this.Text = "Gray Storm";
            this.information_panel.ResumeLayout(false);
            this.information_panel.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.mainControl_TAB.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private hierarchyViewer hierarchyViewer1;
        private System.Windows.Forms.TabControl mainControl_TAB;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private GrayStorm.shellcode shellcodeTAB;
        private System.Windows.Forms.Panel information_panel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label methodSelected_LB;
        private System.Windows.Forms.Label constructor_LB;
        private memoryHijacker memoryHijacker1;
        private System.Windows.Forms.TextBox selectedConstructor_TB;
        private System.Windows.Forms.TextBox selectedMethod_TB;
        private System.Windows.Forms.TabPage tabPage3;
        private cSharpMethodWriter cSharpMethodWriter1;
        private System.Windows.Forms.TabPage tabPage4;
        private GUI.MethodEditor methodEditor1;
        private System.Windows.Forms.Label addrOfMethod_L;
        private System.Windows.Forms.TextBox addrOfMethod_TB;
        private System.Windows.Forms.TextBox addrOfConstructor_TB;
        private System.Windows.Forms.Label addrCon_L;
    }
}

