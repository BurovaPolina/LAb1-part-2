using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LAb1_part_2
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Console.WriteLine(textBox1.Text);
            Console.WriteLine(textBox2.Text);
            Console.WriteLine(textBox3.Text);

            if (textBox2.Text == "+") {
                linkLabel1.Text = (Double.Parse(textBox1.Text) + Double.Parse(textBox3.Text)).ToString();
            }
            else if(textBox2.Text == "-") {
                linkLabel1.Text = (Double.Parse(textBox1.Text) - Double.Parse(textBox3.Text)).ToString();
            }
            else if(textBox2.Text == "*") {
                linkLabel1.Text = (Double.Parse(textBox1.Text) * Double.Parse(textBox3.Text)).ToString();
            }
            else if (textBox2.Text == "/") {
                linkLabel1.Text = (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox3.Text)).ToString();
            }
            else {
                return;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class NumericTextBox : TextBox
    {
        public NumericTextBox()
        {
            this.KeyPress += NumericTextBox_KeyPress;
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }

    public class OperationTextBox : TextBox
    {
        private static char[] operations = { '+', '-', '*', '/' };
        public OperationTextBox()
        {
            this.KeyPress += OperationTextBox_KeyPress;
        }

        private void OperationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!operations.Contains(e.KeyChar) || this.Text.Length > 0)
            {
                e.Handled = true;
            }
        }
    }
}
