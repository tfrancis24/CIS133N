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
	public partial class numberForm : Form
	{
		public numberForm()
		{
			InitializeComponent();
		}
		// I do not have access to the files from the textbook because this is a rental so I used different images as a placeholder.
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("One");
			//When clicked, will display the number one in a message box.
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Two");
			//When clicked, will display the number two in a message box.
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Three");
			//When clicked, will display the number three in a message box.
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Four");
			//When clicked, will display the number four in a message box.
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Five");
			//When clicked, will display the number five in a message box.
		}


	}
}
