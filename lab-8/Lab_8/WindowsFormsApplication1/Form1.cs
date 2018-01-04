using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Tim Francis

namespace WindowsFormsApplication1
{
	public partial class storeForm : Form
	{
		public storeForm()
		{
			InitializeComponent();
			
		}

		public string bookName { get; set; }

		public double bookPrice { get; set; }

		public double totalPrice { get; set; }


		private void exitButton_Click(object sender, EventArgs e)
		{
			//Exits the program
			Application.Exit();
		}

		private void storeForm_Load(object sender, EventArgs e)
		{
			//Visible property to false
			bookListView.Visible = false;
			
			//Populating the book category combo box.
			bookSelectionComboBox.Items.Add("Programming");
			bookSelectionComboBox.Items.Add("Networking");
			bookSelectionComboBox.Items.Add("Web");
		}

		private void bookSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Populating selected index with actions for the category combo box.
			switch (this.bookSelectionComboBox.SelectedIndex)
			//Adding values to each of the books and populating the 1st picture box.
			{
				case 0:
					pictureBox1.Image = Image.FromFile("programmingBanner.png");
					pictureBox2.Image = null;
					bookListBox.Items.Clear();
					bookListBox.Items.Add("VISUAL BASIC");
					bookListBox.Items.Add("JAVA");
					bookListBox.Items.Add("C#");
					break;
				case 1:
					pictureBox1.Image = Image.FromFile("netbanner.jpg");
					pictureBox2.Image = null;
					bookListBox.Items.Clear();
					bookListBox.Items.Add("LAN Networks");
					bookListBox.Items.Add("WINDOWS Networks");
					bookListBox.Items.Add("More about networking");
					break;
				case 2:
					pictureBox1.Image = Image.FromFile("webp.jpg");
					pictureBox2.Image = null;
					bookListBox.Items.Clear();
					bookListBox.Items.Add("WEB PROGRAMMING");
					bookListBox.Items.Add("JAVA SCRIPT");
					bookListBox.Items.Add("ASP");
					break;
			}
		}

		

		private void removeButton_Click(object sender, EventArgs e)
		{
			//Try catch if there is nothing to remove.
			try
			{
				//Removes item and clears combo box text
				cartComboBox.Items.Remove(cartComboBox.SelectedItem);
				cartComboBox.Text = "Thanks for shopping";
				
				//Math
				totalPrice = totalPrice - bookPrice;
				shippingCostLabel.Text = totalPrice.ToString("C");
				totalCostLabel.Text = totalPrice.ToString("C");

				//List view removal
				
				
				
			}
			catch
			{
				MessageBox.Show("Nothing to remove", "Warning");
			}
		}

		private void bookListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			//If programming books are selected, list box fills up with the following.
			
			if (bookSelectionComboBox.SelectedIndex.Equals(0))
			{
				switch (bookListBox.SelectedIndex)
				{
					case 0:
						pictureBox2.Image = Image.FromFile("mike.jpg");
						itemPriceLabel.Text = "$55.00";
						bookPrice = 55.00;
						break;
					case 1:
							pictureBox2.Image = Image.FromFile("java.jpg");
							itemPriceLabel.Text = "$45.00";
							bookPrice = 45.00;
						break;
					case 2:
						pictureBox2.Image = Image.FromFile("c#.jpg");
						itemPriceLabel.Text = "$35.00";
						bookPrice = 35.00;
						break;
				}

			}

			//If networking is selected, list box fills up with the following.
			else if (bookSelectionComboBox.SelectedIndex.Equals(1))
			{				
				switch (bookListBox.SelectedIndex)
				{
					case 0:
						pictureBox2.Image = Image.FromFile("lan.jpg");
						itemPriceLabel.Text = "$35.00";
						bookPrice = 35.00;
						break;

					case 1:
						pictureBox2.Image = Image.FromFile("win.jpg");
						itemPriceLabel.Text = "$45.00";
						bookPrice = 45.00;
						break;
					case 2:
						pictureBox2.Image = Image.FromFile("morenet.jpg");
						itemPriceLabel.Text = "$40.00";
						bookPrice = 40.00;
						break;
				}
			}

