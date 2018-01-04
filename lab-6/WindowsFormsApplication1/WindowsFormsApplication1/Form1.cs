using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class dataValidationForm : Form
	{
		public dataValidationForm()
		{
			InitializeComponent();
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			//Exits program when clicked.
			Application.Exit();
		}

		private void enterNumberTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void enterNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			//Allows users to only enter only numbers into text box, otherwise an error provider will show up.
			if (e.KeyChar >= 48 && e.KeyChar <= 57)
			{
				dataErrorProvider.SetError(enterNumberTextBox, "");
			}
			else
			{
				e.Handled = e.KeyChar != (char)Keys.Back;
				dataErrorProvider.SetError(enterNumberTextBox, "Enter numbers only");
			}
		}

		private void enterFirstNameTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void enterFirstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			//Allows users to only enter only lower case into text box, otherwise an error provider will show up.
			if (e.KeyChar >= 97 && e.KeyChar <= 122)
			{
				dataErrorProvider.SetError(enterFirstNameTextBox, "");
			}
			else
			{
				e.Handled = e.KeyChar != (char)Keys.Back;
				dataErrorProvider.SetError(enterFirstNameTextBox, "Must be lower case");
			}
		}

		private void enterLastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			//Allows users to only enter only upper case into text box, otherwise an error provider will show up.
			if (e.KeyChar >= 65 && e.KeyChar <= 90)
			{
				dataErrorProvider.SetError(enterLastNameTextBox, "");
			}
			else
			{
				e.Handled = e.KeyChar != (char)Keys.Back;
				dataErrorProvider.SetError(enterLastNameTextBox, "Must be upper case");
			}
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			//Clears text boxes and list view; makes list view invisible.
			enterNumberTextBox.Text = null;
			enterLastNameTextBox.Text = null;
			enterFirstNameTextBox.Text = null;
			dataListView.Visible = false;
			dataListView.Items.Clear();
		}

		private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			
		}

		private void dataListView_SelectedIndexChanged(object sender, EventArgs e)
		{


		}

		private void showDataButton_Click(object sender, EventArgs e)
		{
			//Makes the list view visible and adds content to the listview.
			dataListView.Visible = true;
			ListViewItem list = new ListViewItem(enterNumberTextBox.Text);
			list.SubItems.Add(enterNumberTextBox.Text);
			list.SubItems.Add(enterFirstNameTextBox.Text);
			list.SubItems.Add(enterLastNameTextBox.Text);
			dataListView.Items.Add(list);
		}
	}
}
