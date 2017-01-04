namespace UniPortal
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
            this.comboBoxChoose = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxChoose
            // 
            this.comboBoxChoose.FormattingEnabled = true;
            this.comboBoxChoose.Items.AddRange(new object[] {
            "Student",
            "Instructor"});
            this.comboBoxChoose.Location = new System.Drawing.Point(18, 34);
            this.comboBoxChoose.Name = "comboBoxChoose";
            this.comboBoxChoose.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChoose.TabIndex = 0;
            this.comboBoxChoose.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoose_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Person: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 117);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxChoose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChoose;
        private System.Windows.Forms.Label label1;
    }
}

