using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_app_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string caltotal;
        int num1;
        int num2;
        string option;
        int result;



        private void button17_Click(object sender, EventArgs e)
        {
            txtnumber.Text = txtnumber.Text + button17.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtnumber.Text = txtnumber.Text + button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtnumber.Text = txtnumber.Text + button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtnumber.Text = txtnumber.Text + button15.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtnumber.Text = txtnumber.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtnumber.Text = txtnumber.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtnumber.Text = txtnumber.Text + button11.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtnumber.Text = txtnumber.Text + button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtnumber.Text = txtnumber.Text + button7.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtnumber.Text = txtnumber.Text + button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtnumber.Text);

            txtnumber.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtnumber.Text);

            txtnumber.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            option = "×";
            num1 = int.Parse(txtnumber.Text);

            txtnumber.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            option = "÷";
            num1 = int.Parse(txtnumber.Text);

            txtnumber.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            option = "%";
            num1 = int.Parse(txtnumber.Text);

            txtnumber.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtnumber.Text);


            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("×"))
                result = num1 * num2;

            if (option.Equals("÷"))
                result = num1 / num2;

            txtnumber.Text = result + "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnumber.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
