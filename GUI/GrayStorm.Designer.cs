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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mainControl_TAB = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.information_panel = new System.Windows.Forms.Panel();
            this.methodLabel_LB = new System.Windows.Forms.Label();
            this.methodSelected_LB = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.constructor_LB = new System.Windows.Forms.Label();
            this.constructorLabel_LB = new System.Windows.Forms.Label();
            this.hierarchyViewer1 = new GrayStorm.hierarchyViewer();
            this.memoryHijacker1 = new GrayStorm.GUI.memoryHijacker();
            this.shellcodeTAB = new GrayStorm.shellcode();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.mainControl_TAB.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.information_panel.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(845, 462);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 0;
            // 
            // mainControl_TAB
            // 
            this.mainControl_TAB.Controls.Add(this.tabPage1);
            this.mainControl_TAB.Controls.Add(this.tabPage2);
            this.mainControl_TAB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainControl_TAB.Location = new System.Drawing.Point(0, 0);
            this.mainControl_TAB.Name = "mainControl_TAB";
            this.mainControl_TAB.SelectedIndex = 0;
            this.mainControl_TAB.Size = new System.Drawing.Size(562, 462);
            this.mainControl_TAB.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.memoryHijacker1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(554, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.shellcodeTAB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(554, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // information_panel
            // 
            this.information_panel.Controls.Add(this.constructorLabel_LB);
            this.information_panel.Controls.Add(this.constructor_LB);
            this.information_panel.Controls.Add(this.methodLabel_LB);
            this.information_panel.Controls.Add(this.methodSelected_LB);
            this.information_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.information_panel.Location = new System.Drawing.Point(0, 0);
            this.information_panel.Name = "information_panel";
            this.information_panel.Size = new System.Drawing.Size(845, 37);
            this.information_panel.TabIndex = 1;
            // 
            // methodLabel_LB
            // 
            this.methodLabel_LB.AutoSize = true;
            this.methodLabel_LB.Location = new System.Drawing.Point(89, 4);
            this.methodLabel_LB.Name = "methodLabel_LB";
            this.methodLabel_LB.Size = new System.Drawing.Size(19, 13);
            this.methodLabel_LB.TabIndex = 1;
            this.methodLabel_LB.Text = "<>";
            // 
            // methodSelected_LB
            // 
            this.methodSelected_LB.AutoSize = true;
            this.methodSelected_LB.Location = new System.Drawing.Point(0, 4);
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
            this.splitContainer2.SplitterDistance = 37;
            this.splitContainer2.TabIndex = 1;
            // 
            // constructor_LB
            // 
            this.constructor_LB.AutoSize = true;
            this.constructor_LB.Location = new System.Drawing.Point(393, 4);
            this.constructor_LB.Name = "constructor_LB";
            this.constructor_LB.Size = new System.Drawing.Size(112, 13);
            this.constructor_LB.TabIndex = 2;
            this.constructor_LB.Text = "Constructor Selected: ";
            // 
            // constructorLabel_LB
            // 
            this.constructorLabel_LB.AutoSize = true;
            this.constructorLabel_LB.Location = new System.Drawing.Point(511, 4);
            this.constructorLabel_LB.Name = "constructorLabel_LB";
            this.constructorLabel_LB.Size = new System.Drawing.Size(19, 13);
            this.constructorLabel_LB.TabIndex = 3;
            this.constructorLabel_LB.Text = "<>";
            // 
            // hierarchyViewer1
            // 
            this.hierarchyViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hierarchyViewer1.Location = new System.Drawing.Point(0, 0);
            this.hierarchyViewer1.Name = "hierarchyViewer1";
            this.hierarchyViewer1.Size = new System.Drawing.Size(279, 462);
            this.hierarchyViewer1.TabIndex = 0;
            // 
            // memoryHijacker1
            // 
            this.memoryHijacker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryHijacker1.Location = new System.Drawing.Point(3, 3);
            this.memoryHijacker1.Name = "memoryHijacker1";
            this.memoryHijacker1.Size = new System.Drawing.Size(548, 430);
            this.memoryHijacker1.TabIndex = 0;
            // 
            // shellcodeTAB
            // 
            this.shellcodeTAB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shellcodeTAB.Location = new System.Drawing.Point(3, 3);
            this.shellcodeTAB.Name = "shellcodeTAB";
            this.shellcodeTAB.Size = new System.Drawing.Size(548, 430);
            this.shellcodeTAB.TabIndex = 0;
            // 
            // grayStorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 503);
            this.Controls.Add(this.splitContainer2);
            this.Name = "grayStorm";
            this.Text = "Gray Storm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.mainControl_TAB.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.information_panel.ResumeLayout(false);
            this.information_panel.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
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
        private System.Windows.Forms.Label methodLabel_LB;
        private System.Windows.Forms.Label methodSelected_LB;
        private System.Windows.Forms.Label constructorLabel_LB;
        private System.Windows.Forms.Label constructor_LB;
        private GUI.memoryHijacker memoryHijacker1;
    }
}

