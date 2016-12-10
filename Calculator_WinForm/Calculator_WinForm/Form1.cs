﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_WinForm
{
    public partial class calculator : Form
    {
        //Enter a basınca eşittir olsun !!?? -> olmadı hala !!! 
        //sayılara ve + - ye basınca çıksın  -> bişiler yaptım ama olmadı hala !!!
        //Üssünü alma 
        //Modunu alma
        //Enum kullan  
        //, + - * = / de kontrol: boşken koyamasin -> OK
        //Eşittirden sonra +,- falan basınca tekrar kendini ekliyordu -> OK
        //Şeklini güzelleştir -> OK
        //icon koy -> OK
        //backspace ekle -> OK
        //Bilgdeki gibi üstte minik yazdıkları çıksın -> OK

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
            Button numberButtons = sender as Button;
            
            if (isThereAnyInput)
            {
                calculatorTextBox1.Text += numberButtons.Text;
                
            }
            else
            {
                calculatorTextBox1.Text = numberButtons.Text;
                
                isThereAnyInput = true;
            }
            label1.Focus();
        }


        private void AddButtonClick(object sender, EventArgs e)
        {

            if (calculatorTextBox1.Text != "")
            {
               
                if (operation == "")
                {
                    number1 = Convert.ToDouble(calculatorTextBox1.Text);

                    calculatorTextBox1.Clear();

                    showNumbersTextBox.Text += number1.ToString();                    
                }
                else
                {
                    calculate();
                }

                showNumbersTextBox.Text += " " + buttonAdd.Text + " ";
            }

            operation = "+";
            label1.Focus();

        }

        private void MinusButtonClick(object sender, EventArgs e)
        {
            if (calculatorTextBox1.Text != "")
            {
                
                if (operation == "")
                {
                    number1 = Convert.ToDouble(calculatorTextBox1.Text);

                    calculatorTextBox1.Clear();

                    showNumbersTextBox.Text = number1.ToString();                      
                }
                else
                {
                    calculate();
                }

                showNumbersTextBox.Text += " " + buttonSubstraction.Text + " ";
            }
            operation = "-";
            label1.Focus();

        }

        private void MultiplyButtonClick(object sender, EventArgs e)
        {
            if (calculatorTextBox1.Text != "")
            {
               
                if (operation == "")
                {
                    number1 = Convert.ToDouble(calculatorTextBox1.Text);
                    calculatorTextBox1.Clear();
                    showNumbersTextBox.Text = number1.ToString();
                    
                }
                else
                {
                    calculate();
                }

                showNumbersTextBox.Text += " " + buttonProduct.Text + " ";
            }
            operation = "*";
            label1.Focus();

        }

        private void DivisionButtonClick(object sender, EventArgs e)
        {
            if (calculatorTextBox1.Text != "")
            {                
                
                if (operation == "")
                {
                    number1 = Convert.ToDouble(calculatorTextBox1.Text);
                    calculatorTextBox1.Clear();
                    showNumbersTextBox.Text = number1.ToString();
                    
                }
                else
                {
                    calculate();
                }

                showNumbersTextBox.Text += " " + buttonDivision.Text + " ";
            }
            operation = "/";
            label1.Focus();
        }

        private void EqualButtonClick(object sender, EventArgs e)
        {
            
            if (calculatorTextBox1.Text != "")
            {
                calculate();
            }
            operation = "";
            showNumbersTextBox.Clear();

        }

        private void ClearEntryButtonClick(object sender, EventArgs e)
        {
            calculatorTextBox1.Clear();
            label1.Focus();

        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            calculatorTextBox1.Clear();
            showNumbersTextBox.Clear();
            number1 = 0;
            number2 = 0;
            operation = "";
            label1.Focus();

        }


        private void backspaceButton_Click(object sender, EventArgs e)
        {
            char[] charArray = calculatorTextBox1.Text.ToCharArray();
            calculatorTextBox1.Clear();

            for (int i = 0; i < charArray.Length - 1; i++)
            {                
                calculatorTextBox1.Text += charArray[i].ToString(); 
            }

            label1.Focus();
        }

        private void CommaButtonClick(object sender, System.EventArgs e)
        {
            if (calculatorTextBox1.Text != "")
            {
                calculatorTextBox1.Text += commaButton.Text;
            }

            label1.Focus();
        }


        public void calculate()
        {
            number2 = Convert.ToDouble(calculatorTextBox1.Text);
            showNumbersTextBox.Text += number2.ToString();

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

        private void calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    buttonZero.PerformClick();
                    break;
                case "1":
                    buttonOne.PerformClick();
                    break;
                case "2":
                    buttonTwo.PerformClick();
                    break;
                case "3":
                    buttonThree.PerformClick();
                    break;
                case "4":
                    buttonFour.PerformClick();
                    break;
                case "5":
                    buttonFive.PerformClick();
                    break;
                case "6":
                    buttonSix.PerformClick();
                    break;
                case "7":
                    buttonSeven.PerformClick();
                    break;
                case "8":
                    buttonEight.PerformClick();
                    break;
                case "9":
                    buttonNine.PerformClick();
                    break;
                case "+":
                    buttonAdd.PerformClick();
                    break;
                case "-":
                    buttonSubstraction.PerformClick();
                    break;
                case "*":
                    buttonProduct.PerformClick();
                    break;
                case "/":
                    buttonDivision.PerformClick();
                    break;
                case "=":
                    buttonEquals.PerformClick();
                    break;
                case "\r":
                    backspaceButton.PerformClick();
                    break;
                default:
                    break;
            }
        }

        
       
    }
}

//Button ramiz = (Button)sender;

//MessageBox.Show(numberButtons.Text + " e bastın.");

//ikincisayi = Convert.ToInt32(numberButtons.Text);

//label1.Text = numberButtons.Text;
//label1.Text = number + ikincisayi + "";

//char[] characters = "this is a test".ToCharArray();
