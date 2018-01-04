namespace WindowsFormsApplication1
{
	partial class petShopForm
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewShoppingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.catToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.horsesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.monkeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.owlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sortItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addButton = new System.Windows.Forms.Button();
			this.rmButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.searchButton = new System.Windows.Forms.Button();
			this.sortButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.userInputLabel = new System.Windows.Forms.Label();
			this.addItemLabel = new System.Windows.Forms.Label();
			this.basketListBox = new System.Windows.Forms.ListBox();
			this.petPictureBox = new System.Windows.Forms.PictureBox();
			this.basketLabel = new System.Windows.Forms.Label();
			this.itemComboBox = new System.Windows.Forms.ComboBox();
			this.titleLabel = new System.Windows.Forms.Label();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewShoppingListToolStripMenuItem,
            this.utilitiesToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(702, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// backgroundColorToolStripMenuItem
			// 
			this.backgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.resetToolStripMenuItem});
			this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
			this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.backgroundColorToolStripMenuItem.Text = "Background Color";
			// 
			// redToolStripMenuItem
			// 
			this.redToolStripMenuItem.Name = "redToolStripMenuItem";
			this.redToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.redToolStripMenuItem.Text = "Red";
			this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
			// 
			// greenToolStripMenuItem
			// 
			this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
			this.greenToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.greenToolStripMenuItem.Text = "Green";
			this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
			// 
			// blueToolStripMenuItem
			// 
			this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
			this.blueToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.blueToolStripMenuItem.Text = "Blue";
			this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
			// 
			// resetToolStripMenuItem
			// 
			this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
			this.resetToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.resetToolStripMenuItem.Text = "Reset";
			this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.printToolStripMenuItem.Text = "Print";
			this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// viewShoppingListToolStripMenuItem
			// 
			this.viewShoppingListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catToolStripMenuItem,
            this.dogToolStripMenuItem,
            this.fishToolStripMenuItem,
            this.horsesToolStripMenuItem,
            this.monkeyToolStripMenuItem,
            this.owlToolStripMenuItem});
			this.viewShoppingListToolStripMenuItem.Name = "viewShoppingListToolStripMenuItem";
			this.viewShoppingListToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
			this.viewShoppingListToolStripMenuItem.Text = "View Shopping List";
			// 
			// catToolStripMenuItem
			// 
			this.catToolStripMenuItem.Name = "catToolStripMenuItem";
			this.catToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.catToolStripMenuItem.Text = "Cat";
			// 
			// dogToolStripMenuItem
			// 
			this.dogToolStripMenuItem.Name = "dogToolStripMenuItem";
			this.dogToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.dogToolStripMenuItem.Text = "Dog";
			// 
			// fishToolStripMenuItem
			// 
			this.fishToolStripMenuItem.Name = "fishToolStripMenuItem";
			this.fishToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.fishToolStripMenuItem.Text = "Fish";
			// 
			// horsesToolStripMenuItem
			// 
			this.horsesToolStripMenuItem.Name = "horsesToolStripMenuItem";
			this.horsesToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.horsesToolStripMenuItem.Text = "Horses";
			// 
			// monkeyToolStripMenuItem
			// 
			this.monkeyToolStripMenuItem.Name = "monkeyToolStripMenuItem";
			this.monkeyToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.monkeyToolStripMenuItem.Text = "Monkey";
			// 
			// owlToolStripMenuItem
			// 
			this.owlToolStripMenuItem.Name = "owlToolStripMenuItem";
			this.owlToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.owlToolStripMenuItem.Text = "Owl";
			// 
			// utilitiesToolStripMenuItem
			// 
			this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortItemsToolStripMenuItem,
            this.clearToolStripMenuItem});
			this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
			this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.utilitiesToolStripMenuItem.Text = "Utilities";
			// 
			// sortItemsToolStripMenuItem
			// 
			this.sortItemsToolStripMenuItem.Name = "sortItemsToolStripMenuItem";
			this.sortItemsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.sortItemsToolStripMenuItem.Text = "Sort Items";
			this.sortItemsToolStripMenuItem.Click += new System.EventHandler(this.sortItemsToolStripMenuItem_Click);
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.clearToolStripMenuItem.Text = "Clear";
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(78, 337);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 1;
			this.addButton.Text = "Add to list";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// rmButton
			// 
			this.rmButton.Location = new System.Drawing.Point(159, 337);
			this.rmButton.Name = "rmButton";
			this.rmButton.Size = new System.Drawing.Size(75, 23);
			this.rmButton.TabIndex = 2;
			this.rmButton.Text = "Remove";
			this.rmButton.UseVisualStyleBackColor = true;
			this.rmButton.Click += new System.EventHandler(this.rmButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(240, 337);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(75, 23);
			this.clearButton.TabIndex = 3;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(321, 337);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 4;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// sortButton
			// 
			this.sortButton.Location = new System.Drawing.Point(402, 337);
			this.sortButton.Name = "sortButton";
			this.sortButton.Size = new System.Drawing.Size(75, 23);
			this.sortButton.TabIndex = 5;
			this.sortButton.Text = "Sort Items";
			this.sortButton.UseVisualStyleBackColor = true;
			this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(483, 337);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 6;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// inputTextBox
			// 
			this.inputTextBox.Location = new System.Drawing.Point(219, 103);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(120, 20);
			this.inputTextBox.TabIndex = 7;
			// 
			// userInputLabel
			// 
			this.userInputLabel.Location = new System.Drawing.Point(75, 103);
			this.userInputLabel.Name = "userInputLabel";
			this.userInputLabel.Size = new System.Drawing.Size(137, 45);
			this.userInputLabel.TabIndex = 8;
			this.userInputLabel.Text = "Enter the item to be  added to the shopping list:";
			// 
			// addItemLabel
			// 
			this.addItemLabel.Location = new System.Drawing.Point(75, 163);
			this.addItemLabel.Name = "addItemLabel";
			this.addItemLabel.Size = new System.Drawing.Size(100, 43);
			this.addItemLabel.TabIndex = 9;
			this.addItemLabel.Text = "View shopping list and ADD item to your basket:";
			// 
			// basketListBox
			// 
			this.basketListBox.FormattingEnabled = true;
			this.basketListBox.Location = new System.Drawing.Point(495, 128);
			this.basketListBox.Name = "basketListBox";
			this.basketListBox.Size = new System.Drawing.Size(120, 95);
			this.basketListBox.TabIndex = 10;
			this.basketListBox.SelectedIndexChanged += new System.EventHandler(this.basketListBox_SelectedIndexChanged);
			// 
			// petPictureBox
			// 
			this.petPictureBox.Location = new System.Drawing.Point(219, 205);
			this.petPictureBox.Name = "petPictureBox";
			this.petPictureBox.Size = new System.Drawing.Size(120, 79);
			this.petPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.petPictureBox.TabIndex = 11;
			this.petPictureBox.TabStop = false;
			this.petPictureBox.Click += new System.EventHandler(this.petPictureBox_Click);
			// 
			// basketLabel
			// 
			this.basketLabel.AutoSize = true;
			this.basketLabel.Location = new System.Drawing.Point(534, 103);
			this.basketLabel.Name = "basketLabel";
			this.basketLabel.Size = new System.Drawing.Size(40, 13);
			this.basketLabel.TabIndex = 12;
			this.basketLabel.Text = "Basket";
			// 
			// itemComboBox
			// 
			this.itemComboBox.FormattingEnabled = true;
			this.itemComboBox.Location = new System.Drawing.Point(218, 163);
			this.itemComboBox.Name = "itemComboBox";
			this.itemComboBox.Size = new System.Drawing.Size(121, 21);
			this.itemComboBox.TabIndex = 13;
			this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.Location = new System.Drawing.Point(279, 42);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(117, 27);
			this.titleLabel.TabIndex = 14;
			this.titleLabel.Text = "Pet Shop";
			// 
			// petShopForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(702, 394);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.itemComboBox);
			this.Controls.Add(this.basketLabel);
			this.Controls.Add(this.petPictureBox);
			this.Controls.Add(this.basketListBox);
			this.Controls.Add(this.addItemLabel);
			this.Controls.Add(this.userInputLabel);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.sortButton);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.rmButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.menuStrip);
			this.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "petShopForm";
			this.Text = "Pet Shop";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewShoppingListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem catToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dogToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fishToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem horsesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem monkeyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem owlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sortItemsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button rmButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Button sortButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Label userInputLabel;
		private System.Windows.Forms.Label addItemLabel;
		private System.Windows.Forms.ListBox basketListBox;
		private System.Windows.Forms.PictureBox petPictureBox;
		private System.Windows.Forms.Label basketLabel;
		private System.Windows.Forms.ComboBox itemComboBox;
		private System.Windows.Forms.Label titleLabel;
	}
}

