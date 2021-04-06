using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        String operationPerfomed = "";
        Boolean isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, MouseEventArgs e)
        {
            if (textBox_Result.Text == "0")
                textBox_Result.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;

            operationPerfomed = button.Text;
            resultValue = double.Parse(textBox_Result.Text);
            isOperationPerformed = true;
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            textBox_Result.Text="0";
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            switch(operationPerfomed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;

            }
        }
    }
    }
}
