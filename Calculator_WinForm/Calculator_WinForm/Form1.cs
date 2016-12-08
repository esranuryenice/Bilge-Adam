﻿using System;
using System.Windows.Forms;

namespace Calculator_WinForm
{
    public partial class calculator : Form
    {
        //Enter a basınca eşittir olsun
        //Sil e basınca bir tane sil 
        //Numlock  
        //Üssünü alma 
        //Modunu alma 
        //Virgül de kontrol boşken koyamasin
        //Bug var: sonucu bulduktan sonra op a basınca tekrar kendini ekliyor.Eklemesin yeni number 1 o olsun
        //Bir tane silme ekle 
        //Şeklini güzelleştir
        //Enum kullan  
        //Bilgdeki gibi üstte minik yazdıkların çıksın
        //+ - * / boşken basamasın
               
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
            //Button numberButtons2 = (Button)sender;

            if (isThereAnyInput)
            {
                calculatorTextBox1.Text += numberButtons.Text;
            }
            else
            {
                calculatorTextBox1.Text = numberButtons.Text;
                isThereAnyInput = true;
            }
        }


        private void AddButtonClick(object sender, EventArgs e)
        {
            if (operation == "")
            {
                number1 = Convert.ToDouble(calculatorTextBox1.Text);
                calculatorTextBox1.Clear();
            }
            else
            {
                calculate();
            }


            operation = "+";
        }

        private void MinusButtonClick(object sender, EventArgs e)
        {
            if (operation == "")
            {
                number1 = Convert.ToDouble(calculatorTextBox1.Text);
                calculatorTextBox1.Clear();
            }
            else
            {
                calculate();
            }

            operation = "-";
        }

        private void MultiplyButtonClick(object sender, EventArgs e)
        {
            if (operation == "")
            {
                number1 = Convert.ToDouble(calculatorTextBox1.Text);
                calculatorTextBox1.Clear();
            }
            else
            {
                calculate();
            }

            operation = "*";
        }

        private void DivisionButtonClick(object sender, EventArgs e)
        {
            if (operation == "")
            {
                number1 = Convert.ToDouble(calculatorTextBox1.Text);
                calculatorTextBox1.Clear();
            }
            else
            {
                calculate();
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
            number2 = Convert.ToDouble(calculatorTextBox1.Text);

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
