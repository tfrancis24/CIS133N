namespace Lab_4_Timf
{
	partial class stateForm
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
			this.components = new System.ComponentModel.Container();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.oregonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.washingtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.californiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.utitlitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inputBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.titleLabel = new System.Windows.Forms.Label();
			this.selectionGroupBox = new System.Windows.Forms.GroupBox();
			this.caliRadioButton = new System.Windows.Forms.RadioButton();
			this.washingtonRadioButton = new System.Windows.Forms.RadioButton();
			this.OregonRadioButton = new System.Windows.Forms.RadioButton();
			this.optionGroupBox = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.stateGroupBox = new System.Windows.Forms.GroupBox();
			this.nickInfoLabel = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.nickLabel = new System.Windows.Forms.Label();
			this.climateInfoLabel = new System.Windows.Forms.Label();
			this.climateLabel = new System.Windows.Forms.Label();
			this.popInfoLabel = new System.Windows.Forms.Label();
			this.popLabel = new System.Windows.Forms.Label();
			this.stateNameLabel = new System.Windows.Forms.Label();
			this.phoneCheckBox = new System.Windows.Forms.CheckBox();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.serviceController1 = new System.ServiceProcess.ServiceController();
			this.statePictureBox = new System.Windows.Forms.PictureBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip.SuspendLayout();
			this.selectionGroupBox.SuspendLayout();
			this.optionGroupBox.SuspendLayout();
			this.stateGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.statesToolStripMenuItem,
            this.utitlitiesToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(830, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// statesToolStripMenuItem
			// 
			this.statesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oregonToolStripMenuItem,
            this.washingtonToolStripMenuItem,
            this.californiaToolStripMenuItem});
			this.statesToolStripMenuItem.Name = "statesToolStripMenuItem";
			this.statesToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.statesToolStripMenuItem.Text = "States";
			// 
			// oregonToolStripMenuItem
			// 
			this.oregonToolStripMenuItem.Name = "oregonToolStripMenuItem";
			this.oregonToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.oregonToolStripMenuItem.Text = "Oregon";
			this.oregonToolStripMenuItem.Click += new System.EventHandler(this.oregonToolStripMenuItem_Click);
			// 
			// washingtonToolStripMenuItem
			// 
			this.washingtonToolStripMenuItem.Name = "washingtonToolStripMenuItem";
			this.washingtonToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.washingtonToolStripMenuItem.Text = "Washington";
			this.washingtonToolStripMenuItem.Click += new System.EventHandler(this.washingtonToolStripMenuItem_Click);
			// 
			// californiaToolStripMenuItem
			// 
			this.californiaToolStripMenuItem.Name = "californiaToolStripMenuItem";
			this.californiaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.californiaToolStripMenuItem.Text = "California";
			this.californiaToolStripMenuItem.Click += new System.EventHandler(this.californiaToolStripMenuItem_Click);
			// 
			// utitlitiesToolStripMenuItem
			// 
			this.utitlitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputBoxToolStripMenuItem,
            this.clearToolStripMenuItem});
			this.utitlitiesToolStripMenuItem.Name = "utitlitiesToolStripMenuItem";
			this.utitlitiesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.utitlitiesToolStripMenuItem.Text = "Utitlities";
			// 
			// inputBoxToolStripMenuItem
			// 
			this.inputBoxToolStripMenuItem.Name = "inputBoxToolStripMenuItem";
			this.inputBoxToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.inputBoxToolStripMenuItem.Text = "Input Box";
			this.inputBoxToolStripMenuItem.Click += new System.EventHandler(this.inputBoxToolStripMenuItem_Click);
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.clearToolStripMenuItem.Text = "Clear";
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
			// 
			// titleLabel
			// 
			this.titleLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.titleLabel.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.titleLabel.Location = new System.Drawing.Point(474, 41);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(171, 32);
			this.titleLabel.TabIndex = 1;
			this.titleLabel.Text = "State";
			this.toolTip1.SetToolTip(this.titleLabel, "State Information");
			// 
			// selectionGroupBox
			// 
			this.selectionGroupBox.Controls.Add(this.caliRadioButton);
			this.selectionGroupBox.Controls.Add(this.washingtonRadioButton);
			this.selectionGroupBox.Controls.Add(this.OregonRadioButton);
			this.selectionGroupBox.Location = new System.Drawing.Point(78, 41);
			this.selectionGroupBox.Name = "selectionGroupBox";
			this.selectionGroupBox.Size = new System.Drawing.Size(200, 122);
			this.selectionGroupBox.TabIndex = 2;
			this.selectionGroupBox.TabStop = false;
			this.selectionGroupBox.Text = "States";
			// 
			// caliRadioButton
			// 
			this.caliRadioButton.AutoSize = true;
			this.caliRadioButton.Location = new System.Drawing.Point(17, 91);
			this.caliRadioButton.Name = "caliRadioButton";
			this.caliRadioButton.Size = new System.Drawing.Size(68, 17);
			this.caliRadioButton.TabIndex = 3;
			this.caliRadioButton.TabStop = true;
			this.caliRadioButton.Text = "California";
			this.toolTip1.SetToolTip(this.caliRadioButton, "State of California");
			this.caliRadioButton.UseVisualStyleBackColor = true;
			this.caliRadioButton.CheckedChanged += new System.EventHandler(this.caliRadioButton_CheckedChanged);
			// 
			// washingtonRadioButton
			// 
			this.washingtonRadioButton.AutoSize = true;
			this.washingtonRadioButton.Location = new System.Drawing.Point(17, 56);
			this.washingtonRadioButton.Name = "washingtonRadioButton";
			this.washingtonRadioButton.Size = new System.Drawing.Size(82, 17);
			this.washingtonRadioButton.TabIndex = 2;
			this.washingtonRadioButton.TabStop = true;
			this.washingtonRadioButton.Text = "Washington";
			this.toolTip1.SetToolTip(this.washingtonRadioButton, "State of Washington");
			this.washingtonRadioButton.UseVisualStyleBackColor = true;
			this.washingtonRadioButton.CheckedChanged += new System.EventHandler(this.washingtonRadioButton_CheckedChanged);
			// 
			// OregonRadioButton
			// 
			this.OregonRadioButton.AutoSize = true;
			this.OregonRadioButton.Location = new System.Drawing.Point(17, 19);
			this.OregonRadioButton.Name = "OregonRadioButton";
			this.OregonRadioButton.Size = new System.Drawing.Size(60, 17);
			this.OregonRadioButton.TabIndex = 1;
			this.OregonRadioButton.TabStop = true;
			this.OregonRadioButton.Text = "Oregon";
			this.toolTip1.SetToolTip(this.OregonRadioButton, "State of Oregon");
			this.OregonRadioButton.UseVisualStyleBackColor = true;
			this.OregonRadioButton.CheckedChanged += new System.EventHandler(this.OregonRadioButton_CheckedChanged);
			// 
			// optionGroupBox
			// 
			this.optionGroupBox.Controls.Add(this.button1);
			this.optionGroupBox.Controls.Add(this.clearButton);
			this.optionGroupBox.Controls.Add(this.exitButton);
			this.optionGroupBox.Location = new System.Drawing.Point(78, 195);
			this.optionGroupBox.Name = "optionGroupBox";
			this.optionGroupBox.Size = new System.Drawing.Size(125, 128);
			this.optionGroupBox.TabIndex = 0;
			this.optionGroupBox.TabStop = false;
			this.optionGroupBox.Text = "Your Options";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(17, 28);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Message Box";
			this.toolTip1.SetToolTip(this.button1, "Click to see a message box");
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(17, 57);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(93, 23);
			this.clearButton.TabIndex = 5;
			this.clearButton.Text = "Clear All";
			this.toolTip1.SetToolTip(this.clearButton, "Clears all fields");
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(17, 86);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(93, 23);
			this.exitButton.TabIndex = 6;
			this.exitButton.Text = "Exit";
			this.toolTip1.SetToolTip(this.exitButton, "Exits the program");
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// stateGroupBox
			// 
			this.stateGroupBox.BackColor = System.Drawing.SystemColors.Control;
			this.stateGroupBox.Controls.Add(this.nickInfoLabel);
			this.stateGroupBox.Controls.Add(this.label9);
			this.stateGroupBox.Controls.Add(this.nickLabel);
			this.stateGroupBox.Controls.Add(this.climateInfoLabel);
			this.stateGroupBox.Controls.Add(this.climateLabel);
			this.stateGroupBox.Controls.Add(this.popInfoLabel);
			this.stateGroupBox.Controls.Add(this.popLabel);
			this.stateGroupBox.Controls.Add(this.stateNameLabel);
			this.stateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
			this.stateGroupBox.ForeColor = System.Drawing.Color.White;
			this.stateGroupBox.Location = new System.Drawing.Point(474, 195);
			this.stateGroupBox.Name = "stateGroupBox";
			this.stateGroupBox.Size = new System.Drawing.Size(295, 272);
			this.stateGroupBox.TabIndex = 3;
			this.stateGroupBox.TabStop = false;
			this.stateGroupBox.Text = "State Information";
			this.toolTip1.SetToolTip(this.stateGroupBox, "State Information");
			this.stateGroupBox.Enter += new System.EventHandler(this.stateGroupBox_Enter);
			// 
			// nickInfoLabel
			// 
			this.nickInfoLabel.Location = new System.Drawing.Point(26, 233);
			this.nickInfoLabel.Name = "nickInfoLabel";
			this.nickInfoLabel.Size = new System.Drawing.Size(263, 24);
			this.nickInfoLabel.TabIndex = 9;
			this.nickInfoLabel.Text = "label10";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(81, 233);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(0, 20);
			this.label9.TabIndex = 8;
			// 
			// nickLabel
			// 
			this.nickLabel.AutoSize = true;
			this.nickLabel.Location = new System.Drawing.Point(26, 213);
			this.nickLabel.Name = "nickLabel";
			this.nickLabel.Size = new System.Drawing.Size(79, 20);
			this.nickLabel.TabIndex = 7;
			this.nickLabel.Text = "Nickname";
			// 
			// climateInfoLabel
			// 
			this.climateInfoLabel.Location = new System.Drawing.Point(30, 150);
			this.climateInfoLabel.Name = "climateInfoLabel";
			this.climateInfoLabel.Size = new System.Drawing.Size(259, 63);
			this.climateInfoLabel.TabIndex = 6;
			this.climateInfoLabel.Text = "label7";
			// 
			// climateLabel
			// 
			this.climateLabel.AutoSize = true;
			this.climateLabel.Location = new System.Drawing.Point(30, 128);
			this.climateLabel.Name = "climateLabel";
			this.climateLabel.Size = new System.Drawing.Size(62, 20);
			this.climateLabel.TabIndex = 5;
			this.climateLabel.Text = "Climate";
			// 
			// popInfoLabel
			// 
			this.popInfoLabel.Location = new System.Drawing.Point(30, 79);
			this.popInfoLabel.Name = "popInfoLabel";
			this.popInfoLabel.Size = new System.Drawing.Size(259, 49);
			this.popInfoLabel.TabIndex = 4;
			this.popInfoLabel.Text = "label5";
			// 
			// popLabel
			// 
			this.popLabel.AutoSize = true;
			this.popLabel.Location = new System.Drawing.Point(30, 59);
			this.popLabel.Name = "popLabel";
			this.popLabel.Size = new System.Drawing.Size(84, 20);
			this.popLabel.TabIndex = 3;
			this.popLabel.Text = "Population";
			// 
			// stateNameLabel
			// 
			this.stateNameLabel.AutoSize = true;
			this.stateNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
			this.stateNameLabel.ForeColor = System.Drawing.Color.Yellow;
			this.stateNameLabel.Location = new System.Drawing.Point(30, 22);
			this.stateNameLabel.Name = "stateNameLabel";
			this.stateNameLabel.Size = new System.Drawing.Size(70, 26);
			this.stateNameLabel.TabIndex = 0;
			this.stateNameLabel.Text = "label1";
			this.stateNameLabel.Click += new System.EventHandler(this.stateNameLabel_Click);
			// 
			// phoneCheckBox
			// 
			this.phoneCheckBox.AutoSize = true;
			this.phoneCheckBox.Location = new System.Drawing.Point(78, 367);
			this.phoneCheckBox.Name = "phoneCheckBox";
			this.phoneCheckBox.Size = new System.Drawing.Size(63, 17);
			this.phoneCheckBox.TabIndex = 10;
			this.phoneCheckBox.Text = "Phone?";
			this.toolTip1.SetToolTip(this.phoneCheckBox, "Click to enter a phone  number");
			this.phoneCheckBox.UseVisualStyleBackColor = true;
			this.phoneCheckBox.CheckedChanged += new System.EventHandler(this.phoneCheckBox_CheckedChanged);
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(78, 390);
			this.maskedTextBox1.Mask = "(999) 000-0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
			this.maskedTextBox1.TabIndex = 11;
			this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
			// 
			// statePictureBox
			// 
			this.statePictureBox.Location = new System.Drawing.Point(474, 76);
			this.statePictureBox.Name = "statePictureBox";
			this.statePictureBox.Size = new System.Drawing.Size(171, 96);
			this.statePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.statePictureBox.TabIndex = 12;
			this.statePictureBox.TabStop = false;
			this.statePictureBox.Click += new System.EventHandler(this.statePictureBox_Click);
			// 
			// stateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(830, 518);
			this.Controls.Add(this.statePictureBox);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.phoneCheckBox);
			this.Controls.Add(this.optionGroupBox);
			this.Controls.Add(this.stateGroupBox);
			this.Controls.Add(this.selectionGroupBox);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "stateForm";
			this.Text = "State Information";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.selectionGroupBox.ResumeLayout(false);
			this.selectionGroupBox.PerformLayout();
			this.optionGroupBox.ResumeLayout(false);
			this.stateGroupBox.ResumeLayout(false);
			this.stateGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.statePictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem statesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem oregonToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem washingtonToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem californiaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem utitlitiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inputBoxToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.GroupBox selectionGroupBox;
		private System.Windows.Forms.GroupBox optionGroupBox;
		private System.Windows.Forms.GroupBox stateGroupBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.RadioButton caliRadioButton;
		private System.Windows.Forms.RadioButton washingtonRadioButton;
		private System.Windows.Forms.RadioButton OregonRadioButton;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label nickLabel;
		private System.Windows.Forms.Label climateInfoLabel;
		private System.Windows.Forms.Label climateLabel;
		private System.Windows.Forms.Label popInfoLabel;
		private System.Windows.Forms.Label popLabel;
		private System.Windows.Forms.Label stateNameLabel;
		private System.Windows.Forms.Label nickInfoLabel;
		private System.Windows.Forms.CheckBox phoneCheckBox;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.ServiceProcess.ServiceController serviceController1;
		private System.Windows.Forms.PictureBox statePictureBox;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

