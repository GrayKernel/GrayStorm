namespace GrayStorm.GUI
{
    partial class MethodEditor
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
            this.intPtrs = new System.Windows.Forms.ListBox();
            this.argumentsLabel = new System.Windows.Forms.Label();
            this.setConstant_Butt = new System.Windows.Forms.Button();
            this.callMethod = new System.Windows.Forms.Button();
            this.setConstant = new System.Windows.Forms.TextBox();
            this.addArgumentButton = new System.Windows.Forms.Button();
            this.getAllObjects = new System.Windows.Forms.Button();
            this.addArgsTextBox = new System.Windows.Forms.TextBox();
            this.callInstanceMethodButt = new System.Windows.Forms.Button();
            this.testToObjects = new System.Windows.Forms.Button();
            this.enteredArgsLabel = new System.Windows.Forms.Label();
            this.callConstructorButt = new System.Windows.Forms.Button();
            this.clearArgsButt = new System.Windows.Forms.Button();
            this.cb_fireAllObjects = new System.Windows.Forms.CheckBox();
            this.addObjectButton = new System.Windows.Forms.Button();
            this.objTreeView = new System.Windows.Forms.TreeView();
            this.objectsListBox = new System.Windows.Forms.ListBox();
            this.objectsLabel = new System.Windows.Forms.Label();
            this.instanceMethodLabel = new System.Windows.Forms.Label();
            this.instanceMethodListBox = new System.Windows.Forms.ListBox();
            this.fieldsLabel = new System.Windows.Forms.Label();
            this.fieldsListBox = new System.Windows.Forms.ListBox();
            this.propertiesListBox = new System.Windows.Forms.ListBox();
            this.methodListBox = new System.Windows.Forms.ListBox();
            this.methodListBoxLabel = new System.Windows.Forms.Label();
            this.fieldValueLabel = new System.Windows.Forms.Label();
            this.setValueLabel = new System.Windows.Forms.Label();
            this.fieldValueTextBox = new System.Windows.Forms.TextBox();
            this.fieldValuePlacerholder = new System.Windows.Forms.Label();
            this.changeFieldValueButt = new System.Windows.Forms.Button();
            this.propertyValuePlaceholder = new System.Windows.Forms.Label();
            this.propertyValueLabel = new System.Windows.Forms.Label();
            this.propertiesSetValueLabel = new System.Windows.Forms.Label();
            this.propertyValueTextBox = new System.Windows.Forms.TextBox();
            this.changePropertyValueButt = new System.Windows.Forms.Button();
            this.removeObjectButt = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // intPtrs
            // 
            this.intPtrs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.intPtrs.FormattingEnabled = true;
            this.intPtrs.Location = new System.Drawing.Point(0, 680);
            this.intPtrs.Name = "intPtrs";
            this.intPtrs.Size = new System.Drawing.Size(174, 95);
            this.intPtrs.TabIndex = 88;
            // 
            // argumentsLabel
            // 
            this.argumentsLabel.AutoSize = true;
            this.argumentsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.argumentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.argumentsLabel.Location = new System.Drawing.Point(3, 0);
            this.argumentsLabel.Name = "argumentsLabel";
            this.argumentsLabel.Size = new System.Drawing.Size(314, 52);
            this.argumentsLabel.TabIndex = 79;
            this.argumentsLabel.Text = "Args to Enter";
            // 
            // setConstant_Butt
            // 
            this.setConstant_Butt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.setConstant_Butt.Location = new System.Drawing.Point(0, 316);
            this.setConstant_Butt.Name = "setConstant_Butt";
            this.setConstant_Butt.Size = new System.Drawing.Size(261, 23);
            this.setConstant_Butt.TabIndex = 85;
            this.setConstant_Butt.Text = "Set Constant";
            this.setConstant_Butt.UseVisualStyleBackColor = true;
            // 
            // callMethod
            // 
            this.callMethod.BackColor = System.Drawing.SystemColors.Control;
            this.callMethod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.callMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callMethod.Location = new System.Drawing.Point(0, 349);
            this.callMethod.Name = "callMethod";
            this.callMethod.Size = new System.Drawing.Size(261, 32);
            this.callMethod.TabIndex = 74;
            this.callMethod.Text = "Call Method";
            this.callMethod.UseVisualStyleBackColor = false;
            this.callMethod.Click += new System.EventHandler(this.callMethod_Click);
            // 
            // setConstant
            // 
            this.setConstant.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.setConstant.Location = new System.Drawing.Point(0, 362);
            this.setConstant.Name = "setConstant";
            this.setConstant.Size = new System.Drawing.Size(261, 20);
            this.setConstant.TabIndex = 84;
            // 
            // addArgumentButton
            // 
            this.addArgumentButton.BackColor = System.Drawing.Color.White;
            this.addArgumentButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addArgumentButton.Location = new System.Drawing.Point(3, 159);
            this.addArgumentButton.Name = "addArgumentButton";
            this.addArgumentButton.Size = new System.Drawing.Size(255, 46);
            this.addArgumentButton.TabIndex = 75;
            this.addArgumentButton.Text = "Add";
            this.addArgumentButton.UseVisualStyleBackColor = false;
            this.addArgumentButton.Click += new System.EventHandler(this.addArgumentButton_Click);
            // 
            // getAllObjects
            // 
            this.getAllObjects.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.getAllObjects.Location = new System.Drawing.Point(0, 311);
            this.getAllObjects.Name = "getAllObjects";
            this.getAllObjects.Size = new System.Drawing.Size(229, 38);
            this.getAllObjects.TabIndex = 83;
            this.getAllObjects.Text = "Get All Objects";
            this.getAllObjects.UseVisualStyleBackColor = true;
            this.getAllObjects.Click += new System.EventHandler(this.getAllObjects_Click);
            // 
            // addArgsTextBox
            // 
            this.addArgsTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addArgsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addArgsTextBox.Location = new System.Drawing.Point(3, 107);
            this.addArgsTextBox.Multiline = true;
            this.addArgsTextBox.Name = "addArgsTextBox";
            this.addArgsTextBox.Size = new System.Drawing.Size(314, 46);
            this.addArgsTextBox.TabIndex = 76;
            // 
            // callInstanceMethodButt
            // 
            this.callInstanceMethodButt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.callInstanceMethodButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callInstanceMethodButt.Location = new System.Drawing.Point(0, 331);
            this.callInstanceMethodButt.Name = "callInstanceMethodButt";
            this.callInstanceMethodButt.Size = new System.Drawing.Size(229, 51);
            this.callInstanceMethodButt.TabIndex = 82;
            this.callInstanceMethodButt.Text = "Call Instance Method";
            this.callInstanceMethodButt.UseVisualStyleBackColor = true;
            this.callInstanceMethodButt.Click += new System.EventHandler(this.callInstanceMethodButt_Click);
            // 
            // testToObjects
            // 
            this.testToObjects.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.testToObjects.Location = new System.Drawing.Point(0, 339);
            this.testToObjects.Name = "testToObjects";
            this.testToObjects.Size = new System.Drawing.Size(261, 23);
            this.testToObjects.TabIndex = 87;
            this.testToObjects.Text = "testToObjects";
            this.testToObjects.UseVisualStyleBackColor = true;
            // 
            // enteredArgsLabel
            // 
            this.enteredArgsLabel.AutoSize = true;
            this.enteredArgsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enteredArgsLabel.Location = new System.Drawing.Point(3, 52);
            this.enteredArgsLabel.Name = "enteredArgsLabel";
            this.enteredArgsLabel.Size = new System.Drawing.Size(314, 52);
            this.enteredArgsLabel.TabIndex = 81;
            this.enteredArgsLabel.Text = "Entered Args = none";
            // 
            // callConstructorButt
            // 
            this.callConstructorButt.BackColor = System.Drawing.Color.White;
            this.callConstructorButt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.callConstructorButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callConstructorButt.Location = new System.Drawing.Point(0, 279);
            this.callConstructorButt.Name = "callConstructorButt";
            this.callConstructorButt.Size = new System.Drawing.Size(229, 32);
            this.callConstructorButt.TabIndex = 77;
            this.callConstructorButt.Text = "Call Constructor";
            this.callConstructorButt.UseVisualStyleBackColor = false;
            this.callConstructorButt.Click += new System.EventHandler(this.callConstructorButt_Click);
            // 
            // clearArgsButt
            // 
            this.clearArgsButt.Dock = System.Windows.Forms.DockStyle.Left;
            this.clearArgsButt.Location = new System.Drawing.Point(3, 263);
            this.clearArgsButt.Name = "clearArgsButt";
            this.clearArgsButt.Size = new System.Drawing.Size(261, 50);
            this.clearArgsButt.TabIndex = 80;
            this.clearArgsButt.Text = "Clear Arguments";
            this.clearArgsButt.UseVisualStyleBackColor = true;
            this.clearArgsButt.Click += new System.EventHandler(this.clearArgsButt_Click);
            // 
            // cb_fireAllObjects
            // 
            this.cb_fireAllObjects.AutoSize = true;
            this.cb_fireAllObjects.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cb_fireAllObjects.Location = new System.Drawing.Point(0, 314);
            this.cb_fireAllObjects.Name = "cb_fireAllObjects";
            this.cb_fireAllObjects.Size = new System.Drawing.Size(229, 17);
            this.cb_fireAllObjects.TabIndex = 86;
            this.cb_fireAllObjects.Text = "Fire On All Objects";
            this.cb_fireAllObjects.UseVisualStyleBackColor = true;
            // 
            // addObjectButton
            // 
            this.addObjectButton.BackColor = System.Drawing.Color.White;
            this.addObjectButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addObjectButton.Location = new System.Drawing.Point(3, 211);
            this.addObjectButton.Name = "addObjectButton";
            this.addObjectButton.Size = new System.Drawing.Size(255, 46);
            this.addObjectButton.TabIndex = 78;
            this.addObjectButton.Text = "Add Object";
            this.addObjectButton.UseVisualStyleBackColor = false;
            this.addObjectButton.Click += new System.EventHandler(this.addObjectButton_Click);
            // 
            // objTreeView
            // 
            this.objTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objTreeView.Location = new System.Drawing.Point(0, 0);
            this.objTreeView.Name = "objTreeView";
            this.objTreeView.Size = new System.Drawing.Size(174, 680);
            this.objTreeView.TabIndex = 89;
            // 
            // objectsListBox
            // 
            this.objectsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectsListBox.FormattingEnabled = true;
            this.objectsListBox.Location = new System.Drawing.Point(0, 24);
            this.objectsListBox.Name = "objectsListBox";
            this.objectsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.objectsListBox.Size = new System.Drawing.Size(229, 325);
            this.objectsListBox.TabIndex = 90;
            this.objectsListBox.SelectedIndexChanged += new System.EventHandler(this.objectsListBox_SelectedIndexChanged);
            // 
            // objectsLabel
            // 
            this.objectsLabel.AutoSize = true;
            this.objectsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.objectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectsLabel.Location = new System.Drawing.Point(0, 0);
            this.objectsLabel.Name = "objectsLabel";
            this.objectsLabel.Size = new System.Drawing.Size(81, 24);
            this.objectsLabel.TabIndex = 91;
            this.objectsLabel.Text = "Objects";
            // 
            // instanceMethodLabel
            // 
            this.instanceMethodLabel.AutoSize = true;
            this.instanceMethodLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.instanceMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instanceMethodLabel.Location = new System.Drawing.Point(0, 0);
            this.instanceMethodLabel.Name = "instanceMethodLabel";
            this.instanceMethodLabel.Size = new System.Drawing.Size(174, 24);
            this.instanceMethodLabel.TabIndex = 94;
            this.instanceMethodLabel.Text = "Instance Methods";
            // 
            // instanceMethodListBox
            // 
            this.instanceMethodListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instanceMethodListBox.FormattingEnabled = true;
            this.instanceMethodListBox.Location = new System.Drawing.Point(0, 24);
            this.instanceMethodListBox.Name = "instanceMethodListBox";
            this.instanceMethodListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.instanceMethodListBox.Size = new System.Drawing.Size(229, 290);
            this.instanceMethodListBox.TabIndex = 95;
            // 
            // fieldsLabel
            // 
            this.fieldsLabel.AutoSize = true;
            this.fieldsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldsLabel.Location = new System.Drawing.Point(12, 159);
            this.fieldsLabel.Name = "fieldsLabel";
            this.fieldsLabel.Size = new System.Drawing.Size(67, 24);
            this.fieldsLabel.TabIndex = 96;
            this.fieldsLabel.Text = "Fields";
            // 
            // fieldsListBox
            // 
            this.fieldsListBox.FormattingEnabled = true;
            this.fieldsListBox.Location = new System.Drawing.Point(16, 186);
            this.fieldsListBox.Name = "fieldsListBox";
            this.fieldsListBox.Size = new System.Drawing.Size(170, 82);
            this.fieldsListBox.TabIndex = 97;
            this.fieldsListBox.SelectedIndexChanged += new System.EventHandler(this.fieldsListBox_SelectedIndexChanged);
            // 
            // propertiesListBox
            // 
            this.propertiesListBox.FormattingEnabled = true;
            this.propertiesListBox.Location = new System.Drawing.Point(12, 36);
            this.propertiesListBox.Name = "propertiesListBox";
            this.propertiesListBox.Size = new System.Drawing.Size(170, 82);
            this.propertiesListBox.TabIndex = 99;
            this.propertiesListBox.SelectedIndexChanged += new System.EventHandler(this.propertiesListBox_SelectedIndexChanged);
            // 
            // methodListBox
            // 
            this.methodListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.methodListBox.FormattingEnabled = true;
            this.methodListBox.Location = new System.Drawing.Point(0, 24);
            this.methodListBox.Name = "methodListBox";
            this.methodListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.methodListBox.Size = new System.Drawing.Size(261, 325);
            this.methodListBox.TabIndex = 100;
            this.methodListBox.SelectedIndexChanged += new System.EventHandler(this.methodListBox_SelectedIndexChanged);
            // 
            // methodListBoxLabel
            // 
            this.methodListBoxLabel.AutoSize = true;
            this.methodListBoxLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.methodListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodListBoxLabel.Location = new System.Drawing.Point(0, 0);
            this.methodListBoxLabel.Name = "methodListBoxLabel";
            this.methodListBoxLabel.Size = new System.Drawing.Size(146, 24);
            this.methodListBoxLabel.TabIndex = 101;
            this.methodListBoxLabel.Text = "Static Methods";
            // 
            // fieldValueLabel
            // 
            this.fieldValueLabel.AutoSize = true;
            this.fieldValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldValueLabel.Location = new System.Drawing.Point(192, 188);
            this.fieldValueLabel.Name = "fieldValueLabel";
            this.fieldValueLabel.Size = new System.Drawing.Size(49, 17);
            this.fieldValueLabel.TabIndex = 102;
            this.fieldValueLabel.Text = "Value";
            // 
            // setValueLabel
            // 
            this.setValueLabel.AutoSize = true;
            this.setValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setValueLabel.Location = new System.Drawing.Point(255, 188);
            this.setValueLabel.Name = "setValueLabel";
            this.setValueLabel.Size = new System.Drawing.Size(72, 17);
            this.setValueLabel.TabIndex = 103;
            this.setValueLabel.Text = "Set Field";
            // 
            // fieldValueTextBox
            // 
            this.fieldValueTextBox.Location = new System.Drawing.Point(258, 205);
            this.fieldValueTextBox.Name = "fieldValueTextBox";
            this.fieldValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.fieldValueTextBox.TabIndex = 104;
            // 
            // fieldValuePlacerholder
            // 
            this.fieldValuePlacerholder.AutoSize = true;
            this.fieldValuePlacerholder.Location = new System.Drawing.Point(192, 205);
            this.fieldValuePlacerholder.Name = "fieldValuePlacerholder";
            this.fieldValuePlacerholder.Size = new System.Drawing.Size(33, 13);
            this.fieldValuePlacerholder.TabIndex = 105;
            this.fieldValuePlacerholder.Text = "value";
            // 
            // changeFieldValueButt
            // 
            this.changeFieldValueButt.Location = new System.Drawing.Point(258, 231);
            this.changeFieldValueButt.Name = "changeFieldValueButt";
            this.changeFieldValueButt.Size = new System.Drawing.Size(100, 23);
            this.changeFieldValueButt.TabIndex = 106;
            this.changeFieldValueButt.Text = "Change Value";
            this.changeFieldValueButt.UseVisualStyleBackColor = true;
            this.changeFieldValueButt.Click += new System.EventHandler(this.changeFieldValueButt_Click);
            // 
            // propertyValuePlaceholder
            // 
            this.propertyValuePlaceholder.AutoSize = true;
            this.propertyValuePlaceholder.Location = new System.Drawing.Point(188, 56);
            this.propertyValuePlaceholder.Name = "propertyValuePlaceholder";
            this.propertyValuePlaceholder.Size = new System.Drawing.Size(33, 13);
            this.propertyValuePlaceholder.TabIndex = 111;
            this.propertyValuePlaceholder.Text = "value";
            // 
            // propertyValueLabel
            // 
            this.propertyValueLabel.AutoSize = true;
            this.propertyValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyValueLabel.Location = new System.Drawing.Point(188, 36);
            this.propertyValueLabel.Name = "propertyValueLabel";
            this.propertyValueLabel.Size = new System.Drawing.Size(48, 16);
            this.propertyValueLabel.TabIndex = 110;
            this.propertyValueLabel.Text = "Value";
            // 
            // propertiesSetValueLabel
            // 
            this.propertiesSetValueLabel.AutoSize = true;
            this.propertiesSetValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertiesSetValueLabel.Location = new System.Drawing.Point(255, 36);
            this.propertiesSetValueLabel.Name = "propertiesSetValueLabel";
            this.propertiesSetValueLabel.Size = new System.Drawing.Size(94, 16);
            this.propertiesSetValueLabel.TabIndex = 107;
            this.propertiesSetValueLabel.Text = "Set Property";
            // 
            // propertyValueTextBox
            // 
            this.propertyValueTextBox.Location = new System.Drawing.Point(258, 59);
            this.propertyValueTextBox.Name = "propertyValueTextBox";
            this.propertyValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.propertyValueTextBox.TabIndex = 108;
            // 
            // changePropertyValueButt
            // 
            this.changePropertyValueButt.Location = new System.Drawing.Point(258, 85);
            this.changePropertyValueButt.Name = "changePropertyValueButt";
            this.changePropertyValueButt.Size = new System.Drawing.Size(100, 23);
            this.changePropertyValueButt.TabIndex = 109;
            this.changePropertyValueButt.Text = "Change Value";
            this.changePropertyValueButt.UseVisualStyleBackColor = true;
            this.changePropertyValueButt.Click += new System.EventHandler(this.changePropertyValueButt_Click);
            // 
            // removeObjectButt
            // 
            this.removeObjectButt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.removeObjectButt.Location = new System.Drawing.Point(0, 349);
            this.removeObjectButt.Name = "removeObjectButt";
            this.removeObjectButt.Size = new System.Drawing.Size(229, 32);
            this.removeObjectButt.TabIndex = 112;
            this.removeObjectButt.Text = "Remove Object";
            this.removeObjectButt.UseVisualStyleBackColor = true;
            this.removeObjectButt.Click += new System.EventHandler(this.removeObjectButt_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.81275F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.18725F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 775);
            this.tableLayoutPanel1.TabIndex = 113;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.callConstructorButt);
            this.panel1.Controls.Add(this.getAllObjects);
            this.panel1.Controls.Add(this.objectsListBox);
            this.panel1.Controls.Add(this.objectsLabel);
            this.panel1.Controls.Add(this.removeObjectButt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 381);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.methodListBox);
            this.panel2.Controls.Add(this.methodListBoxLabel);
            this.panel2.Controls.Add(this.callMethod);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(238, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 381);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.instanceMethodListBox);
            this.panel3.Controls.Add(this.cb_fireAllObjects);
            this.panel3.Controls.Add(this.instanceMethodLabel);
            this.panel3.Controls.Add(this.callInstanceMethodButt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 390);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 382);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Controls.Add(this.setConstant_Butt);
            this.panel4.Controls.Add(this.testToObjects);
            this.panel4.Controls.Add(this.setConstant);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(238, 390);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 382);
            this.panel4.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.clearArgsButt, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.argumentsLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.addObjectButton, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.enteredArgsLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.addArgsTextBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.addArgumentButton, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(261, 316);
            this.tableLayoutPanel2.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 114;
            this.label1.Text = "Properties";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Size = new System.Drawing.Size(680, 775);
            this.splitContainer1.SplitterDistance = 502;
            this.splitContainer1.TabIndex = 115;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.objTreeView);
            this.panel5.Controls.Add(this.intPtrs);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(174, 775);
            this.panel5.TabIndex = 82;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.propertiesListBox);
            this.splitContainer2.Panel2.Controls.Add(this.fieldsListBox);
            this.splitContainer2.Panel2.Controls.Add(this.propertyValuePlaceholder);
            this.splitContainer2.Panel2.Controls.Add(this.fieldsLabel);
            this.splitContainer2.Panel2.Controls.Add(this.propertyValueLabel);
            this.splitContainer2.Panel2.Controls.Add(this.changeFieldValueButt);
            this.splitContainer2.Panel2.Controls.Add(this.propertiesSetValueLabel);
            this.splitContainer2.Panel2.Controls.Add(this.fieldValuePlacerholder);
            this.splitContainer2.Panel2.Controls.Add(this.propertyValueTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.fieldValueTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.changePropertyValueButt);
            this.splitContainer2.Panel2.Controls.Add(this.setValueLabel);
            this.splitContainer2.Panel2.Controls.Add(this.fieldValueLabel);
            this.splitContainer2.Size = new System.Drawing.Size(1246, 775);
            this.splitContainer2.SplitterDistance = 680;
            this.splitContainer2.TabIndex = 116;
            // 
            // MethodEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Name = "MethodEditor";
            this.Size = new System.Drawing.Size(1246, 775);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox intPtrs;
        private System.Windows.Forms.Label argumentsLabel;
        private System.Windows.Forms.Button setConstant_Butt;
        private System.Windows.Forms.Button callMethod;
        private System.Windows.Forms.TextBox setConstant;
        private System.Windows.Forms.Button addArgumentButton;
        private System.Windows.Forms.Button getAllObjects;
        private System.Windows.Forms.TextBox addArgsTextBox;
        private System.Windows.Forms.Button callInstanceMethodButt;
        private System.Windows.Forms.Button testToObjects;
        private System.Windows.Forms.Label enteredArgsLabel;
        private System.Windows.Forms.Button callConstructorButt;
        private System.Windows.Forms.Button clearArgsButt;
        private System.Windows.Forms.CheckBox cb_fireAllObjects;
        private System.Windows.Forms.Button addObjectButton;
        private System.Windows.Forms.TreeView objTreeView;
        private System.Windows.Forms.ListBox objectsListBox;
        private System.Windows.Forms.Label objectsLabel;
        private System.Windows.Forms.Label instanceMethodLabel;
        private System.Windows.Forms.ListBox instanceMethodListBox;
        private System.Windows.Forms.Label fieldsLabel;
        private System.Windows.Forms.ListBox fieldsListBox;
        private System.Windows.Forms.ListBox propertiesListBox;
        public System.Windows.Forms.ListBox methodListBox;
        private System.Windows.Forms.Label methodListBoxLabel;
        private System.Windows.Forms.Label fieldValueLabel;
        private System.Windows.Forms.Label setValueLabel;
        private System.Windows.Forms.TextBox fieldValueTextBox;
        private System.Windows.Forms.Label fieldValuePlacerholder;
        private System.Windows.Forms.Button changeFieldValueButt;
        private System.Windows.Forms.Label propertyValuePlaceholder;
        private System.Windows.Forms.Label propertyValueLabel;
        private System.Windows.Forms.Label propertiesSetValueLabel;
        private System.Windows.Forms.TextBox propertyValueTextBox;
        private System.Windows.Forms.Button changePropertyValueButt;
        private System.Windows.Forms.Button removeObjectButt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
