namespace GrayStorm.GUI
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
            this.editor_RTB = new System.Windows.Forms.RichTextBox();
            this.dumpAsm_BT = new System.Windows.Forms.Button();
            this.getIL_BT = new System.Windows.Forms.Button();
            this.disassemble_CB = new System.Windows.Forms.CheckBox();
            this.realAddress_LB = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editor_RTB
            // 
            this.editor_RTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor_RTB.Location = new System.Drawing.Point(0, 0);
            this.editor_RTB.Name = "editor_RTB";
            this.editor_RTB.Size = new System.Drawing.Size(356, 391);
            this.editor_RTB.TabIndex = 0;
            this.editor_RTB.Text = "";
            // 
            // dumpAsm_BT
            // 
            this.dumpAsm_BT.Location = new System.Drawing.Point(0, 28);
            this.dumpAsm_BT.Name = "dumpAsm_BT";
            this.dumpAsm_BT.Size = new System.Drawing.Size(180, 38);
            this.dumpAsm_BT.TabIndex = 1;
            this.dumpAsm_BT.Text = "Dump Assembly";
            this.dumpAsm_BT.UseVisualStyleBackColor = true;
            this.dumpAsm_BT.Click += new System.EventHandler(this.dumpAsm_BT_Click);
            // 
            // getIL_BT
            // 
            this.getIL_BT.Location = new System.Drawing.Point(-3, 95);
            this.getIL_BT.Name = "getIL_BT";
            this.getIL_BT.Size = new System.Drawing.Size(178, 32);
            this.getIL_BT.TabIndex = 2;
            this.getIL_BT.Text = "Get IL Code";
            this.getIL_BT.UseVisualStyleBackColor = true;
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
            // realAddress_LB
            // 
            this.realAddress_LB.FormattingEnabled = true;
            this.realAddress_LB.Location = new System.Drawing.Point(3, 188);
            this.realAddress_LB.Name = "realAddress_LB";
            this.realAddress_LB.Size = new System.Drawing.Size(167, 17);
            this.realAddress_LB.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.realAddress_LB);
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
            // memoryHijacker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "memoryHijacker";
            this.Size = new System.Drawing.Size(540, 391);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox editor_RTB;
        private System.Windows.Forms.Button dumpAsm_BT;
        private System.Windows.Forms.Button getIL_BT;
        private System.Windows.Forms.CheckBox disassemble_CB;
        private System.Windows.Forms.ListBox realAddress_LB;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
