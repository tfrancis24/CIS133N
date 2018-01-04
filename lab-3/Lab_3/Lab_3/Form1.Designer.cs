namespace Lab_3
{
	partial class calcForm
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
			this.titleLabel = new System.Windows.Forms.Label();
			this.calcGroupBox = new System.Windows.Forms.GroupBox();
			this.addButton = new System.Windows.Forms.Button();
			this.subtractButton = new System.Windows.Forms.Button();
			this.multiplyButton = new System.Windows.Forms.Button();
			this.divideButton = new System.Windows.Forms.Button();
			this.inputGroupBox = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.enterNumber1Label = new System.Windows.Forms.Label();
			this.enterNumber2Label = new System.Windows.Forms.Label();
			this.resultGroupBox = new System.Windows.Forms.GroupBox();
			this.resultLabel = new System.Windows.Forms.Label();
			this.processGroupBox = new System.Windows.Forms.GroupBox();
			this.clearButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.calcGroupBox.SuspendLayout();
			this.inputGroupBox.SuspendLayout();
			this.resultGroupBox.SuspendLayout();
			this.processGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.titleLabel.ForeColor = System.Drawing.Color.Red;
			this.titleLabel.Location = new System.Drawing.Point(228, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(157, 36);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "My Calculator";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// calcGroupBox
			// 
			this.calcGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.calcGroupBox.Controls.Add(this.addButton);
			this.calcGroupBox.Controls.Add(this.subtractButton);
			this.calcGroupBox.Controls.Add(this.multiplyButton);
			this.calcGroupBox.Controls.Add(this.divideButton);
			this.calcGroupBox.Location = new System.Drawing.Point(25, 53);
			this.calcGroupBox.Name = "calcGroupBox";
			this.calcGroupBox.Size = new System.Drawing.Size(200, 100);
			this.calcGroupBox.TabIndex = 1;
			this.calcGroupBox.TabStop = false;
			this.calcGroupBox.Text = "Calculation";
			// 
			// addButton
			// 
			this.addButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.addButton.Location = new System.Drawing.Point(23, 19);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 4;
			this.addButton.Text = "&Add";
			this.toolTip1.SetToolTip(this.addButton, "Click to add your two values.");
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// subtractButton
			// 
			this.subtractButton.Location = new System.Drawing.Point(104, 19);
			this.subtractButton.Name = "subtractButton";
			this.subtractButton.Size = new System.Drawing.Size(75, 23);
			this.subtractButton.TabIndex = 5;
			this.subtractButton.Text = "&Subtract";
			this.toolTip1.SetToolTip(this.subtractButton, "Click to subtract your two values.");
			this.subtractButton.UseVisualStyleBackColor = true;
			this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
			// 
			// multiplyButton
			// 
			this.multiplyButton.Location = new System.Drawing.Point(23, 53);
			this.multiplyButton.Name = "multiplyButton";
			this.multiplyButton.Size = new System.Drawing.Size(75, 23);
			this.multiplyButton.TabIndex = 6;
			this.multiplyButton.Text = "&Multiply";
			this.toolTip1.SetToolTip(this.multiplyButton, "Click to multiply your two values.");
			this.multiplyButton.UseVisualStyleBackColor = true;
			this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
			// 
			// divideButton
			// 
			this.divideButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.divideButton.Location = new System.Drawing.Point(104, 53);
			this.divideButton.Name = "divideButton";
			this.divideButton.Size = new System.Drawing.Size(75, 23);
			this.divideButton.TabIndex = 7;
			this.divideButton.Text = "&Divide";
			this.toolTip1.SetToolTip(this.divideButton, "Click to divide your two values.");
			this.divideButton.UseVisualStyleBackColor = true;
			this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
			// 
			// inputGroupBox
			// 
			this.inputGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.inputGroupBox.Controls.Add(this.textBox1);
			this.inputGroupBox.Controls.Add(this.textBox2);
			this.inputGroupBox.Controls.Add(this.enterNumber1Label);
			this.inputGroupBox.Controls.Add(this.enterNumber2Label);
			this.inputGroupBox.Location = new System.Drawing.Point(388, 53);
			this.inputGroupBox.Name = "inputGroupBox";
			this.inputGroupBox.Size = new System.Drawing.Size(200, 100);
			this.inputGroupBox.TabIndex = 0;
			this.inputGroupBox.TabStop = false;
			this.inputGroupBox.Text = "Input";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(91, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(91, 51);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 1;
			// 
			// enterNumber1Label
			// 
			this.enterNumber1Label.AutoSize = true;
			this.enterNumber1Label.Location = new System.Drawing.Point(6, 31);
			this.enterNumber1Label.Name = "enterNumber1Label";
			this.enterNumber1Label.Size = new System.Drawing.Size(79, 13);
			this.enterNumber1Label.TabIndex = 2;
			this.enterNumber1Label.Text = "Enter a number";
			// 
			// enterNumber2Label
			// 
			this.enterNumber2Label.AutoSize = true;
			this.enterNumber2Label.Location = new System.Drawing.Point(6, 58);
			this.enterNumber2Label.Name = "enterNumber2Label";
			this.enterNumber2Label.Size = new System.Drawing.Size(79, 13);
			this.enterNumber2Label.TabIndex = 3;
			this.enterNumber2Label.Text = "Enter a number";
			// 
			// resultGroupBox
			// 
			this.resultGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.resultGroupBox.Controls.Add(this.resultLabel);
			this.resultGroupBox.Location = new System.Drawing.Point(25, 182);
			this.resultGroupBox.Name = "resultGroupBox";
			this.resultGroupBox.Size = new System.Drawing.Size(200, 100);
			this.resultGroupBox.TabIndex = 0;
			this.resultGroupBox.TabStop = false;
			this.resultGroupBox.Text = "Result";
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Location = new System.Drawing.Point(6, 38);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(37, 13);
			this.resultLabel.TabIndex = 4;
			this.resultLabel.Text = "Result";
			this.toolTip1.SetToolTip(this.resultLabel, "This is your result");
			// 
			// processGroupBox
			// 
			this.processGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.processGroupBox.Controls.Add(this.clearButton);
			this.processGroupBox.Controls.Add(this.exitButton);
			this.processGroupBox.Location = new System.Drawing.Point(388, 182);
			this.processGroupBox.Name = "processGroupBox";
			this.processGroupBox.Size = new System.Drawing.Size(200, 100);
			this.processGroupBox.TabIndex = 0;
			this.processGroupBox.TabStop = false;
			this.processGroupBox.Text = "Process";
			// 
			// clearButton
			// 
			this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.clearButton.Location = new System.Drawing.Point(6, 55);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(75, 23);
			this.clearButton.TabIndex = 8;
			this.clearButton.Text = "&Clear";
			this.toolTip1.SetToolTip(this.clearButton, "Click to clear textboxes");
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(119, 55);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 9;
			this.exitButton.Text = "E&xit";
			this.toolTip1.SetToolTip(this.exitButton, "Click to exit");
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// calcForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(613, 310);
			this.Controls.Add(this.inputGroupBox);
			this.Controls.Add(this.resultGroupBox);
			this.Controls.Add(this.processGroupBox);
			this.Controls.Add(this.calcGroupBox);
			this.Controls.Add(this.titleLabel);
			this.Name = "calcForm";
			this.Text = "Calculator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.calcForm_FormClosing);
			this.Load += new System.EventHandler(this.calcForm_Load);
			this.calcGroupBox.ResumeLayout(false);
			this.inputGroupBox.ResumeLayout(false);
			this.inputGroupBox.PerformLayout();
			this.resultGroupBox.ResumeLayout(false);
			this.resultGroupBox.PerformLayout();
			this.processGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.GroupBox calcGroupBox;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button subtractButton;
		private System.Windows.Forms.Button multiplyButton;
		private System.Windows.Forms.Button divideButton;
		private System.Windows.Forms.GroupBox inputGroupBox;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label enterNumber1Label;
		private System.Windows.Forms.Label enterNumber2Label;
		private System.Windows.Forms.GroupBox resultGroupBox;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.GroupBox processGroupBox;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

