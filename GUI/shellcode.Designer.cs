namespace GrayStorm
{
    partial class shellcode
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.payloads_LB = new System.Windows.Forms.ListBox();
            this.payload_L = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metaSploit_LB = new System.Windows.Forms.ListBox();
            this.hookMethod_CB = new System.Windows.Forms.CheckBox();
            this.metaSploit_L = new System.Windows.Forms.Label();
            this.fireShellcode_BT = new System.Windows.Forms.Button();
            this.restoreCode_BT = new System.Windows.Forms.Button();
            this.shellcodeEditor_TAB = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.shellcode_RTB = new System.Windows.Forms.RichTextBox();
            this.disassemble_CB = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.createShellcode_RTB = new System.Windows.Forms.RichTextBox();
            this.hookOffset_TB = new System.Windows.Forms.TextBox();
            this.payloadName_TB = new System.Windows.Forms.TextBox();
            this.createShellcode_BT = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.shellcodeEditor_TAB.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.shellcodeEditor_TAB);
            this.splitContainer1.Size = new System.Drawing.Size(654, 401);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            this.splitContainer2.Panel1MinSize = 125;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Size = new System.Drawing.Size(216, 401);
            this.splitContainer2.SplitterDistance = 125;
            this.splitContainer2.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.payloads_LB);
            this.panel2.Controls.Add(this.payload_L);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 125);
            this.panel2.TabIndex = 2;
            // 
            // payloads_LB
            // 
            this.payloads_LB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payloads_LB.FormattingEnabled = true;
            this.payloads_LB.Location = new System.Drawing.Point(0, 13);
            this.payloads_LB.Name = "payloads_LB";
            this.payloads_LB.Size = new System.Drawing.Size(216, 95);
            this.payloads_LB.TabIndex = 1;
            this.payloads_LB.SelectedIndexChanged += new System.EventHandler(this.payloads_LB_SelectedIndexChanged);
            // 
            // payload_L
            // 
            this.payload_L.AutoSize = true;
            this.payload_L.Dock = System.Windows.Forms.DockStyle.Top;
            this.payload_L.Location = new System.Drawing.Point(0, 0);
            this.payload_L.Name = "payload_L";
            this.payload_L.Size = new System.Drawing.Size(50, 13);
            this.payload_L.TabIndex = 0;
            this.payload_L.Text = "Payloads";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metaSploit_LB);
            this.panel1.Controls.Add(this.hookMethod_CB);
            this.panel1.Controls.Add(this.metaSploit_L);
            this.panel1.Controls.Add(this.fireShellcode_BT);
            this.panel1.Controls.Add(this.restoreCode_BT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 272);
            this.panel1.TabIndex = 7;
            // 
            // metaSploit_LB
            // 
            this.metaSploit_LB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metaSploit_LB.FormattingEnabled = true;
            this.metaSploit_LB.Location = new System.Drawing.Point(1, 16);
            this.metaSploit_LB.Name = "metaSploit_LB";
            this.metaSploit_LB.Size = new System.Drawing.Size(212, 95);
            this.metaSploit_LB.TabIndex = 2;
            this.metaSploit_LB.SelectedIndexChanged += new System.EventHandler(this.metaSploit_LB_SelectedIndexChanged);
            // 
            // hookMethod_CB
            // 
            this.hookMethod_CB.AutoSize = true;
            this.hookMethod_CB.Location = new System.Drawing.Point(3, 194);
            this.hookMethod_CB.Name = "hookMethod_CB";
            this.hookMethod_CB.Size = new System.Drawing.Size(91, 17);
            this.hookMethod_CB.TabIndex = 6;
            this.hookMethod_CB.Text = "Hook Method";
            this.hookMethod_CB.UseVisualStyleBackColor = true;
            // 
            // metaSploit_L
            // 
            this.metaSploit_L.AutoSize = true;
            this.metaSploit_L.Location = new System.Drawing.Point(3, 0);
            this.metaSploit_L.Name = "metaSploit_L";
            this.metaSploit_L.Size = new System.Drawing.Size(57, 13);
            this.metaSploit_L.TabIndex = 3;
            this.metaSploit_L.Text = "MetaSploit";
            // 
            // fireShellcode_BT
            // 
            this.fireShellcode_BT.Location = new System.Drawing.Point(3, 217);
            this.fireShellcode_BT.Name = "fireShellcode_BT";
            this.fireShellcode_BT.Size = new System.Drawing.Size(210, 23);
            this.fireShellcode_BT.TabIndex = 4;
            this.fireShellcode_BT.Text = "Fire Shellcode";
            this.fireShellcode_BT.UseVisualStyleBackColor = true;
            this.fireShellcode_BT.Click += new System.EventHandler(this.fireShellcode_BT_Click);
            // 
            // restoreCode_BT
            // 
            this.restoreCode_BT.Location = new System.Drawing.Point(3, 246);
            this.restoreCode_BT.Name = "restoreCode_BT";
            this.restoreCode_BT.Size = new System.Drawing.Size(213, 27);
            this.restoreCode_BT.TabIndex = 5;
            this.restoreCode_BT.Text = "Restore Code";
            this.restoreCode_BT.UseVisualStyleBackColor = true;
            this.restoreCode_BT.Click += new System.EventHandler(this.restoreCode_BT_Click);
            // 
            // shellcodeEditor_TAB
            // 
            this.shellcodeEditor_TAB.Controls.Add(this.tabPage1);
            this.shellcodeEditor_TAB.Controls.Add(this.tabPage2);
            this.shellcodeEditor_TAB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shellcodeEditor_TAB.Location = new System.Drawing.Point(0, 0);
            this.shellcodeEditor_TAB.Name = "shellcodeEditor_TAB";
            this.shellcodeEditor_TAB.SelectedIndex = 0;
            this.shellcodeEditor_TAB.Size = new System.Drawing.Size(434, 401);
            this.shellcodeEditor_TAB.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Shellcode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.shellcode_RTB);
            this.panel3.Controls.Add(this.disassemble_CB);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 369);
            this.panel3.TabIndex = 8;
            // 
            // shellcode_RTB
            // 
            this.shellcode_RTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shellcode_RTB.Location = new System.Drawing.Point(0, 0);
            this.shellcode_RTB.Name = "shellcode_RTB";
            this.shellcode_RTB.Size = new System.Drawing.Size(420, 352);
            this.shellcode_RTB.TabIndex = 0;
            this.shellcode_RTB.Text = "";
            // 
            // disassemble_CB
            // 
            this.disassemble_CB.AutoSize = true;
            this.disassemble_CB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.disassemble_CB.Location = new System.Drawing.Point(0, 352);
            this.disassemble_CB.Name = "disassemble_CB";
            this.disassemble_CB.Size = new System.Drawing.Size(420, 17);
            this.disassemble_CB.TabIndex = 7;
            this.disassemble_CB.Text = "disassemble";
            this.disassemble_CB.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Shellcode Editor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.splitContainer3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 369);
            this.panel4.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.createShellcode_RTB);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.hookOffset_TB);
            this.splitContainer3.Panel2.Controls.Add(this.payloadName_TB);
            this.splitContainer3.Panel2.Controls.Add(this.createShellcode_BT);
            this.splitContainer3.Size = new System.Drawing.Size(420, 369);
            this.splitContainer3.SplitterDistance = 280;
            this.splitContainer3.TabIndex = 2;
            // 
            // createShellcode_RTB
            // 
            this.createShellcode_RTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createShellcode_RTB.Location = new System.Drawing.Point(0, 0);
            this.createShellcode_RTB.Name = "createShellcode_RTB";
            this.createShellcode_RTB.Size = new System.Drawing.Size(420, 280);
            this.createShellcode_RTB.TabIndex = 0;
            this.createShellcode_RTB.Text = "";
            // 
            // hookOffset_TB
            // 
            this.hookOffset_TB.Location = new System.Drawing.Point(237, 52);
            this.hookOffset_TB.Name = "hookOffset_TB";
            this.hookOffset_TB.Size = new System.Drawing.Size(140, 20);
            this.hookOffset_TB.TabIndex = 3;
            this.hookOffset_TB.Text = "Offset of hook (0 if none) ";
            // 
            // payloadName_TB
            // 
            this.payloadName_TB.Location = new System.Drawing.Point(4, 53);
            this.payloadName_TB.Name = "payloadName_TB";
            this.payloadName_TB.Size = new System.Drawing.Size(140, 20);
            this.payloadName_TB.TabIndex = 2;
            this.payloadName_TB.Text = "Name of payload";
            // 
            // createShellcode_BT
            // 
            this.createShellcode_BT.Dock = System.Windows.Forms.DockStyle.Top;
            this.createShellcode_BT.Location = new System.Drawing.Point(0, 0);
            this.createShellcode_BT.Name = "createShellcode_BT";
            this.createShellcode_BT.Size = new System.Drawing.Size(420, 46);
            this.createShellcode_BT.TabIndex = 1;
            this.createShellcode_BT.Text = "Create Shellcode";
            this.createShellcode_BT.UseVisualStyleBackColor = true;
            this.createShellcode_BT.Click += new System.EventHandler(this.createShellcode_BT_Click);
            // 
            // shellcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "shellcode";
            this.Size = new System.Drawing.Size(654, 401);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.shellcodeEditor_TAB.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl shellcodeEditor_TAB;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label metaSploit_L;
        private System.Windows.Forms.ListBox metaSploit_LB;
        private System.Windows.Forms.ListBox payloads_LB;
        private System.Windows.Forms.Label payload_L;
        private System.Windows.Forms.CheckBox hookMethod_CB;
        private System.Windows.Forms.Button restoreCode_BT;
        private System.Windows.Forms.Button fireShellcode_BT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox shellcode_RTB;
        private System.Windows.Forms.CheckBox disassemble_CB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.RichTextBox createShellcode_RTB;
        private System.Windows.Forms.TextBox hookOffset_TB;
        private System.Windows.Forms.TextBox payloadName_TB;
        private System.Windows.Forms.Button createShellcode_BT;
    }
}
