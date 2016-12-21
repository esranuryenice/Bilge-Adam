namespace quiz2_OPP
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
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAboneTipi = new System.Windows.Forms.GroupBox();
            this.radioButtonSirket = new System.Windows.Forms.RadioButton();
            this.radioButtonEv = new System.Windows.Forms.RadioButton();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.listBoxOdeme = new System.Windows.Forms.ListBox();
            this.listBoxOdenen = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSonraki = new System.Windows.Forms.TextBox();
            this.textBoxOnceki = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxAboneTipi.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAdSoyad.Location = new System.Drawing.Point(62, 24);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(269, 22);
            this.textBoxAdSoyad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Abone Adı";
            // 
            // groupBoxAboneTipi
            // 
            this.groupBoxAboneTipi.Controls.Add(this.radioButtonSirket);
            this.groupBoxAboneTipi.Controls.Add(this.radioButtonEv);
            this.groupBoxAboneTipi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxAboneTipi.Location = new System.Drawing.Point(59, 56);
            this.groupBoxAboneTipi.Name = "groupBoxAboneTipi";
            this.groupBoxAboneTipi.Size = new System.Drawing.Size(272, 55);
            this.groupBoxAboneTipi.TabIndex = 2;
            this.groupBoxAboneTipi.TabStop = false;
            this.groupBoxAboneTipi.Text = "Abone Tipi";
            // 
            // radioButtonSirket
            // 
            this.radioButtonSirket.AutoSize = true;
            this.radioButtonSirket.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonSirket.Location = new System.Drawing.Point(140, 19);
            this.radioButtonSirket.Name = "radioButtonSirket";
            this.radioButtonSirket.Size = new System.Drawing.Size(102, 20);
            this.radioButtonSirket.TabIndex = 3;
            this.radioButtonSirket.TabStop = true;
            this.radioButtonSirket.Text = "Şirket/Kurum";
            this.radioButtonSirket.UseVisualStyleBackColor = true;
            // 
            // radioButtonEv
            // 
            this.radioButtonEv.AutoSize = true;
            this.radioButtonEv.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonEv.Location = new System.Drawing.Point(18, 19);
            this.radioButtonEv.Name = "radioButtonEv";
            this.radioButtonEv.Size = new System.Drawing.Size(40, 20);
            this.radioButtonEv.TabIndex = 0;
            this.radioButtonEv.TabStop = true;
            this.radioButtonEv.Text = "Ev";
            this.radioButtonEv.UseVisualStyleBackColor = true;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.Location = new System.Drawing.Point(129, 199);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(135, 38);
            this.buttonEkle.TabIndex = 3;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // listBoxOdeme
            // 
            this.listBoxOdeme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxOdeme.FormattingEnabled = true;
            this.listBoxOdeme.ItemHeight = 16;
            this.listBoxOdeme.Location = new System.Drawing.Point(3, 262);
            this.listBoxOdeme.Name = "listBoxOdeme";
            this.listBoxOdeme.Size = new System.Drawing.Size(184, 148);
            this.listBoxOdeme.TabIndex = 4;
            this.listBoxOdeme.DoubleClick += new System.EventHandler(this.listBoxOdeme_DoubleClick);
            // 
            // listBoxOdenen
            // 
            this.listBoxOdenen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxOdenen.FormattingEnabled = true;
            this.listBoxOdenen.ItemHeight = 16;
            this.listBoxOdenen.Location = new System.Drawing.Point(206, 262);
            this.listBoxOdenen.Name = "listBoxOdenen";
            this.listBoxOdenen.Size = new System.Drawing.Size(189, 148);
            this.listBoxOdenen.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ödeme Listesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(203, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ödenenler";
            // 
            // textBoxSonraki
            // 
            this.textBoxSonraki.Location = new System.Drawing.Point(166, 168);
            this.textBoxSonraki.Name = "textBoxSonraki";
            this.textBoxSonraki.Size = new System.Drawing.Size(165, 20);
            this.textBoxSonraki.TabIndex = 8;
            // 
            // textBoxOnceki
            // 
            this.textBoxOnceki.Location = new System.Drawing.Point(166, 131);
            this.textBoxOnceki.Name = "textBoxOnceki";
            this.textBoxOnceki.Size = new System.Drawing.Size(165, 20);
            this.textBoxOnceki.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(62, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Önceki Sayaç";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(62, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sonraki Sayaç";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 413);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOnceki);
            this.Controls.Add(this.textBoxSonraki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxOdenen);
            this.Controls.Add(this.listBoxOdeme);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.groupBoxAboneTipi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdSoyad);
            this.Name = "Form1";
            this.Text = "IZSU";
            this.groupBoxAboneTipi.ResumeLayout(false);
            this.groupBoxAboneTipi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxAboneTipi;
        private System.Windows.Forms.RadioButton radioButtonSirket;
        private System.Windows.Forms.RadioButton radioButtonEv;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.ListBox listBoxOdeme;
        private System.Windows.Forms.ListBox listBoxOdenen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSonraki;
        private System.Windows.Forms.TextBox textBoxOnceki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

