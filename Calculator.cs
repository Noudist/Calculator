using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        string input = string.Empty;        //string storing user input
        string operand1 = string.Empty;     //string storing first operand
        string operand2 = string.Empty;     //string storing second operand
        char operation;                     //char for operation (char is for characters such as 'c' or '*')
        double result = 0.0;                //calculated result (double is for decimal numbers)

        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "1";
            textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "2";
            textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "3";
            textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "4";
            textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "5";
            textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "6";
            textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "7";
            textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "8";
            textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "9";
            textBox1.Text += input;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "0";
            textBox1.Text += input;
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(','))
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = "";
                input += ',';
                textBox1.Text += input;
            }
        }

        private void buttonIs_Click(object sender, EventArgs e)
        {
            operand2 = input;                       //finalize last input
            double num1, num2;                      //create two new variables called num1 and num2
            double.TryParse(operand1, out num1);    //parse operand1 to num1
            double.TryParse(operand2, out num2);    //parse operand2 to num2

            textBox1.Text = "";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "syntax error";
                }
            }
            else if (operation == 'p')
            {
                result = Math.Pow(num1, num2);
                textBox1.Text = result.ToString();
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void buttonSwitchValue_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(textBox1.Text);
            result = Math.Abs(result) * -1;
            textBox1.Text = result.ToString();
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            operand2 = input;                       //finalize last input
            double num1, num2;                      //create two new variables called num1 and num2
            double.TryParse(operand1, out num1);    //parse operand1 to num1
            double.TryParse(operand2, out num2);    //parse operand2 to num2

            num2 /= 100;
            num2 = num1 * num2;

            textBox1.Text = "";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "syntax error";
                }
            }
        }

        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                textBox1.Text = "syntax error";
            }
            else
            {
                result = Convert.ToDouble(textBox1.Text);
                result = Math.Sqrt(result);
                textBox1.Text = result.ToString();
            }
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = 'p';
            input = string.Empty;
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input = String.Empty;
            input += Math.PI;
            textBox1.Text += input;
        }

        private void buttonEuro_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(textBox1.Text);
            result = Math.Round((Double)result, 2, MidpointRounding.AwayFromZero);
            textBox1.Text = result.ToString();
        }
    }
}
