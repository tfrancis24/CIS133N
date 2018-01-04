using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
    Project      Lab3
    Programmer   Tim Francis
    Date         10/6
                
    	         Create a simple calculator in C#
*/

namespace Lab_3
{
	public partial class calcForm : Form
	{
		public calcForm()
		{
			InitializeComponent();
		}

		
		private void clearButton_Click(object sender, EventArgs e)
		{
			//This will clear both textboxes and the result label.
			textBox1.Text = null;
			textBox2.Text = null;
			resultLabel.Text = null;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				//This code should catch any unhandled exceptions.
			}
			catch
			{
				MessageBox.Show("Wrong Input");
			}

		}

		private void addButton_Click(object sender, EventArgs e)
		{
			try
			{
				/*This code will add integers, send to result to new decimal, convert to string and place in the result label. This will also catch any unhandled exception errors.
				*/
				decimal num1 = decimal.Parse(textBox1.Text);
				decimal num2 = decimal.Parse(textBox2.Text);
				decimal numResult = num1 + num2;
				resultLabel.Text = numResult.ToString();
			}
			catch
			{
				MessageBox.Show("Wrong Input");
			}
		}

		private void subtractButton_Click(object sender, EventArgs e)
		{
			try
			{
				/*This code will subtract integers, send to result to new decimal, convert to string and place in the result label. This will also catch any unhandled exception errors.
				 */
				decimal num1 = decimal.Parse(textBox1.Text);
				decimal num2 = decimal.Parse(textBox2.Text);
				decimal numResult = num1 - num2;
				resultLabel.Text = numResult.ToString();
			}
			catch
			{
				MessageBox.Show("Wrong Input");
			}
		}

		private void multiplyButton_Click(object sender, EventArgs e)
		{
			try
			{
				/*This code will multiply integers, send to result to new decimal, convert to string and place in the result label. This will also catch any unhandled exception errors.
				*/
				decimal num1 = decimal.Parse(textBox1.Text);
				decimal num2 = decimal.Parse(textBox2.Text);
				decimal numResult = num1 * num2;
				resultLabel.Text = numResult.ToString();
			}
			catch
			{
				MessageBox.Show("Wrong Input");
			}
		}

		private void divideButton_Click(object sender, EventArgs e)
		{
			try
			{
				/*This code will divide integers, send to result to new decimal, convert to string and place in the result label. This will also catch any unhandled exception errors.
				*/
				decimal num1 = decimal.Parse(textBox1.Text);
				decimal num2 = decimal.Parse(textBox2.Text);
				decimal numResult = num1 / num2;
				resultLabel.Text = numResult.ToString();
			}
			catch
			{
				MessageBox.Show("Wrong Input");
			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			/*Will promp user for confirmation of exiting the program, then exit if the user clicks the yes button.
			*/
			if (MessageBox.Show("Are you sure you want to exit", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes) {
				Application.Exit();
			}

		}

		private void calcForm_Load(object sender, EventArgs e)
		{

		}

		private void calcForm_FormClosing(object sender, FormClosingEventArgs e)
		{

		}
	}
}
