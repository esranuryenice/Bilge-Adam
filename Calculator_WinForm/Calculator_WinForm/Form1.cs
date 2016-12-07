using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WinForm
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }
                
        double number1;
        double number2;
        
        string operation = "";
        bool isThereAnyInput = true;
  
        private void ButtonClick(object sender, EventArgs e)
        {

            if (isThereAnyInput)
            {
                Button numberButtons = sender as Button;
                calculatorTextBox1.Text += numberButtons.Text;
            }
            else
            {
                Button numberButtons = sender as Button;
                calculatorTextBox1.Text = numberButtons.Text;
                isThereAnyInput = true;
            }            
        }


        private void AddButtonClick(object sender, EventArgs e)
        {
            if (calculatorTextBox1.Text.Length != 0)
            {
                if (operation == "")
                {
                    number1 = double.Parse(calculatorTextBox1.Text);
                    calculatorTextBox1.Clear();
                }
                else
                {
                    calculate();
                }
            }

            operation = "+";        
        }

        private void MinusButtonClick(object sender, EventArgs e)
        {
            if (calculatorTextBox1.Text.Length != 0)
            {
                if (operation == "")
                {
                    number1 = double.Parse(calculatorTextBox1.Text);
                    calculatorTextBox1.Clear();
                }
                else
                {
                    calculate();
                }
            }
            operation = "-";      
        }

        private void MultiplyButtonClick(object sender, EventArgs e)
        {
            if (calculatorTextBox1.Text.Length != 0)
            {
                if (operation == "")
                {
                    number1 = double.Parse(calculatorTextBox1.Text);
                    calculatorTextBox1.Clear();
                }
                else
                {
                    calculate();
                }
            }
            operation = "*";       
        }

        private void DivisionButtonClick(object sender, EventArgs e)
        {
            if (calculatorTextBox1.Text.Length != 0)
            {
                if (operation == "")
                {
                    number1 = double.Parse(calculatorTextBox1.Text);
                    calculatorTextBox1.Clear();
                }
                else
                {
                    calculate();
                }
            }
            operation = "/";    
        }

        private void EqualButtonClick(object sender, EventArgs e)
        {
            calculate();
        }

        private void ClearEntryButtonClick(object sender, EventArgs e)
        {
            calculatorTextBox1.Clear();     
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            calculatorTextBox1.Clear();
            number1 = 0;
            number2 = 0;
            operation = "";       
        }

        private void CommaButtonClick(object sender, System.EventArgs e)
        {
            calculatorTextBox1.Text += commaButton.Text;          
        }


        public void calculate()
        {
            number2 = double.Parse(calculatorTextBox1.Text);

            switch (operation)
            {
                case "+":

                    number1 += number2;
                    break;

                case "-":

                    number1 -= number2;
                    break;

                case "*":

                    number1 *= number2;
                    break;

                case "/":

                    number1 /= number2;
                    break;

                default:
                    break;
            }

            calculatorTextBox1.Text = number1.ToString();
            isThereAnyInput = false;
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }
    }
}

//Button ramiz = (Button)sender;

//MessageBox.Show(numberButtons.Text + " e bastın.");


//ikincisayi = Convert.ToInt32(numberButtons.Text);

//label1.Text = numberButtons.Text;
//label1.Text = number + ikincisayi + "";