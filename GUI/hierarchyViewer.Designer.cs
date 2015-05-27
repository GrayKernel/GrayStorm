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
            this.hierarchyViewer_TN = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.refreshDomain_BT = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hierarchyViewer_TN
            // 
            this.hierarchyViewer_TN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hierarchyViewer_TN.Location = new System.Drawing.Point(0, 0);
            this.hierarchyViewer_TN.Name = "hierarchyViewer_TN";
            this.hierarchyViewer_TN.Size = new System.Drawing.Size(291, 200);
            this.hierarchyViewer_TN.TabIndex = 0;
            this.hierarchyViewer_TN.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.hierarchyViewer_TN_AfterSelect);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.refreshDomain_BT);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.hierarchyViewer_TN);
            this.splitContainer1.Size = new System.Drawing.Size(291, 229);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 1;
            // 
            // refreshDomain_BT
            // 
            this.refreshDomain_BT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshDomain_BT.Location = new System.Drawing.Point(0, 0);
            this.refreshDomain_BT.Name = "refreshDomain_BT";
            this.refreshDomain_BT.Size = new System.Drawing.Size(291, 25);
            this.refreshDomain_BT.TabIndex = 0;
            this.refreshDomain_BT.Text = "Refresh Domain";
            this.refreshDomain_BT.UseVisualStyleBackColor = true;
            this.refreshDomain_BT.Click += new System.EventHandler(this.refreshDomain_BT_Click);
            // 
            // hierarchyViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "hierarchyViewer";
            this.Size = new System.Drawing.Size(291, 229);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView hierarchyViewer_TN;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button refreshDomain_BT;
    }
}
