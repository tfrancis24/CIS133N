using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/*
    Project      Lab 5
    Programmer   Tim Francis
    Date         10/29/15
                
    	          Virtual pet shop and basket
*/


namespace WindowsFormsApplication1
{
	public partial class petShopForm : Form
	{
		public petShopForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//Adds items to the combo box.
			itemComboBox.Items.Add("CAT");
			itemComboBox.Items.Add("DOG");
			itemComboBox.Items.Add("FISH");
			itemComboBox.Items.Add("HORSES");
			itemComboBox.Items.Add("MONKEY");
			itemComboBox.Items.Add("OWL");

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void redToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Sets background color to Red
			this.BackColor = System.Drawing.Color.Red;
		}

		private void greenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Sets background color to Green
			this.BackColor = System.Drawing.Color.Green;
		}

		private void blueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Sets background color to Blue
			this.BackColor = System.Drawing.Color.Blue;
		}

		private void resetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Resets background color
			this.BackColor = SystemColors.Control;
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			//Exits program.
			System.Environment.Exit(0);
		}

		private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Information for each of the selected indexes. When clicked, will show the appropriate image and add the item to the combo box.
			try
			{
				switch (this.itemComboBox.Text)
				{

					case "CAT":
						petPictureBox.Image = Image.FromFile("cat.jpg");
						basketListBox.Items.Add("Cat $50");
						break;
					case "DOG":
						petPictureBox.Image = Image.FromFile("dog.jpg");
						basketListBox.Items.Add("Dog $100");
						break;
					case "FISH":
						petPictureBox.Image = Image.FromFile("fish.jpg");
						basketListBox.Items.Add("Fish $20");
						break;
					case "HORSES":
						petPictureBox.Image = Image.FromFile("horses.jpg");
						basketListBox.Items.Add("Horses $1000");
						break;
					case "MONKEY":
						petPictureBox.Image = Image.FromFile("monkey.jpg");
						basketListBox.Items.Add("Monkey $60");
						break;
					case "OWL":
						petPictureBox.Image = Image.FromFile("owl.jpg");
						basketListBox.Items.Add("Owl $100");
						break;
					default:
						MessageBox.Show("Sorry, the image/price is not available for this item");
						petPictureBox.Image = null;
						break;
				}

			}
			catch
			{
				MessageBox.Show("Sorry, the image/price is not available for this item");
				petPictureBox.Image = null;
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Calls exit button.
			exitButton.PerformClick();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			try
			{
				//Adds items to combo box.
				if (itemComboBox.Items.Contains(inputTextBox.Text))
				{
					MessageBox.Show("Item is already in the combobox", "Warning");
				}
				else
				{
					inputTextBox.CharacterCasing = CharacterCasing.Upper;
					itemComboBox.Items.Insert(6, inputTextBox.Text);
				}
			}
			catch
			{
				MessageBox.Show("Error");
			}
		}

		private void rmButton_Click(object sender, EventArgs e)
		{
			//Will remove selected item from the combo box and clear the picture box.
			itemComboBox.Items.Remove(itemComboBox.SelectedItem);
			petPictureBox.Image = null;
		}

		private void printToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Error msg
			MessageBox.Show("Not available for this program.");
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			//Clears list box and resets pic  box.
			basketListBox.Items.Clear();
			petPictureBox.Image = null;
		}

		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			clearButton.PerformClick();
		}

		private void sortButton_Click(object sender, EventArgs e)
		{
			//Sorts items in the list box alphabetically. 
			basketListBox.Sorted = true;
		}

		private void sortItemsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			sortButton.PerformClick();
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			string inputResponse = null;
			inputResponse = Interaction.InputBox
				 ("Enter the shopping item, you need to search", "Searching items");
			string myResult = inputResponse.ToUpper();


			if (itemComboBox.Items.Contains(myResult))
			{
				
				MessageBox.Show("Item found " + inputResponse, "Found it!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("Item not found " + inputResponse, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void petPictureBox_Click(object sender, EventArgs e)
		{

		}

		private void basketListBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