			//If web is selected, list box fills up with the following.
			else if (bookSelectionComboBox.SelectedIndex.Equals(2))
			{
				switch (bookListBox.SelectedIndex)
				{
					case 0:
						pictureBox2.Image = Image.FromFile("webtb.jpg");
						itemPriceLabel.Text = "$95.00";
						bookPrice = 95.00;
						break;

					case 1:
						pictureBox2.Image = Image.FromFile("js.jpg");
						itemPriceLabel.Text = "$50.00";
						bookPrice = 50.00;
						break;
					case 2:
						pictureBox2.Image = Image.FromFile("asp.jpg");
						itemPriceLabel.Text = "$35.00";
						bookPrice = 35.00;
						break;
				}

			}

		}

		private void addButton_Click(object sender, EventArgs e)
		{
			//Try catch if there is nothing to add.
			try
			{
				//Adds selected item to combo box and checks for duplicate entries.
				if (cartComboBox.Items.Contains(bookListBox.SelectedItem))
				{
					MessageBox.Show("You can not have duplicate entries", "Warning");
				}
				else
				{
					cartComboBox.Items.Add(bookListBox.SelectedItem);
					bookListBox.Visible = true;
					ListViewItem list = new ListViewItem();
					list.SubItems.Add(bookListBox.SelectedItem.ToString());
					list.SubItems.Add(itemPriceLabel.Text);
					bookListView.Items.Add(list);

					totalPrice = totalPrice + bookPrice;
					shippingCostLabel.Text = totalPrice.ToString("C");
					totalCostLabel.Text = totalPrice.ToString("C");
				}
				
			}
			catch
			{				
				MessageBox.Show("Nothing to add", "Warning");
			}
			
		}

		private void cartComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void finalizeButton_Click(object sender, EventArgs e)
		{

			if (cartComboBox.Items.Count == 0)
			{
				//Counts the combo box to see if there are no items in it.
				MessageBox.Show("Nothing in basket", "Warning");
			}

			else
			{
				//Ask for confirmation
				DialogResult dialogResult = MessageBox.Show("If you continue, the sales will be final", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
				if (dialogResult == DialogResult.Yes)
				{
					//Making properties visible
					bookListView.Visible = true;
					totalShippingLabel2.Visible = true;
					totalCostLabel.Visible = true;
				}
			}
		}

		private void clearCartButton_Click(object sender, EventArgs e)
		{
			//Clearing variables
			cartComboBox.Items.Clear();
			shippingCostLabel.Text = "0";
			totalPrice = 0;

			//Making sure list view is blank since items are added to it regardless of it being visible or not
			bookListView.Items.Clear();
			
			
			
			cartComboBox.Text = "Thanks for shopping";
			totalCostLabel.Text = "0";
		}

		private void bookListBox_DoubleClick(object sender, EventArgs e)
		{
			//Adds item if the user double clicks
			addButton.PerformClick();
		}

		private void shippingCostLabel_Click(object sender, EventArgs e)
		{

		}

		private void clearAllButton_Click(object sender, EventArgs e)
		{
			//Clears prices and sets objects to non visible or false.
			bookListView.Visible = false;
			totalShippingLabel2.Visible = false;
			totalCostLabel.Visible = false;
			pictureBox1.Image = null;
			pictureBox2.Image = null;

			//Clear list view and cart
			cartComboBox.Items.Clear();
			//bookListView.Items.Remove(bookListView.Items);
			bookListView.Items.Clear();

			//Resetting ints
			totalPrice = 0;
			bookPrice = 0;

			//adjusting labels
			shippingCostLabel.Text = "0";
			totalCostLabel.Text = "0";
			itemPriceLabel.Text = "0";
		}

		private void exotToolStripMenuItem_Click(object sender, EventArgs e)
		{
			exitButton.PerformClick();
		}

		private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			clearAllButton.PerformClick();
		}

		private void bookListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	}
}

