namespace WindowsFormsApplication1
{
	partial class dataValidationForm
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
			this.dataEntryLabel = new System.Windows.Forms.Label();
			this.enterNumberLabel = new System.Windows.Forms.Label();
			this.enterFirstNameLabel = new System.Windows.Forms.Label();
			this.enterLastNameLabel = new System.Windows.Forms.Label();
			this.enterFirstNameTextBox = new System.Windows.Forms.TextBox();
			this.enterLastNameTextBox = new System.Windows.Forms.TextBox();
			this.enterNumberTextBox = new System.Windows.Forms.TextBox();
			this.showDataButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.dataErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.dataListView = new System.Windows.Forms.ListView();
			this.empNumColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.firstNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lastNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.dataErrorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// dataEntryLabel
			// 
			this.dataEntryLabel.AutoSize = true;
			this.dataEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataEntryLabel.ForeColor = System.Drawing.Color.ForestGreen;
			this.dataEntryLabel.Location = new System.Drawing.Point(382, 9);
			this.dataEntryLabel.Name = "dataEntryLabel";
			this.dataEntryLabel.Size = new System.Drawing.Size(236, 37);
			this.dataEntryLabel.TabIndex = 0;
			this.dataEntryLabel.Text = "Data Validation";
			this.dataEntryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// enterNumberLabel
			// 
			this.enterNumberLabel.AutoSize = true;
			this.enterNumberLabel.Location = new System.Drawing.Point(125, 93);
			this.enterNumberLabel.Name = "enterNumberLabel";
			this.enterNumberLabel.Size = new System.Drawing.Size(118, 13);
			this.enterNumberLabel.TabIndex = 2;
			this.enterNumberLabel.Text = "Enter employee number";
			// 
			// enterFirstNameLabel
			// 
			this.enterFirstNameLabel.AutoSize = true;
			this.enterFirstNameLabel.Location = new System.Drawing.Point(125, 129);
			this.enterFirstNameLabel.Name = "enterFirstNameLabel";
			this.enterFirstNameLabel.Size = new System.Drawing.Size(154, 13);
			this.enterFirstNameLabel.TabIndex = 3;
			this.enterFirstNameLabel.Text = "Enter first name (All lower case)";
			// 
			// enterLastNameLabel
			// 
			this.enterLastNameLabel.AutoSize = true;
			this.enterLastNameLabel.Location = new System.Drawing.Point(125, 164);
			this.enterLastNameLabel.Name = "enterLastNameLabel";
			this.enterLastNameLabel.Size = new System.Drawing.Size(156, 13);
			this.enterLastNameLabel.TabIndex = 4;
			this.enterLastNameLabel.Text = "Enter last name (All upper case)";
			// 
			// enterFirstNameTextBox
			// 
			this.enterFirstNameTextBox.Location = new System.Drawing.Point(330, 126);
			this.enterFirstNameTextBox.Name = "enterFirstNameTextBox";
			this.enterFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.enterFirstNameTextBox.TabIndex = 6;
			this.enterFirstNameTextBox.TextChanged += new System.EventHandler(this.enterFirstNameTextBox_TextChanged);
			this.enterFirstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterFirstNameTextBox_KeyPress);
			// 
			// enterLastNameTextBox
			// 
			this.enterLastNameTextBox.Location = new System.Drawing.Point(330, 161);
			this.enterLastNameTextBox.Name = "enterLastNameTextBox";
			this.enterLastNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.enterLastNameTextBox.TabIndex = 7;
			this.enterLastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterLastNameTextBox_KeyPress);
			// 
			// enterNumberTextBox
			// 
			this.enterNumberTextBox.Location = new System.Drawing.Point(330, 90);
			this.enterNumberTextBox.Name = "enterNumberTextBox";
			this.enterNumberTextBox.Size = new System.Drawing.Size(100, 20);
			this.enterNumberTextBox.TabIndex = 8;
			this.enterNumberTextBox.TextChanged += new System.EventHandler(this.enterNumberTextBox_TextChanged);
			this.enterNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterNumberTextBox_KeyPress);
			// 
			// showDataButton
			// 
			this.showDataButton.Location = new System.Drawing.Point(128, 214);
			this.showDataButton.Name = "showDataButton";
			this.showDataButton.Size = new System.Drawing.Size(75, 23);
			this.showDataButton.TabIndex = 9;
			this.showDataButton.Text = "Show Data";
			this.showDataButton.UseVisualStyleBackColor = true;
			this.showDataButton.Click += new System.EventHandler(this.showDataButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(241, 214);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(75, 23);
			this.clearButton.TabIndex = 10;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(355, 214);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 11;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// dataErrorProvider
			// 
			this.dataErrorProvider.ContainerControl = this;
			// 
			// dataListView
			// 
			this.dataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.empNumColumnHeader,
            this.firstNameColumnHeader,
            this.lastNameColumnHeader});
			this.dataListView.GridLines = true;
			this.dataListView.Location = new System.Drawing.Point(563, 90);
			this.dataListView.Name = "dataListView";
			this.dataListView.Size = new System.Drawing.Size(348, 147);
			this.dataListView.TabIndex = 12;
			this.dataListView.UseCompatibleStateImageBehavior = false;
			this.dataListView.View = System.Windows.Forms.View.Details;
			this.dataListView.Visible = false;
			this.dataListView.SelectedIndexChanged += new System.EventHandler(this.dataListView_SelectedIndexChanged);
			// 
			// empNumColumnHeader
			// 
			this.empNumColumnHeader.Text = "Emp #";
			this.empNumColumnHeader.Width = 115;
			// 
			// firstNameColumnHeader
			// 
			this.firstNameColumnHeader.Text = "Emp 1st Name";
			this.firstNameColumnHeader.Width = 115;
			// 
			// lastNameColumnHeader
			// 
			this.lastNameColumnHeader.Text = "Emp Last Name";
			this.lastNameColumnHeader.Width = 120;
			// 
			// dataValidationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(983, 312);
			this.Controls.Add(this.dataListView);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.showDataButton);
			this.Controls.Add(this.enterNumberTextBox);
			this.Controls.Add(this.enterLastNameTextBox);
			this.Controls.Add(this.enterFirstNameTextBox);
			this.Controls.Add(this.enterLastNameLabel);
			this.Controls.Add(this.enterFirstNameLabel);
			this.Controls.Add(this.enterNumberLabel);
			this.Controls.Add(this.dataEntryLabel);
			this.Name = "dataValidationForm";
			this.Text = "Data Entry";
			((System.ComponentModel.ISupportInitialize)(this.dataErrorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label dataEntryLabel;
		private System.Windows.Forms.Label enterNumberLabel;
		private System.Windows.Forms.Label enterFirstNameLabel;
		private System.Windows.Forms.Label enterLastNameLabel;
		private System.Windows.Forms.TextBox enterFirstNameTextBox;
		private System.Windows.Forms.TextBox enterLastNameTextBox;
		private System.Windows.Forms.TextBox enterNumberTextBox;
		private System.Windows.Forms.Button showDataButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.ErrorProvider dataErrorProvider;
		private System.Windows.Forms.ListView dataListView;
		private System.Windows.Forms.ColumnHeader empNumColumnHeader;
		private System.Windows.Forms.ColumnHeader firstNameColumnHeader;
		private System.Windows.Forms.ColumnHeader lastNameColumnHeader;
	}
}

