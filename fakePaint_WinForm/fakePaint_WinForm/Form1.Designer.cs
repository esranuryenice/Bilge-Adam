namespace fakePaint_WinForm
{
    partial class Form1
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
            this.chooseWidth = new System.Windows.Forms.ComboBox();
            this.buttonChooseColor = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseWidth
            // 
            this.chooseWidth.FormattingEnabled = true;
            this.chooseWidth.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "8",
            "11",
            "14",
            "20",
            "25"});
            this.chooseWidth.Location = new System.Drawing.Point(12, 12);
            this.chooseWidth.Name = "chooseWidth";
            this.chooseWidth.Size = new System.Drawing.Size(121, 21);
            this.chooseWidth.TabIndex = 0;
            this.chooseWidth.SelectedIndexChanged += new System.EventHandler(this.chooseWidth_SelectedIndexChanged);
            // 
            // buttonChooseColor
            // 
            this.buttonChooseColor.Location = new System.Drawing.Point(150, 12);
            this.buttonChooseColor.Name = "buttonChooseColor";
            this.buttonChooseColor.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseColor.TabIndex = 1;
            this.buttonChooseColor.Text = "Color";
            this.buttonChooseColor.UseVisualStyleBackColor = true;
            this.buttonChooseColor.Click += new System.EventHandler(this.buttonChooseColor_Click);
            // 
            // buttonErase
            // 
            this.buttonErase.Location = new System.Drawing.Point(240, 12);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(75, 23);
            this.buttonErase.TabIndex = 2;
            this.buttonErase.Text = "Erase";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 261);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.buttonChooseColor);
            this.Controls.Add(this.chooseWidth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox chooseWidth;
        private System.Windows.Forms.Button buttonChooseColor;
        private System.Windows.Forms.Button buttonErase;
    }
}

