namespace KafeSiparis_SINAV
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
            this.panelMasalar = new System.Windows.Forms.Panel();
            this.listBoxSiparisler = new System.Windows.Forms.ListBox();
            this.buttonOde = new System.Windows.Forms.Button();
            this.radioButtonUSD = new System.Windows.Forms.RadioButton();
            this.radioButtonEUR = new System.Windows.Forms.RadioButton();
            this.radioButtonGBP = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSiparisVer = new System.Windows.Forms.Button();
            this.panelYemekSec = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownIcecek = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYemek = new System.Windows.Forms.NumericUpDown();
            this.comboBoxIcecek = new System.Windows.Forms.ComboBox();
            this.comboBoxYemek = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMasaNo = new System.Windows.Forms.Label();
            this.panelYemekSec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIcecek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYemek)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMasalar
            // 
            this.panelMasalar.Location = new System.Drawing.Point(20, 27);
            this.panelMasalar.Name = "panelMasalar";
            this.panelMasalar.Size = new System.Drawing.Size(280, 210);
            this.panelMasalar.TabIndex = 0;
            // 
            // listBoxSiparisler
            // 
            this.listBoxSiparisler.FormattingEnabled = true;
            this.listBoxSiparisler.Location = new System.Drawing.Point(319, 20);
            this.listBoxSiparisler.Name = "listBoxSiparisler";
            this.listBoxSiparisler.Size = new System.Drawing.Size(273, 225);
            this.listBoxSiparisler.TabIndex = 0;
            this.listBoxSiparisler.DoubleClick += new System.EventHandler(this.listBoxSiparisler_DoubleClick);
            // 
            // buttonOde
            // 
            this.buttonOde.Location = new System.Drawing.Point(366, 308);
            this.buttonOde.Name = "buttonOde";
            this.buttonOde.Size = new System.Drawing.Size(160, 34);
            this.buttonOde.TabIndex = 2;
            this.buttonOde.Text = "ÖDE";
            this.buttonOde.UseVisualStyleBackColor = true;
            this.buttonOde.Click += new System.EventHandler(this.buttonOde_Click);
            // 
            // radioButtonUSD
            // 
            this.radioButtonUSD.AutoSize = true;
            this.radioButtonUSD.Location = new System.Drawing.Point(367, 276);
            this.radioButtonUSD.Name = "radioButtonUSD";
            this.radioButtonUSD.Size = new System.Drawing.Size(48, 17);
            this.radioButtonUSD.TabIndex = 3;
            this.radioButtonUSD.TabStop = true;
            this.radioButtonUSD.Text = "USD";
            this.radioButtonUSD.UseVisualStyleBackColor = true;
            // 
            // radioButtonEUR
            // 
            this.radioButtonEUR.AutoSize = true;
            this.radioButtonEUR.Location = new System.Drawing.Point(421, 276);
            this.radioButtonEUR.Name = "radioButtonEUR";
            this.radioButtonEUR.Size = new System.Drawing.Size(48, 17);
            this.radioButtonEUR.TabIndex = 4;
            this.radioButtonEUR.TabStop = true;
            this.radioButtonEUR.Text = "EUR";
            this.radioButtonEUR.UseVisualStyleBackColor = true;
            // 
            // radioButtonGBP
            // 
            this.radioButtonGBP.AutoSize = true;
            this.radioButtonGBP.Location = new System.Drawing.Point(475, 276);
            this.radioButtonGBP.Name = "radioButtonGBP";
            this.radioButtonGBP.Size = new System.Drawing.Size(47, 17);
            this.radioButtonGBP.TabIndex = 5;
            this.radioButtonGBP.TabStop = true;
            this.radioButtonGBP.Text = "GBP";
            this.radioButtonGBP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "USD: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "EUR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "GBP:";
            // 
            // buttonSiparisVer
            // 
            this.buttonSiparisVer.Location = new System.Drawing.Point(53, 106);
            this.buttonSiparisVer.Name = "buttonSiparisVer";
            this.buttonSiparisVer.Size = new System.Drawing.Size(160, 34);
            this.buttonSiparisVer.TabIndex = 9;
            this.buttonSiparisVer.Text = "Sipariş Ver";
            this.buttonSiparisVer.UseVisualStyleBackColor = true;
            this.buttonSiparisVer.Click += new System.EventHandler(this.buttonSiparisVer_Click);
            // 
            // panelYemekSec
            // 
            this.panelYemekSec.Controls.Add(this.label5);
            this.panelYemekSec.Controls.Add(this.label4);
            this.panelYemekSec.Controls.Add(this.numericUpDownIcecek);
            this.panelYemekSec.Controls.Add(this.buttonSiparisVer);
            this.panelYemekSec.Controls.Add(this.numericUpDownYemek);
            this.panelYemekSec.Controls.Add(this.comboBoxIcecek);
            this.panelYemekSec.Controls.Add(this.comboBoxYemek);
            this.panelYemekSec.Location = new System.Drawing.Point(12, 270);
            this.panelYemekSec.Name = "panelYemekSec";
            this.panelYemekSec.Size = new System.Drawing.Size(274, 159);
            this.panelYemekSec.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "İçecek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Yemek";
            // 
            // numericUpDownIcecek
            // 
            this.numericUpDownIcecek.Location = new System.Drawing.Point(218, 62);
            this.numericUpDownIcecek.Name = "numericUpDownIcecek";
            this.numericUpDownIcecek.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownIcecek.TabIndex = 13;
            // 
            // numericUpDownYemek
            // 
            this.numericUpDownYemek.Location = new System.Drawing.Point(218, 16);
            this.numericUpDownYemek.Name = "numericUpDownYemek";
            this.numericUpDownYemek.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownYemek.TabIndex = 11;
            // 
            // comboBoxIcecek
            // 
            this.comboBoxIcecek.FormattingEnabled = true;
            this.comboBoxIcecek.Location = new System.Drawing.Point(62, 62);
            this.comboBoxIcecek.Name = "comboBoxIcecek";
            this.comboBoxIcecek.Size = new System.Drawing.Size(139, 21);
            this.comboBoxIcecek.TabIndex = 12;
            // 
            // comboBoxYemek
            // 
            this.comboBoxYemek.FormattingEnabled = true;
            this.comboBoxYemek.Location = new System.Drawing.Point(62, 16);
            this.comboBoxYemek.Name = "comboBoxYemek";
            this.comboBoxYemek.Size = new System.Drawing.Size(139, 21);
            this.comboBoxYemek.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Siparişler";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Masalar";
            // 
            // labelMasaNo
            // 
            this.labelMasaNo.AutoSize = true;
            this.labelMasaNo.Location = new System.Drawing.Point(25, 254);
            this.labelMasaNo.Name = "labelMasaNo";
            this.labelMasaNo.Size = new System.Drawing.Size(0, 13);
            this.labelMasaNo.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 539);
            this.Controls.Add(this.labelMasaNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelYemekSec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonGBP);
            this.Controls.Add(this.radioButtonEUR);
            this.Controls.Add(this.radioButtonUSD);
            this.Controls.Add(this.buttonOde);
            this.Controls.Add(this.listBoxSiparisler);
            this.Controls.Add(this.panelMasalar);
            this.Name = "Form1";
            this.Text = "Kafe Sipariş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelYemekSec.ResumeLayout(false);
            this.panelYemekSec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIcecek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYemek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMasalar;
        private System.Windows.Forms.ListBox listBoxSiparisler;
        private System.Windows.Forms.Button buttonOde;
        private System.Windows.Forms.RadioButton radioButtonUSD;
        private System.Windows.Forms.RadioButton radioButtonEUR;
        private System.Windows.Forms.RadioButton radioButtonGBP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSiparisVer;
        private System.Windows.Forms.Panel panelYemekSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownIcecek;
        private System.Windows.Forms.NumericUpDown numericUpDownYemek;
        private System.Windows.Forms.ComboBox comboBoxIcecek;
        private System.Windows.Forms.ComboBox comboBoxYemek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMasaNo;
    }
}

