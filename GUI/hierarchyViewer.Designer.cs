namespace GrayStorm
{
    partial class hierarchyViewer
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
            this.hierarchyViewer_TN = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dumpAssemblyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disassembleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reDumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withINT3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showILCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceMethodWithCustomCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacheReplacerMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDomain_BT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hierarchyViewer_TN
            // 
            this.hierarchyViewer_TN.ContextMenuStrip = this.contextMenuStrip1;
            this.hierarchyViewer_TN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hierarchyViewer_TN.Location = new System.Drawing.Point(0, 25);
            this.hierarchyViewer_TN.Name = "hierarchyViewer_TN";
            this.hierarchyViewer_TN.Size = new System.Drawing.Size(291, 204);
            this.hierarchyViewer_TN.TabIndex = 0;
            this.hierarchyViewer_TN.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.hierarchyViewer_TN_AfterSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dumpAssemblyToolStripMenuItem,
            this.fireMethodToolStripMenuItem,
            this.restoreMethodToolStripMenuItem,
            this.showILCodeToolStripMenuItem,
            this.replaceMethodWithCustomCToolStripMenuItem,
            this.cacheReplacerMethodToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(252, 136);
            // 
            // dumpAssemblyToolStripMenuItem
            // 
            this.dumpAssemblyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dumpToolStripMenuItem,
            this.disassembleToolStripMenuItem,
            this.reDumpToolStripMenuItem});
            this.dumpAssemblyToolStripMenuItem.Name = "dumpAssemblyToolStripMenuItem";
            this.dumpAssemblyToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.dumpAssemblyToolStripMenuItem.Text = "Dump Assembly";
            // 
            // dumpToolStripMenuItem
            // 
            this.dumpToolStripMenuItem.Name = "dumpToolStripMenuItem";
            this.dumpToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.dumpToolStripMenuItem.Text = "Dump";
            this.dumpToolStripMenuItem.Click += new System.EventHandler(this.dumpToolStripMenuItem_Click);
            // 
            // disassembleToolStripMenuItem
            // 
            this.disassembleToolStripMenuItem.Name = "disassembleToolStripMenuItem";
            this.disassembleToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.disassembleToolStripMenuItem.Text = "Disassemble";
            this.disassembleToolStripMenuItem.Click += new System.EventHandler(this.disassembleToolStripMenuItem_Click);
            // 
            // reDumpToolStripMenuItem
            // 
            this.reDumpToolStripMenuItem.Name = "reDumpToolStripMenuItem";
            this.reDumpToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.reDumpToolStripMenuItem.Text = "ReDump";
            this.reDumpToolStripMenuItem.Click += new System.EventHandler(this.reDumpToolStripMenuItem_Click);
            // 
            // fireMethodToolStripMenuItem
            // 
            this.fireMethodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.withINT3ToolStripMenuItem});
            this.fireMethodToolStripMenuItem.Name = "fireMethodToolStripMenuItem";
            this.fireMethodToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.fireMethodToolStripMenuItem.Text = "Fire Method";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // withINT3ToolStripMenuItem
            // 
            this.withINT3ToolStripMenuItem.Name = "withINT3ToolStripMenuItem";
            this.withINT3ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.withINT3ToolStripMenuItem.Text = "With INT 3";
            this.withINT3ToolStripMenuItem.Click += new System.EventHandler(this.withINT3ToolStripMenuItem_Click);
            // 
            // restoreMethodToolStripMenuItem
            // 
            this.restoreMethodToolStripMenuItem.Name = "restoreMethodToolStripMenuItem";
            this.restoreMethodToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.restoreMethodToolStripMenuItem.Text = "Restore Method";
            this.restoreMethodToolStripMenuItem.Click += new System.EventHandler(this.restoreMethodToolStripMenuItem_Click);
            // 
            // showILCodeToolStripMenuItem
            // 
            this.showILCodeToolStripMenuItem.Name = "showILCodeToolStripMenuItem";
            this.showILCodeToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.showILCodeToolStripMenuItem.Text = "Show IL Code";
            this.showILCodeToolStripMenuItem.Click += new System.EventHandler(this.showILCodeToolStripMenuItem_Click);
            // 
            // replaceMethodWithCustomCToolStripMenuItem
            // 
            this.replaceMethodWithCustomCToolStripMenuItem.Name = "replaceMethodWithCustomCToolStripMenuItem";
            this.replaceMethodWithCustomCToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.replaceMethodWithCustomCToolStripMenuItem.Text = "Replace Method With Custom C#";
            this.replaceMethodWithCustomCToolStripMenuItem.Click += new System.EventHandler(this.replaceMethodWithCustomCToolStripMenuItem_Click);
            // 
            // cacheReplacerMethodToolStripMenuItem
            // 
            this.cacheReplacerMethodToolStripMenuItem.Name = "cacheReplacerMethodToolStripMenuItem";
            this.cacheReplacerMethodToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.cacheReplacerMethodToolStripMenuItem.Text = "Cache Replacer Method";
            this.cacheReplacerMethodToolStripMenuItem.Click += new System.EventHandler(this.cacheReplacerMethodToolStripMenuItem_Click);
            // 
            // refreshDomain_BT
            // 
            this.refreshDomain_BT.Dock = System.Windows.Forms.DockStyle.Top;
            this.refreshDomain_BT.Location = new System.Drawing.Point(0, 0);
            this.refreshDomain_BT.Name = "refreshDomain_BT";
            this.refreshDomain_BT.Size = new System.Drawing.Size(291, 25);
            this.refreshDomain_BT.TabIndex = 0;
            this.refreshDomain_BT.Text = "Refresh Domain";
            this.refreshDomain_BT.UseVisualStyleBackColor = true;
            this.refreshDomain_BT.Click += new System.EventHandler(this.refreshDomain_BT_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hierarchyViewer_TN);
            this.panel1.Controls.Add(this.refreshDomain_BT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 229);
            this.panel1.TabIndex = 1;
            // 
            // hierarchyViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "hierarchyViewer";
            this.Size = new System.Drawing.Size(291, 229);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView hierarchyViewer_TN;
        private System.Windows.Forms.Button refreshDomain_BT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dumpAssemblyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disassembleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withINT3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reDumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showILCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceMethodWithCustomCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cacheReplacerMethodToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}
