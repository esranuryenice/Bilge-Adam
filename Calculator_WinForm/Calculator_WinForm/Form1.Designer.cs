namespace Calculator_WinForm
{
    partial class calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.buttonSubstraction = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.commaButton = new System.Windows.Forms.Button();
            this.calculatorTextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.showNumbersTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonThree
            // 
            this.buttonThree.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonThree.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThree.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonThree.Location = new System.Drawing.Point(97, 172);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(40, 33);
            this.buttonThree.TabIndex = 3;
            this.buttonThree.TabStop = false;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.ButtonClick);
            this.buttonThree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFive.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFive.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonFive.Location = new System.Drawing.Point(51, 133);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(40, 33);
            this.buttonFive.TabIndex = 10;
            this.buttonFive.TabStop = false;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.ButtonClick);
            this.buttonFive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSeven.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeven.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSeven.Location = new System.Drawing.Point(5, 94);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(40, 33);
            this.buttonSeven.TabIndex = 7;
            this.buttonSeven.TabStop = false;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.ButtonClick);
            this.buttonSeven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTwo.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTwo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTwo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTwo.Location = new System.Drawing.Point(51, 172);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(40, 33);
            this.buttonTwo.TabIndex = 2;
            this.buttonTwo.TabStop = false;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.ButtonClick);
            this.buttonTwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOne.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOne.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOne.Location = new System.Drawing.Point(5, 172);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(40, 33);
            this.buttonOne.TabIndex = 1;
            this.buttonOne.TabStop = false;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.ButtonClick);
            this.buttonOne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFour.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFour.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonFour.Location = new System.Drawing.Point(5, 133);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(40, 33);
            this.buttonFour.TabIndex = 4;
            this.buttonFour.TabStop = false;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.ButtonClick);
            this.buttonFour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSix.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSix.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSix.Location = new System.Drawing.Point(97, 133);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(40, 33);
            this.buttonSix.TabIndex = 6;
            this.buttonSix.TabStop = false;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.ButtonClick);
            this.buttonSix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEight.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEight.Location = new System.Drawing.Point(51, 94);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(40, 33);
            this.buttonEight.TabIndex = 8;
            this.buttonEight.TabStop = false;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.ButtonClick);
            this.buttonEight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNine.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonNine.Location = new System.Drawing.Point(97, 94);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(40, 33);
            this.buttonNine.TabIndex = 9;
            this.buttonNine.TabStop = false;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.ButtonClick);
            this.buttonNine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            // 
            // buttonProduct
            // 
            this.buttonProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonProduct.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonProduct.Location = new System.Drawing.Point(150, 94);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(40, 33);
            this.buttonProduct.TabIndex = 10;
            this.buttonProduct.TabStop = false;
            this.buttonProduct.Text = "*";
            this.buttonProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonProduct.UseVisualStyleBackColor = false;
            this.buttonProduct.Click += new System.EventHandler(this.MultiplyButtonClick);
            this.buttonProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            // 
            // buttonSubstraction
            // 
            this.buttonSubstraction.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSubstraction.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSubstraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubstraction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSubstraction.Location = new System.Drawing.Point(150, 133);
            this.buttonSubstraction.Name = "buttonSubstraction";
            this.buttonSubstraction.Size = new System.Drawing.Size(40, 33);
            this.buttonSubstraction.TabIndex = 11;
            this.buttonSubstraction.TabStop = false;
            this.buttonSubstraction.Text = "-";
            this.buttonSubstraction.UseVisualStyleBackColor = false;
            this.buttonSubstraction.Click += new System.EventHandler(this.MinusButtonClick);
            this.buttonSubstraction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAdd.Location = new System.Drawing.Point(150, 172);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(40, 33);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.TabStop = false;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.AddButtonClick);
            this.buttonAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDivision.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDivision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonDivision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivision.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDivision.Location = new System.Drawing.Point(150, 55);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(40, 33);
            this.buttonDivision.TabIndex = 13;
            this.buttonDivision.TabStop = false;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.DivisionButtonClick);
            this.buttonDivision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonZero.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonZero.Location = new System.Drawing.Point(51, 211);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(40, 33);
            this.buttonZero.TabIndex = 14;
            this.buttonZero.TabStop = false;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.ButtonClick);
            this.buttonZero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClearEntry.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearEntry.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonClearEntry.Location = new System.Drawing.Point(5, 55);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(40, 33);
            this.buttonClearEntry.TabIndex = 15;
            this.buttonClearEntry.TabStop = false;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = false;
            this.buttonClearEntry.Click += new System.EventHandler(this.ClearEntryButtonClick);
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEquals.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEquals.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEquals.Location = new System.Drawing.Point(97, 211);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(93, 33);
            this.buttonEquals.TabIndex = 1;
            this.buttonEquals.TabStop = false;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.EqualButtonClick);
            this.buttonEquals.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            // 
            // commaButton
            // 
            this.commaButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.commaButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.commaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commaButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.commaButton.Location = new System.Drawing.Point(5, 211);
            this.commaButton.Name = "commaButton";
            this.commaButton.Size = new System.Drawing.Size(40, 33);
            this.commaButton.TabIndex = 17;
            this.commaButton.TabStop = false;
            this.commaButton.Text = ",";
            this.commaButton.UseVisualStyleBackColor = false;
            this.commaButton.Click += new System.EventHandler(this.CommaButtonClick);
            this.commaButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            // 
            // calculatorTextBox1
            // 
            this.calculatorTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calculatorTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calculatorTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calculatorTextBox1.Location = new System.Drawing.Point(5, 25);
            this.calculatorTextBox1.Multiline = true;
            this.calculatorTextBox1.Name = "calculatorTextBox1";
            this.calculatorTextBox1.Size = new System.Drawing.Size(185, 24);
            this.calculatorTextBox1.TabIndex = 0;
            this.calculatorTextBox1.TabStop = false;
            this.calculatorTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(51, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 33);
            this.button1.TabIndex = 19;
            this.button1.TabStop = false;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // backspaceButton
            // 
            this.backspaceButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.backspaceButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.backspaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspaceButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backspaceButton.Location = new System.Drawing.Point(97, 55);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(40, 33);
            this.backspaceButton.TabIndex = 20;
            this.backspaceButton.TabStop = false;
            this.backspaceButton.Text = "<<";
            this.backspaceButton.UseVisualStyleBackColor = false;
            this.backspaceButton.Click += new System.EventHandler(this.backspaceButton_Click);
            this.backspaceButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            // 
            // showNumbersTextBox
            // 
            this.showNumbersTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showNumbersTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showNumbersTextBox.Font = new System.Drawing.Font("Arial", 9F);
            this.showNumbersTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.showNumbersTextBox.Location = new System.Drawing.Point(5, 1);
            this.showNumbersTextBox.Multiline = true;
            this.showNumbersTextBox.Name = "showNumbersTextBox";
            this.showNumbersTextBox.Size = new System.Drawing.Size(185, 18);
            this.showNumbersTextBox.TabIndex = 21;
            this.showNumbersTextBox.TabStop = false;
            this.showNumbersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(197, 254);
            this.Controls.Add(this.showNumbersTextBox);
            this.Controls.Add(this.backspaceButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calculatorTextBox1);
            this.Controls.Add(this.commaButton);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonClearEntry);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSubstraction);
            this.Controls.Add(this.buttonProduct);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.calculator_Load);
            this.Click += new System.EventHandler(this.ButtonClick);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Button buttonSubstraction;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonClearEntry;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button commaButton;
        private System.Windows.Forms.TextBox calculatorTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.TextBox showNumbersTextBox;
        private System.Windows.Forms.Label label1;
    }
}

