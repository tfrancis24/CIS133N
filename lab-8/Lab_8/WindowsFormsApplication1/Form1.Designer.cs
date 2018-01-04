namespace WindowsFormsApplication1
{
	partial class storeForm
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
			this.fileMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.selectionGroupBox = new System.Windows.Forms.GroupBox();
			this.bookSelectionComboBox = new System.Windows.Forms.ComboBox();
			this.bookListBox = new System.Windows.Forms.ListBox();
			this.stockLabel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureGroupBox = new System.Windows.Forms.GroupBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.itemPriceLabel = new System.Windows.Forms.Label();
			this.bookPriceLabel = new System.Windows.Forms.Label();
			this.cartGroupBox = new System.Windows.Forms.GroupBox();
			this.shippingCostLabel = new System.Windows.Forms.Label();
			this.totalShippingLabel = new System.Windows.Forms.Label();
			this.clearCartButton = new System.Windows.Forms.Button();
			this.removeButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.cartComboBox = new System.Windows.Forms.ComboBox();
			this.processGroupBox = new System.Windows.Forms.GroupBox();
			this.exitButton = new System.Windows.Forms.Button();
			this.clearAllButton = new System.Windows.Forms.Button();
			this.finalizeButton = new System.Windows.Forms.Button();
			this.bookListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.bookColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.priceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.totalShippingLabel2 = new System.Windows.Forms.Label();
			this.totalCostLabel = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.fileMenuStrip.SuspendLayout();
			this.selectionGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pictureGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.cartGroupBox.SuspendLayout();
			this.processGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// fileMenuStrip
			// 
			this.fileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.fileMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.fileMenuStrip.Name = "fileMenuStrip";
			this.fileMenuStrip.Size = new System.Drawing.Size(1134, 24);
			this.fileMenuStrip.TabIndex = 0;
			this.fileMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem,
            this.exotToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// clearAllToolStripMenuItem
			// 
			this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
			this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.clearAllToolStripMenuItem.Text = "Clear All";
			this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
			// 
			// exotToolStripMenuItem
			// 
			this.exotToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.exotToolStripMenuItem.Name = "exotToolStripMenuItem";
			this.exotToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.exotToolStripMenuItem.Text = "Exit";
			this.exotToolStripMenuItem.Click += new System.EventHandler(this.exotToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(381, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(312, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "Discount Book Place";
			// 
			// selectionGroupBox
			// 
			this.selectionGroupBox.Controls.Add(this.bookSelectionComboBox);
			this.selectionGroupBox.Controls.Add(this.bookListBox);
			this.selectionGroupBox.Controls.Add(this.stockLabel);
			this.selectionGroupBox.Location = new System.Drawing.Point(29, 90);
			this.selectionGroupBox.Name = "selectionGroupBox";
			this.selectionGroupBox.Size = new System.Drawing.Size(200, 350);
			this.selectionGroupBox.TabIndex = 2;
			this.selectionGroupBox.TabStop = false;
			this.selectionGroupBox.Text = "Book Selection";
			// 
			// bookSelectionComboBox
			// 
			this.bookSelectionComboBox.FormattingEnabled = true;
			this.bookSelectionComboBox.Location = new System.Drawing.Point(34, 46);
			this.bookSelectionComboBox.Name = "bookSelectionComboBox";
			this.bookSelectionComboBox.Size = new System.Drawing.Size(121, 21);
			this.bookSelectionComboBox.TabIndex = 4;
			this.bookSelectionComboBox.Text = "Book Catagories";
			this.toolTip1.SetToolTip(this.bookSelectionComboBox, "Select a category");
			this.bookSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.bookSelectionComboBox_SelectedIndexChanged);
			// 
			// bookListBox
			// 
			this.bookListBox.FormattingEnabled = true;
			this.bookListBox.Location = new System.Drawing.Point(34, 195);
			this.bookListBox.Name = "bookListBox";
			this.bookListBox.Size = new System.Drawing.Size(120, 95);
			this.bookListBox.TabIndex = 3;
			this.toolTip1.SetToolTip(this.bookListBox, "Our inventory of books");
			this.bookListBox.SelectedIndexChanged += new System.EventHandler(this.bookListBox_SelectedIndexChanged);
			this.bookListBox.DoubleClick += new System.EventHandler(this.bookListBox_DoubleClick);
			// 
			// stockLabel
			// 
			this.stockLabel.AutoSize = true;
			this.stockLabel.Location = new System.Drawing.Point(31, 158);
			this.stockLabel.Name = "stockLabel";
			this.stockLabel.Size = new System.Drawing.Size(77, 13);
			this.stockLabel.TabIndex = 3;
			this.stockLabel.Text = "Books in stock";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(61, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 107);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// pictureGroupBox
			// 
			this.pictureGroupBox.Controls.Add(this.pictureBox2);
			this.pictureGroupBox.Controls.Add(this.itemPriceLabel);
			this.pictureGroupBox.Controls.Add(this.bookPriceLabel);
			this.pictureGroupBox.Controls.Add(this.pictureBox1);
			this.pictureGroupBox.Location = new System.Drawing.Point(291, 90);
			this.pictureGroupBox.Name = "pictureGroupBox";
			this.pictureGroupBox.Size = new System.Drawing.Size(277, 350);
			this.pictureGroupBox.TabIndex = 4;
			this.pictureGroupBox.TabStop = false;
			this.pictureGroupBox.Text = "Selected Books";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(31, 158);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(209, 132);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// itemPriceLabel
			// 
			this.itemPriceLabel.AutoSize = true;
			this.itemPriceLabel.Location = new System.Drawing.Point(176, 310);
			this.itemPriceLabel.Name = "itemPriceLabel";
			this.itemPriceLabel.Size = new System.Drawing.Size(0, 13);
			this.itemPriceLabel.TabIndex = 5;
			// 
			// bookPriceLabel
			// 
			this.bookPriceLabel.AutoSize = true;
			this.bookPriceLabel.Location = new System.Drawing.Point(37, 310);
			this.bookPriceLabel.Name = "bookPriceLabel";
			this.bookPriceLabel.Size = new System.Drawing.Size(58, 13);
			this.bookPriceLabel.TabIndex = 4;
			this.bookPriceLabel.Text = "Book price";
			// 
			// cartGroupBox
			// 
			this.cartGroupBox.Controls.Add(this.shippingCostLabel);
			this.cartGroupBox.Controls.Add(this.totalShippingLabel);
			this.cartGroupBox.Controls.Add(this.clearCartButton);
			this.cartGroupBox.Controls.Add(this.removeButton);
			this.cartGroupBox.Controls.Add(this.addButton);
			this.cartGroupBox.Controls.Add(this.cartComboBox);
			this.cartGroupBox.Location = new System.Drawing.Point(587, 90);
			this.cartGroupBox.Name = "cartGroupBox";
			this.cartGroupBox.Size = new System.Drawing.Size(175, 211);
			this.cartGroupBox.TabIndex = 5;
			this.cartGroupBox.TabStop = false;
			this.cartGroupBox.Text = "Shopping Cart";
			// 
			// shippingCostLabel
			// 
			this.shippingCostLabel.AutoSize = true;
			this.shippingCostLabel.Location = new System.Drawing.Point(113, 174);
			this.shippingCostLabel.Name = "shippingCostLabel";
			this.shippingCostLabel.Size = new System.Drawing.Size(13, 13);
			this.shippingCostLabel.TabIndex = 5;
			this.shippingCostLabel.Text = "0";
			this.shippingCostLabel.Click += new System.EventHandler(this.shippingCostLabel_Click);
			// 
			// totalShippingLabel
			// 
			this.totalShippingLabel.AutoSize = true;
			this.totalShippingLabel.Location = new System.Drawing.Point(24, 174);
			this.totalShippingLabel.Name = "totalShippingLabel";
			this.totalShippingLabel.Size = new System.Drawing.Size(55, 13);
			this.totalShippingLabel.TabIndex = 4;
			this.totalShippingLabel.Text = "Total Cost";
			// 
			// clearCartButton
			// 
			this.clearCartButton.Location = new System.Drawing.Point(27, 134);
			this.clearCartButton.Name = "clearCartButton";
			this.clearCartButton.Size = new System.Drawing.Size(121, 23);
			this.clearCartButton.TabIndex = 3;
			this.clearCartButton.Text = "Clear Shopping Cart";
			this.toolTip1.SetToolTip(this.clearCartButton, "Clear the entire cart");
			this.clearCartButton.UseVisualStyleBackColor = true;
			this.clearCartButton.Click += new System.EventHandler(this.clearCartButton_Click);
			// 
			// removeButton
			// 
			this.removeButton.Location = new System.Drawing.Point(27, 105);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(121, 23);
			this.removeButton.TabIndex = 2;
			this.removeButton.Text = "Remove";
			this.toolTip1.SetToolTip(this.removeButton, "Deletes the item from the cart");
			this.removeButton.UseVisualStyleBackColor = true;
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(27, 76);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(121, 23);
			this.addButton.TabIndex = 1;
			this.addButton.Text = "Add to shopping cart";
			this.toolTip1.SetToolTip(this.addButton, "Add to your cart");
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// cartComboBox
			// 
			this.cartComboBox.FormattingEnabled = true;
			this.cartComboBox.Location = new System.Drawing.Point(27, 37);
			this.cartComboBox.Name = "cartComboBox";
			this.cartComboBox.Size = new System.Drawing.Size(121, 21);
			this.cartComboBox.TabIndex = 0;
			this.cartComboBox.Text = "Thanks for shopping";
			this.cartComboBox.SelectedIndexChanged += new System.EventHandler(this.cartComboBox_SelectedIndexChanged);
			// 
			// processGroupBox
			// 
			this.processGroupBox.Controls.Add(this.exitButton);
			this.processGroupBox.Controls.Add(this.clearAllButton);
			this.processGroupBox.Controls.Add(this.finalizeButton);
			this.processGroupBox.Location = new System.Drawing.Point(587, 307);
			this.processGroupBox.Name = "processGroupBox";
			this.processGroupBox.Size = new System.Drawing.Size(175, 133);
			this.processGroupBox.TabIndex = 6;
			this.processGroupBox.TabStop = false;
			this.processGroupBox.Text = "Process";
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(38, 93);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(96, 23);
			this.exitButton.TabIndex = 2;
			this.exitButton.Text = "Exit";
			this.toolTip1.SetToolTip(this.exitButton, "Exit the program");
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// clearAllButton
			// 
			this.clearAllButton.Location = new System.Drawing.Point(38, 60);
			this.clearAllButton.Name = "clearAllButton";
			this.clearAllButton.Size = new System.Drawing.Size(96, 23);
			this.clearAllButton.TabIndex = 1;
			this.clearAllButton.Text = "Clear All";
			this.toolTip1.SetToolTip(this.clearAllButton, "Resets the application");
			this.clearAllButton.UseVisualStyleBackColor = true;
			this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
			// 
			// finalizeButton
			// 
			this.finalizeButton.Location = new System.Drawing.Point(38, 24);
			this.finalizeButton.Name = "finalizeButton";
			this.finalizeButton.Size = new System.Drawing.Size(96, 23);
			this.finalizeButton.TabIndex = 0;
			this.finalizeButton.Text = "Finalize the sales";
			this.toolTip1.SetToolTip(this.finalizeButton, "Print a receipt");
			this.finalizeButton.UseVisualStyleBackColor = true;
			this.finalizeButton.Click += new System.EventHandler(this.finalizeButton_Click);
			// 
			// bookListView
			// 
			this.bookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.bookColumn,
            this.priceColumn});
			this.bookListView.GridLines = true;
			this.bookListView.Location = new System.Drawing.Point(855, 100);
			this.bookListView.Name = "bookListView";
			this.bookListView.Size = new System.Drawing.Size(243, 228);
			this.bookListView.TabIndex = 7;
			this.toolTip1.SetToolTip(this.bookListView, "Receipt");
			this.bookListView.UseCompatibleStateImageBehavior = false;
			this.bookListView.View = System.Windows.Forms.View.Details;
			this.bookListView.SelectedIndexChanged += new System.EventHandler(this.bookListView_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Width = 0;
			// 
			// bookColumn
			// 
			this.bookColumn.Text = "Book Name";
			this.bookColumn.Width = 158;
			// 
			// priceColumn
			// 
			this.priceColumn.Text = "Book Price";
			this.priceColumn.Width = 186;
			// 
			// totalShippingLabel2
			// 
			this.totalShippingLabel2.AutoSize = true;
			this.totalShippingLabel2.Location = new System.Drawing.Point(852, 331);
			this.totalShippingLabel2.Name = "totalShippingLabel2";
			this.totalShippingLabel2.Size = new System.Drawing.Size(55, 13);
			this.totalShippingLabel2.TabIndex = 8;
			this.totalShippingLabel2.Text = "Total Cost";
			this.totalShippingLabel2.Visible = false;
			// 
			// totalCostLabel
			// 
			this.totalCostLabel.AutoSize = true;
			this.totalCostLabel.Location = new System.Drawing.Point(976, 331);
			this.totalCostLabel.Name = "totalCostLabel";
			this.totalCostLabel.Size = new System.Drawing.Size(0, 13);
			this.totalCostLabel.TabIndex = 6;
			this.totalCostLabel.Visible = false;
			// 
			// storeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1134, 464);
			this.Controls.Add(this.totalCostLabel);
			this.Controls.Add(this.totalShippingLabel2);
			this.Controls.Add(this.bookListView);
			this.Controls.Add(this.processGroupBox);
			this.Controls.Add(this.cartGroupBox);
			this.Controls.Add(this.pictureGroupBox);
			this.Controls.Add(this.selectionGroupBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.fileMenuStrip);
			this.MainMenuStrip = this.fileMenuStrip;
			this.Name = "storeForm";
			this.Text = "Tim\'s Bookstore";
			this.Load += new System.EventHandler(this.storeForm_Load);
			this.fileMenuStrip.ResumeLayout(false);
			this.fileMenuStrip.PerformLayout();
			this.selectionGroupBox.ResumeLayout(false);
			this.selectionGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pictureGroupBox.ResumeLayout(false);
			this.pictureGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.cartGroupBox.ResumeLayout(false);
			this.cartGroupBox.PerformLayout();
			this.processGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip fileMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox selectionGroupBox;
		private System.Windows.Forms.ComboBox bookSelectionComboBox;
		private System.Windows.Forms.ListBox bookListBox;
		private System.Windows.Forms.Label stockLabel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox pictureGroupBox;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label itemPriceLabel;
		private System.Windows.Forms.Label bookPriceLabel;
		private System.Windows.Forms.GroupBox cartGroupBox;
		private System.Windows.Forms.GroupBox processGroupBox;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button clearAllButton;
		private System.Windows.Forms.Button finalizeButton;
		private System.Windows.Forms.Button clearCartButton;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.ComboBox cartComboBox;
		private System.Windows.Forms.Label shippingCostLabel;
		private System.Windows.Forms.Label totalShippingLabel;
		private System.Windows.Forms.ListView bookListView;
		private System.Windows.Forms.ColumnHeader bookColumn;
		private System.Windows.Forms.ColumnHeader priceColumn;
		private System.Windows.Forms.Label totalShippingLabel2;
		private System.Windows.Forms.Label totalCostLabel;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exotToolStripMenuItem;
	}
}

