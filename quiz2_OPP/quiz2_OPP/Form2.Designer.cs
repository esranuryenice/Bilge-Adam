namespace quiz2_OPP
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.textBoxOdeme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSonOdeme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim Soyisim";
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAdSoyad.Location = new System.Drawing.Point(109, 9);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.ReadOnly = true;
            this.textBoxAdSoyad.Size = new System.Drawing.Size(180, 22);
            this.textBoxAdSoyad.TabIndex = 1;
            // 
            // textBoxOdeme
            // 
            this.textBoxOdeme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOdeme.Location = new System.Drawing.Point(109, 84);
            this.textBoxOdeme.Name = "textBoxOdeme";
            this.textBoxOdeme.ReadOnly = true;
            this.textBoxOdeme.Size = new System.Drawing.Size(180, 22);
            this.textBoxOdeme.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toplam Ödeme";
            // 
            // textBoxSonOdeme
            // 
            this.textBoxSonOdeme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSonOdeme.Location = new System.Drawing.Point(110, 49);
            this.textBoxSonOdeme.Name = "textBoxSonOdeme";
            this.textBoxSonOdeme.ReadOnly = true;
            this.textBoxSonOdeme.Size = new System.Drawing.Size(180, 22);
            this.textBoxSonOdeme.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Son Ödeme";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 136);
            this.Controls.Add(this.textBoxSonOdeme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOdeme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Müşteri Bilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.TextBox textBoxOdeme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSonOdeme;
        private System.Windows.Forms.Label label3;
    }
}