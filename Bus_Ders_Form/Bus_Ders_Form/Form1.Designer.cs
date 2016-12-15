namespace Bus_Ders_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CBoxOtobusTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTravego = new System.Windows.Forms.Panel();
            this.panelSetra = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CBoxOtobusTuru
            // 
            this.CBoxOtobusTuru.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBoxOtobusTuru.FormattingEnabled = true;
            this.CBoxOtobusTuru.Items.AddRange(new object[] {
            "Travego",
            "Setra"});
            this.CBoxOtobusTuru.Location = new System.Drawing.Point(12, 167);
            this.CBoxOtobusTuru.Name = "CBoxOtobusTuru";
            this.CBoxOtobusTuru.Size = new System.Drawing.Size(121, 24);
            this.CBoxOtobusTuru.TabIndex = 1;
            this.CBoxOtobusTuru.SelectedIndexChanged += new System.EventHandler(this.CBoxOtobusTuru_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Otobüs Türü";
            // 
            // panelTravego
            // 
            this.panelTravego.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelTravego.Location = new System.Drawing.Point(183, 167);
            this.panelTravego.Name = "panelTravego";
            this.panelTravego.Size = new System.Drawing.Size(275, 426);
            this.panelTravego.TabIndex = 3;
            // 
            // panelSetra
            // 
            this.panelSetra.Location = new System.Drawing.Point(181, 167);
            this.panelSetra.Name = "panelSetra";
            this.panelSetra.Size = new System.Drawing.Size(278, 423);
            this.panelSetra.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 602);
            this.Controls.Add(this.panelSetra);
            this.Controls.Add(this.panelTravego);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBoxOtobusTuru);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CBoxOtobusTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTravego;
        private System.Windows.Forms.Panel panelSetra;
    }
}

