using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab_7
{
	public partial class wPForm : Form
	{
		public wPForm()
		{
			InitializeComponent();

			//Starts time timer
			currentTimer.Start();
		}

		private void wPForm_Load(object sender, EventArgs e)
		{
			//Settings the menus to use the image list.
			menuToolStrip.ImageList = lab7ImageList;
			contextMenuStrip1.ImageList = lab7ImageList;

			//Assigning images to buttons
			toolStripSaveButton.ImageIndex = 0;
			toolStripOpenButton.ImageIndex = 1;
			toolStripExitButton.ImageIndex = 2;
			toolStripCutButton.ImageIndex = 3;
			toolStripCopyButton.ImageIndex = 4;
			toolStripPasteButton.ImageIndex = 5;
			toolStripCenterButton.ImageIndex = 6;
			toolStripRightButton.ImageIndex = 7;
			toolStripLeftButton.ImageIndex = 8;
			clearToolStripMenuItem.ImageIndex = 9;
			cutToolStripMenuItem.ImageIndex = 3;
			copyToolStripMenuItem.ImageIndex = 4;
			pasteToolStripMenuItem.ImageIndex = 5;

			//Adding items to the toolstrip combo box.
			toolStripComboBox.Items.Insert(0, "Color");
			toolStripComboBox.Items.Insert(0, "Font");
		}

		private void toolStripSaveButton_Click(object sender, EventArgs e)
		{
			// Displays a SaveFileDialog so the user can save the content in the text box as a txt file or rtf file.
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.Filter = "txt files|*.txt|Rich text format|*.rtf";
			saveFileDialog1.Title = "Save as";

			//Will take content in the textbox and save as a txt file in a desired directory
			DialogResult result = saveFileDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				string name = saveFileDialog1.FileName;
				File.WriteAllText(name, wPRichTextBox.Text);
			}

		}

		private void customDropDownButton_Click(object sender, EventArgs e)
		{

		}

		private void toolStripComboBox1_Click(object sender, EventArgs e)
		{

		}


		private void toolStripExitButton_Click(object sender, EventArgs e)
		{
			//Exits the program.
			Application.Exit();
		}

		private void wPForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			MessageBox.Show("You clicked X. Your data will be lost.", "Warning");
		}

		private void displayTime()
		{
			//timeLabel.Text = DateTime.Now.ToShortTimeString();
		}

		private void time1Label_Click(object sender, EventArgs e)
		{

		}

		private void currentTimer_Tick(object sender, EventArgs e)
		{
			//Configs timer to display local time and date.
			DateTime dateTime = DateTime.Now;
			this.timeLabel.Text = dateTime.ToString();
		}

		private void toolStripCenterButton_Click(object sender, EventArgs e)
		{
			//Alligns textbox to center
			wPRichTextBox.SelectAll();
			wPRichTextBox.SelectionAlignment = HorizontalAlignment.Center;

		}

		private void toolStripRightButton_Click(object sender, EventArgs e)
		{
			//Alligns textbox to right
			wPRichTextBox.SelectAll();
			wPRichTextBox.SelectionAlignment = HorizontalAlignment.Right;
		}

		private void toolStripLeftButton_Click(object sender, EventArgs e)
		{
			//Alligns textbox to left
			wPRichTextBox.SelectAll();
			wPRichTextBox.SelectionAlignment = HorizontalAlignment.Left;
		}

		private void toolStripCopyButton_Click(object sender, EventArgs e)
		{
			////Copy text

			wPRichTextBox.Copy();

		}

		private void toolStripPasteButton_Click(object sender, EventArgs e)
		{
			//Paste text
			wPRichTextBox.Paste();
		}

		private void toolStripCutButton_Click(object sender, EventArgs e)
		{
			//Cuts selected text
			wPRichTextBox.Cut();
		}

		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Cuts text
			wPRichTextBox.Cut();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Copies text
			wPRichTextBox.Copy();
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Pastes text into the text box
			wPRichTextBox.Paste();
		}

		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Clears the text box and any days selected that were available by the user.
			//Also resets fonts and color.
			wPRichTextBox.Font = SystemFonts.DefaultFont;
			wPRichTextBox.ForeColor = Color.Black;
			wPRichTextBox.Clear();
		}

		private void toolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Brings up combo box that will allow user to alter fort and color for the textbox
			switch (this.toolStripComboBox.Text)
			{
				case "Font":
					if (fontDialog1.ShowDialog() == DialogResult.OK)
					{
						wPRichTextBox.Font = fontDialog1.Font;
					}
					break;
				case "Color":
					if (colorDialog1.ShowDialog() == DialogResult.OK)
					{
						wPRichTextBox.ForeColor = colorDialog1.Color;
					}
					break;
			}
		}

		private void toolStripOpenButton_Click(object sender, EventArgs e)
		{
			//Open file dialog code from MSDN
			Stream myStream = null;
			OpenFileDialog openFileDialog1 = new OpenFileDialog();

			openFileDialog1.InitialDirectory = "c:\\";
			openFileDialog1.Filter = "txt files (*.txt)|*.txt";
			openFileDialog1.FilterIndex = 2;
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					if ((myStream = openFileDialog1.OpenFile()) != null)
					{
						using (myStream)
						{
							//Reads code from text file.
							//wPRichTextBox.Text = File.ReadAllText(openFileDialog1.FileName);
							wPRichTextBox.AppendText(Environment.NewLine);
							wPRichTextBox.AppendText(File.ReadAllText(openFileDialog1.FileName));
						}
					}
				}
				catch
				{
					MessageBox.Show("Error: Could not read the file!");
				}
			}
		}

		private void addDateButton_Click(object sender, EventArgs e)
		{
			//Will add the selected date from the date time picker to the availabilty combo box.
			if (selectedAvailabilityComboBox.Items.Contains(dateTimePicker.Value.ToString("")))
			{
				MessageBox.Show("Duplicate dates are not allowed");
			}
			else
			{
				selectedAvailabilityComboBox.Items.Add(dateTimePicker.Value.ToString(""));
				selectedAvailabilityComboBox.Text = dateTimePicker.Value.ToString("");
			}

		}

		private void displaySchedButton_Click(object sender, EventArgs e)
		{
			//Displays all the selected dates in the text box.
			string text = "";
			foreach (var item in selectedAvailabilityComboBox.Items)
			{
				wPRichTextBox.AppendText(text += item.ToString() + Environment.NewLine);
			}

		}
	}
}

