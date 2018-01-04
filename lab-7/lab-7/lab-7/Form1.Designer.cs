namespace lab_7
{
	partial class wPForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wPForm));
			this.wPRichTextBox = new System.Windows.Forms.RichTextBox();
			this.menuToolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripSaveButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripOpenButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripExitButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripCutButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripCopyButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripPasteButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripCenterButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripRightButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripLeftButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
			this.timeLabel = new System.Windows.Forms.ToolStripLabel();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addDateButton = new System.Windows.Forms.Button();
			this.displaySchedButton = new System.Windows.Forms.Button();
			this.lab7ImageList = new System.Windows.Forms.ImageList(this.components);
			this.currentTimer = new System.Windows.Forms.Timer(this.components);
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.selectedAvailabilityComboBox = new System.Windows.Forms.ComboBox();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.menuToolStrip.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// wPRichTextBox
			// 
			this.wPRichTextBox.Location = new System.Drawing.Point(12, 51);
			this.wPRichTextBox.Name = "wPRichTextBox";
			this.wPRichTextBox.Size = new System.Drawing.Size(415, 222);
			this.wPRichTextBox.TabIndex = 0;
			this.wPRichTextBox.Text = "";
			// 
			// menuToolStrip
			// 
			this.menuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSaveButton,
            this.toolStripOpenButton,
            this.toolStripExitButton,
            this.toolStripCutButton,
            this.toolStripCopyButton,
            this.toolStripPasteButton,
            this.toolStripCenterButton,
            this.toolStripRightButton,
            this.toolStripLeftButton,
            this.toolStripComboBox,
            this.timeLabel});
			this.menuToolStrip.Location = new System.Drawing.Point(0, 0);
			this.menuToolStrip.Name = "menuToolStrip";
			this.menuToolStrip.Size = new System.Drawing.Size(907, 25);
			this.menuToolStrip.TabIndex = 1;
			this.menuToolStrip.Text = "toolStrip1";
			// 
			// toolStripSaveButton
			// 
			this.toolStripSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveButton.Image")));
			this.toolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSaveButton.Name = "toolStripSaveButton";
			this.toolStripSaveButton.Size = new System.Drawing.Size(23, 22);
			this.toolStripSaveButton.Text = "Save";
			this.toolStripSaveButton.Click += new System.EventHandler(this.toolStripSaveButton_Click);
			// 
			// toolStripOpenButton
			// 
			this.toolStripOpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripOpenButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpenButton.Image")));
			this.toolStripOpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripOpenButton.Name = "toolStripOpenButton";
			this.toolStripOpenButton.Size = new System.Drawing.Size(23, 22);
			this.toolStripOpenButton.Text = "Open";
			this.toolStripOpenButton.Click += new System.EventHandler(this.toolStripOpenButton_Click);
			// 
			// toolStripExitButton
			// 
			this.toolStripExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripExitButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExitButton.Image")));
			this.toolStripExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripExitButton.Name = "toolStripExitButton";
			this.toolStripExitButton.Size = new System.Drawing.Size(23, 22);
			this.toolStripExitButton.Text = "Exit";
			this.toolStripExitButton.Click += new System.EventHandler(this.toolStripExitButton_Click);
			// 
			// toolStripCutButton
			// 
			this.toolStripCutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripCutButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCutButton.Image")));
			this.toolStripCutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripCutButton.Name = "toolStripCutButton";
			this.toolStripCutButton.Size = new System.Drawing.Size(23, 22);
			this.toolStripCutButton.Text = "Cut";
			this.toolStripCutButton.Click += new System.EventHandler(this.toolStripCutButton_Click);
			// 
			// toolStripCopyButton
			// 
			this.toolStripCopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCopyButton.Image")));
			this.toolStripCopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripCopyButton.Name = "toolStripCopyButton";
			this.toolStripCopyButton.Size = new System.Drawing.Size(23, 22);
			this.toolStripCopyButton.Text = "Copy";
			this.toolStripCopyButton.Click += new System.EventHandler(this.toolStripCopyButton_Click);
			// 
			// toolStripPasteButton
			// 
			this.toolStripPasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripPasteButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPasteButton.Image")));
			this.toolStripPasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripPasteButton.Name = "toolStripPasteButton";
			this.toolStripPasteButton.Size = new System.Drawing.Size(23, 22);
			this.toolStripPasteButton.Text = "Paste";
			this.toolStripPasteButton.Click += new System.EventHandler(this.toolStripPasteButton_Click);
			// 
			// toolStripCenterButton
			// 
			this.toolStripCenterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripCenterButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCenterButton.Image")));
			this.toolStripCenterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripCenterButton.Name = "toolStripCenterButton";
			this.toolStripCenterButton.Size = new System.Drawing.Size(23, 22);
			this.toolStripCenterButton.Text = "Center";
			this.toolStripCenterButton.Click += new System.EventHandler(this.toolStripCenterButton_Click);
			// 
			// toolStripRightButton
			// 
			this.toolStripRightButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripRightButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRightButton.Image")));
			this.toolStripRightButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripRightButton.Name = "toolStripRightButton";
			this.toolStripRightButton.Size = new System.Drawing.Size(23, 22);
			this.toolStripRightButton.Text = "Right";
			this.toolStripRightButton.Click += new System.EventHandler(this.toolStripRightButton_Click);
			// 
			// toolStripLeftButton
			// 
			this.toolStripLeftButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLeftButton.Image")));
			this.toolStripLeftButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripLeftButton.Name = "toolStripLeftButton";
			this.toolStripLeftButton.Size = new System.Drawing.Size(23, 22);
			this.toolStripLeftButton.Text = "Left";
			this.toolStripLeftButton.Click += new System.EventHandler(this.toolStripLeftButton_Click);
			// 
			// toolStripComboBox
			// 
			this.toolStripComboBox.Name = "toolStripComboBox";
			this.toolStripComboBox.Size = new System.Drawing.Size(121, 25);
			this.toolStripComboBox.Text = "Select One";
			this.toolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_SelectedIndexChanged);
			this.toolStripComboBox.Click += new System.EventHandler(this.toolStripComboBox1_Click);
			// 
			// timeLabel
			// 
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(0, 22);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.clearToolStripMenuItem});
			this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(103, 92);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Image = global::lab_7.Properties.Resources.cut;
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.cutToolStripMenuItem.Text = "Cut";
			this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Image = global::lab_7.Properties.Resources.copy;
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Image = global::lab_7.Properties.Resources.paste;
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.pasteToolStripMenuItem.Text = "Paste";
			this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Image = global::lab_7.Properties.Resources.clear;
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.clearToolStripMenuItem.Text = "Clear";
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
			// 
			// addDateButton
			// 
			this.addDateButton.Location = new System.Drawing.Point(645, 164);
			this.addDateButton.Name = "addDateButton";
			this.addDateButton.Size = new System.Drawing.Size(122, 23);
			this.addDateButton.TabIndex = 3;
			this.addDateButton.Text = "Add Selected Date";
			this.addDateButton.UseVisualStyleBackColor = true;
			this.addDateButton.Click += new System.EventHandler(this.addDateButton_Click);
			// 
			// displaySchedButton
			// 
			this.displaySchedButton.Location = new System.Drawing.Point(622, 208);
			this.displaySchedButton.Name = "displaySchedButton";
			this.displaySchedButton.Size = new System.Drawing.Size(167, 65);
			this.displaySchedButton.TabIndex = 4;
			this.displaySchedButton.Text = "Display The Entire Schedule";
			this.displaySchedButton.UseVisualStyleBackColor = true;
			this.displaySchedButton.Click += new System.EventHandler(this.displaySchedButton_Click);
			// 
			// lab7ImageList
			// 
			this.lab7ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lab7ImageList.ImageStream")));
			this.lab7ImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.lab7ImageList.Images.SetKeyName(0, "save.png");
			this.lab7ImageList.Images.SetKeyName(1, "open.png");
			this.lab7ImageList.Images.SetKeyName(2, "exit.png");
			this.lab7ImageList.Images.SetKeyName(3, "cut.png");
			this.lab7ImageList.Images.SetKeyName(4, "copy.png");
			this.lab7ImageList.Images.SetKeyName(5, "paste.png");
			this.lab7ImageList.Images.SetKeyName(6, "center.png");
			this.lab7ImageList.Images.SetKeyName(7, "right.png");
			this.lab7ImageList.Images.SetKeyName(8, "left.png");
			this.lab7ImageList.Images.SetKeyName(9, "clear.png");
			// 
			// currentTimer
			// 
			this.currentTimer.Tick += new System.EventHandler(this.currentTimer_Tick);
			// 
			// selectedAvailabilityComboBox
			// 
			this.selectedAvailabilityComboBox.FormattingEnabled = true;
			this.selectedAvailabilityComboBox.Location = new System.Drawing.Point(491, 83);
			this.selectedAvailabilityComboBox.Name = "selectedAvailabilityComboBox";
			this.selectedAvailabilityComboBox.Size = new System.Drawing.Size(145, 21);
			this.selectedAvailabilityComboBox.TabIndex = 5;
			this.selectedAvailabilityComboBox.Text = "Choose a date";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Location = new System.Drawing.Point(682, 84);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker.TabIndex = 6;
			// 
			// wPForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(907, 285);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.selectedAvailabilityComboBox);
			this.Controls.Add(this.displaySchedButton);
			this.Controls.Add(this.addDateButton);
			this.Controls.Add(this.menuToolStrip);
			this.Controls.Add(this.wPRichTextBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "wPForm";
			this.Text = "Lab 7 Word Processor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wPForm_FormClosing);
			this.Load += new System.EventHandler(this.wPForm_Load);
			this.menuToolStrip.ResumeLayout(false);
			this.menuToolStrip.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox wPRichTextBox;
		private System.Windows.Forms.ToolStrip menuToolStrip;
		private System.Windows.Forms.ToolStripButton toolStripSaveButton;
		private System.Windows.Forms.ToolStripButton toolStripOpenButton;
		private System.Windows.Forms.ToolStripButton toolStripExitButton;
		private System.Windows.Forms.ToolStripButton toolStripCutButton;
		private System.Windows.Forms.ToolStripButton toolStripCopyButton;
		private System.Windows.Forms.ToolStripButton toolStripPasteButton;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripCenterButton;
		private System.Windows.Forms.ToolStripButton toolStripRightButton;
		private System.Windows.Forms.ToolStripButton toolStripLeftButton;
		private System.Windows.Forms.Button addDateButton;
		private System.Windows.Forms.Button displaySchedButton;
		private System.Windows.Forms.ImageList lab7ImageList;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBox;
		private System.Windows.Forms.ToolStripLabel timeLabel;
		private System.Windows.Forms.Timer currentTimer;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.ComboBox selectedAvailabilityComboBox;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
	}
}

