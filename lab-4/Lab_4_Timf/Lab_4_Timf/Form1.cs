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

//Tim Francis
//Lab 4
//Vacation App

namespace Lab_4_Timf
{
	public partial class stateForm : Form
	{
		public stateForm()
		{
			//Here I make two controls, state group box and masked text box invisible on form load.
			InitializeComponent();
			stateGroupBox.Visible = false;
			maskedTextBox1.Visible = false;

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{			/*Will promp user for confirmation of exiting the program, then exit if the user clicks the yes button from file menu.*/

			if (MessageBox.Show("Are you sure you want to exit?", "Question", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void stateGroupBox_Enter(object sender, EventArgs e)
		{
			
		}

		private void phoneCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			//If statementl; if check box is checked, then it makes text box visible and vice-versa.
			if (phoneCheckBox.CheckState == CheckState.Checked)
			{
				maskedTextBox1.Visible = true;
			}

			if (phoneCheckBox.CheckState == CheckState.Unchecked)
			{
				maskedTextBox1.Visible = false;
			}

		}

		private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			
		}

		private void OregonRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (OregonRadioButton.Checked == true)
			{
				//Setting background color, image, info and making group box and picture box visible again.
				stateGroupBox.Visible = true;
				statePictureBox.Visible = true;
				stateGroupBox.BackColor = System.Drawing.Color.Green;
				statePictureBox.Image = Image.FromFile("Oregon.bmp");
				toolTip1.SetToolTip(statePictureBox, "Scenic Mount Hood");
				stateNameLabel.Text = "Oregon";
				popInfoLabel.Text = "The state of Oregon has a population of about 2 million." + Constants.vbCrLf;
				climateInfoLabel.Text = "The State of Oregon has a mild climate.";
				nickInfoLabel.Text = "Beaver State";
			}
			
		}

		private void washingtonRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (washingtonRadioButton.Checked == true)
			{
				//Setting background color, image, info and making group box and picture box visible again.
				stateGroupBox.Visible = true;
				statePictureBox.Visible = true;
				stateGroupBox.BackColor = System.Drawing.Color.Blue;
				statePictureBox.Image = Image.FromFile("washington.bmp");
				toolTip1.SetToolTip(statePictureBox, "Scenic fountain with moutain in background");
				stateNameLabel.Text = "Washington";
				popInfoLabel.Text = "The state of Washington has a population of about 2 million.";
				climateInfoLabel.Text = "The State of Oregon has a medium-mild climate.";
				nickInfoLabel.Text = "Salmon State";
			}
			
		}

		private void caliRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (caliRadioButton.Checked == true)
			{
				//Setting background color, image, info and making group box and picture box visible again.
				stateGroupBox.Visible = true;
				statePictureBox.Visible = true;
				stateGroupBox.BackColor = System.Drawing.Color.Gold;
				statePictureBox.Image = Image.FromFile("california.bmp");
				toolTip1.SetToolTip(statePictureBox, "Scenic lighthouse overlooking the ocean");
				stateNameLabel.Text = "California";
				popInfoLabel.Text = "The state of California has a population of about 34 million.";
				climateInfoLabel.Text = "The State of California has a warm climate.";
				nickInfoLabel.Text = "Golden State";
			}
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			if (OregonRadioButton.Checked == true || caliRadioButton.Checked == true || washingtonRadioButton.Checked == true) 
			{
				//Clears input from user and makes controls like the group box and picture box invisible.
				OregonRadioButton.Checked = false;
				caliRadioButton.Checked = false;
				washingtonRadioButton.Checked = false;
				stateGroupBox.Visible = false;
				statePictureBox.Visible = false;
				phoneCheckBox.Checked = false;
				toolTip1.SetToolTip(this.statePictureBox, "test");
			}

				
		}

		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (OregonRadioButton.Checked == true || caliRadioButton.Checked == true || washingtonRadioButton.Checked == true)
			{
				//Same as above, but for the tool strip.
				OregonRadioButton.Checked = false;
				caliRadioButton.Checked = false;
				washingtonRadioButton.Checked = false;
				stateGroupBox.Visible = false;
				statePictureBox.Visible = false;
				phoneCheckBox.Checked = false;
			}
		}

		private void oregonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Selects Oregon from States menu.
			OregonRadioButton.Checked = true;
		}

		private void washingtonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Selects Washington from State menu.
			washingtonRadioButton.Checked = true;
		}

		private void californiaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Selects California from State menu.
			caliRadioButton.Checked = true;
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			//Will ask user if they really want to exit from clicking the exit button.
			if (MessageBox.Show("Are you sure you want to exit?", "Question", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
				//This code block asks the user upon clicking the button if the user is planning on visiting the states. System respons with answers for yes, no and everything else.
				string inputResponse = null;
				inputResponse = Interaction.InputBox
					 ("Do you plan to visit one of these states?" + Constants.vbCrLf + "Answer Yes or No", "Your input needed");
				string myresult = inputResponse.ToLower();//sets response to lower case regardless of what case user entered.
				if (myresult == "yes")
				{
					MessageBox.Show("I'll probably see you there!");
				}

				else if (myresult == "no")
				{
					MessageBox.Show("I probably wont see you there");
				}

				else 
				{
					MessageBox.Show("Please answer yes or no");
				}

		}

		private void inputBoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Same as above, but used from tool strip.
			//Used VB tools to create input box.
			string inputResponse = null;
			inputResponse = Interaction.InputBox
				 ("Do you plan to visit one of these states?" + Constants.vbCrLf + "Answer Yes or No", "Your input needed");
			string myresult = inputResponse.ToLower();
			if (myresult == "yes")
			{
				MessageBox.Show("I'll probably see you there!");
			}

			else if (myresult == "no")
			{
				MessageBox.Show("I probably wont see you there");
			}

			else
			{
				MessageBox.Show("Please answer yes or no");
			}
		}

		private void statePictureBox_Click(object sender, EventArgs e)
		{

		}

		private void stateNameLabel_Click(object sender, EventArgs e)
		{
		
		}
	}
}
