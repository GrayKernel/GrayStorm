namespace GrayStorm
{
    partial class memoryHijacker
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
            this.components = new System.ComponentModel.Container();
            this.editor_RTB = new System.Windows.Forms.RichTextBox();
            this.assmblyControlFlow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeCallAddressFromCuscomC0xFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCallAddressFromCuscomC0xE8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCallAddressFromCachedMethod0xFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCallAddressFromCachedMethod0xE8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCallAddressFromSelectedMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpAsm_BT = new System.Windows.Forms.Button();
            this.getIL_BT = new System.Windows.Forms.Button();
            this.disassemble_CB = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dynamicMethods_LB = new System.Windows.Forms.ListBox();
            this.dynamicControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fireMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceMethodWithCustomCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getILCustomCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpAssemblyCustomCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assmblyControlFlow.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.dynamicControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // editor_RTB
            // 
            this.editor_RTB.ContextMenuStrip = this.assmblyControlFlow;
            this.editor_RTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor_RTB.Location = new System.Drawing.Point(0, 0);
            this.editor_RTB.Name = "editor_RTB";
            this.editor_RTB.Size = new System.Drawing.Size(356, 391);
            this.editor_RTB.TabIndex = 0;
            this.editor_RTB.Text = "";
            // 
            // assmblyControlFlow
            // 
            this.assmblyControlFlow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeCallAddressFromCuscomC0xFFToolStripMenuItem,
            this.changeCallAddressFromCuscomC0xE8ToolStripMenuItem,
            this.changeCallAddressFromCachedMethod0xFFToolStripMenuItem,
            this.changeCallAddressFromCachedMethod0xE8ToolStripMenuItem,
            this.changeCallAddressFromSelectedMethodToolStripMenuItem});
            this.assmblyControlFlow.Name = "contextMenuStrip2";
            this.assmblyControlFlow.Size = new System.Drawing.Size(339, 114);
            // 
            // changeCallAddressFromCuscomC0xFFToolStripMenuItem
            // 
            this.changeCallAddressFromCuscomC0xFFToolStripMenuItem.Name = "changeCallAddressFromCuscomC0xFFToolStripMenuItem";
            this.changeCallAddressFromCuscomC0xFFToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.changeCallAddressFromCuscomC0xFFToolStripMenuItem.Text = "Change Call Address From Cuscom C# (0xFF)";
            this.changeCallAddressFromCuscomC0xFFToolStripMenuItem.Click += new System.EventHandler(this.changeCallAddressFromCuscomC0xFFToolStripMenuItem_Click);
            // 
            // changeCallAddressFromCuscomC0xE8ToolStripMenuItem
            // 
            this.changeCallAddressFromCuscomC0xE8ToolStripMenuItem.Name = "changeCallAddressFromCuscomC0xE8ToolStripMenuItem";
            this.changeCallAddressFromCuscomC0xE8ToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.changeCallAddressFromCuscomC0xE8ToolStripMenuItem.Text = "Change Call Address From Cuscom C# (0xE8)";
            this.changeCallAddressFromCuscomC0xE8ToolStripMenuItem.Click += new System.EventHandler(this.changeCallAddressFromCuscomC0xE8ToolStripMenuItem_Click);
            // 
            // changeCallAddressFromCachedMethod0xFFToolStripMenuItem
            // 
            this.changeCallAddressFromCachedMethod0xFFToolStripMenuItem.Name = "changeCallAddressFromCachedMethod0xFFToolStripMenuItem";
            this.changeCallAddressFromCachedMethod0xFFToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.changeCallAddressFromCachedMethod0xFFToolStripMenuItem.Text = "Change Call Address from Cached Method (0xFF))";
            this.changeCallAddressFromCachedMethod0xFFToolStripMenuItem.Click += new System.EventHandler(this.changeCallAddressFromCachedMethod0xFFToolStripMenuItem_Click);
            // 
            // changeCallAddressFromCachedMethod0xE8ToolStripMenuItem
            // 
            this.changeCallAddressFromCachedMethod0xE8ToolStripMenuItem.Name = "changeCallAddressFromCachedMethod0xE8ToolStripMenuItem";
            this.changeCallAddressFromCachedMethod0xE8ToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.changeCallAddressFromCachedMethod0xE8ToolStripMenuItem.Text = "Change Call Address from Cached Method (0xE8)";
            this.changeCallAddressFromCachedMethod0xE8ToolStripMenuItem.Click += new System.EventHandler(this.changeCallAddressFromCachedMethod0xE8ToolStripMenuItem_Click);
            // 
            // changeCallAddressFromSelectedMethodToolStripMenuItem
            // 
            this.changeCallAddressFromSelectedMethodToolStripMenuItem.Name = "changeCallAddressFromSelectedMethodToolStripMenuItem";
            this.changeCallAddressFromSelectedMethodToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            // 
            // dumpAsm_BT
            // 
            this.dumpAsm_BT.Location = new System.Drawing.Point(3, 28);
            this.dumpAsm_BT.Name = "dumpAsm_BT";
            this.dumpAsm_BT.Size = new System.Drawing.Size(177, 38);
            this.dumpAsm_BT.TabIndex = 1;
            this.dumpAsm_BT.Text = "Dump Assembly";
            this.dumpAsm_BT.UseVisualStyleBackColor = true;
            this.dumpAsm_BT.Click += new System.EventHandler(this.dumpAsm_BT_Click);
            // 
            // getIL_BT
            // 
            this.getIL_BT.Location = new System.Drawing.Point(3, 95);
            this.getIL_BT.Name = "getIL_BT";
            this.getIL_BT.Size = new System.Drawing.Size(172, 32);
            this.getIL_BT.TabIndex = 2;
            this.getIL_BT.Text = "Get IL Code";
            this.getIL_BT.UseVisualStyleBackColor = true;
            this.getIL_BT.Click += new System.EventHandler(this.getIL_BT_Click);
            // 
            // disassemble_CB
            // 
            this.disassemble_CB.AutoSize = true;
            this.disassemble_CB.Location = new System.Drawing.Point(3, 72);
            this.disassemble_CB.Name = "disassemble_CB";
            this.disassemble_CB.Size = new System.Drawing.Size(83, 17);
            this.disassemble_CB.TabIndex = 3;
            this.disassemble_CB.Text = "disassemble";
            this.disassemble_CB.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dynamicMethods_LB);
            this.splitContainer1.Panel1.Controls.Add(this.getIL_BT);
            this.splitContainer1.Panel1.Controls.Add(this.disassemble_CB);
            this.splitContainer1.Panel1.Controls.Add(this.dumpAsm_BT);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.editor_RTB);
            this.splitContainer1.Size = new System.Drawing.Size(540, 391);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 5;
            // 
            // dynamicMethods_LB
            // 
            this.dynamicMethods_LB.ContextMenuStrip = this.dynamicControl;
            this.dynamicMethods_LB.FormattingEnabled = true;
            this.dynamicMethods_LB.Location = new System.Drawing.Point(3, 230);
            this.dynamicMethods_LB.Name = "dynamicMethods_LB";
            this.dynamicMethods_LB.Size = new System.Drawing.Size(172, 147);
            this.dynamicMethods_LB.TabIndex = 5;
            // 
            // dynamicControl
            // 
            this.dynamicControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fireMethodToolStripMenuItem,
            this.replaceMethodWithCustomCToolStripMenuItem,
            this.getILCustomCToolStripMenuItem,
            this.dumpAssemblyCustomCToolStripMenuItem});
            this.dynamicControl.Name = "contextMenuStrip1";
            this.dynamicControl.Size = new System.Drawing.Size(250, 92);
            // 
            // fireMethodToolStripMenuItem
            // 
            this.fireMethodToolStripMenuItem.Name = "fireMethodToolStripMenuItem";
            this.fireMethodToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.fireMethodToolStripMenuItem.Text = "Fire Method";
            this.fireMethodToolStripMenuItem.Click += new System.EventHandler(this.fireMethodToolStripMenuItem_Click);
            // 
            // replaceMethodWithCustomCToolStripMenuItem
            // 
            this.replaceMethodWithCustomCToolStripMenuItem.Name = "replaceMethodWithCustomCToolStripMenuItem";
            this.replaceMethodWithCustomCToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.replaceMethodWithCustomCToolStripMenuItem.Text = "Replace Method with Custom C#";
            // 
            // getILCustomCToolStripMenuItem
            // 
            this.getILCustomCToolStripMenuItem.Name = "getILCustomCToolStripMenuItem";
            this.getILCustomCToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.getILCustomCToolStripMenuItem.Text = "Get IL Custom C#";
            this.getILCustomCToolStripMenuItem.Click += new System.EventHandler(this.getILCustomCToolStripMenuItem_Click);
            // 
            // dumpAssemblyCustomCToolStripMenuItem
            // 
            this.dumpAssemblyCustomCToolStripMenuItem.Name = "dumpAssemblyCustomCToolStripMenuItem";
            this.dumpAssemblyCustomCToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.dumpAssemblyCustomCToolStripMenuItem.Text = "Dump Assembly Custom C#";
            this.dumpAssemblyCustomCToolStripMenuItem.Click += new System.EventHandler(this.dumpAssemblyCustomCToolStripMenuItem_Click);
            // 
            // memoryHijacker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "memoryHijacker";
            this.Size = new System.Drawing.Size(540, 391);
            this.assmblyControlFlow.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.dynamicControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox editor_RTB;
        private System.Windows.Forms.Button dumpAsm_BT;
        private System.Windows.Forms.Button getIL_BT;
        public System.Windows.Forms.CheckBox disassemble_CB;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.ListBox dynamicMethods_LB;
        private System.Windows.Forms.ContextMenuStrip dynamicControl;
        private System.Windows.Forms.ToolStripMenuItem fireMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceMethodWithCustomCToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip assmblyControlFlow;
        private System.Windows.Forms.ToolStripMenuItem changeCallAddressFromCuscomC0xFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCallAddressFromCuscomC0xE8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCallAddressFromCachedMethod0xFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCallAddressFromCachedMethod0xE8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCallAddressFromSelectedMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getILCustomCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumpAssemblyCustomCToolStripMenuItem;
    }
}
