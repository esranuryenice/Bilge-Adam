namespace bus_WinForm
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
            this.busType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // busType
            // 
            this.busType.FormattingEnabled = true;
            this.busType.Items.AddRange(new object[] {
            "Mercedes Travego",
            "E403"});
            this.busType.Location = new System.Drawing.Point(20, 30);
            this.busType.Name = "busType";
            this.busType.Size = new System.Drawing.Size(150, 21);
            this.busType.TabIndex = 0;
            this.busType.SelectedIndexChanged += new System.EventHandler(this.busType_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 474);
            this.Controls.Add(this.busType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox busType;
    }
}

