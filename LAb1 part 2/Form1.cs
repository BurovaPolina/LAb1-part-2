﻿using System;
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
            Console.WriteLine("смотрим переменную operTextBox.Text:{0}", operTextBox.Text);

            if (operTextBox.Text == "+") {
                labelResut.Text = (Double.Parse(valFirstTextBox.Text.Trim()) + Double.Parse(valSecondTextBox.Text.Replace(" ", ""))).ToString();
                resultform(labelResut.Text);
            }
            else if(operTextBox.Text == "-") {
                labelResut.Text = (Double.Parse(valFirstTextBox.Text.Trim()) - Double.Parse(valSecondTextBox.Text.Replace(" ", ""))).ToString();
                resultform(labelResut.Text);

            }
            else if(operTextBox.Text == "*") {
                labelResut.Text = (Double.Parse(valFirstTextBox.Text.Trim()) * Double.Parse(valSecondTextBox.Text.Replace(" ", ""))).ToString();
                resultform(labelResut.Text);
            }
            else if (operTextBox.Text == "/") {
                labelResut.Text = (Convert.ToDouble(valFirstTextBox.Text.Trim()) / Convert.ToDouble(valSecondTextBox.Text.Replace(" ", ""))).ToString();
                resultform(labelResut.Text);
            }
            else {
                return;
            }
        }
       
        private void resultform(string result)
        {
            Form2 newForm = new Form2();
            newForm.result.Text = result;
            newForm.Show();
        }
            


        private void Form1_Load(object sender, EventArgs e)
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
