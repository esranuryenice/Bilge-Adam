namespace UniPortal
{
    partial class InstructorForm
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
            this.dataGridViewInstructor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInstructor
            // 
            this.dataGridViewInstructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstructor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewInstructor.Location = new System.Drawing.Point(12, 206);
            this.dataGridViewInstructor.Name = "dataGridViewInstructor";
            this.dataGridViewInstructor.ReadOnly = true;
            this.dataGridViewInstructor.Size = new System.Drawing.Size(344, 180);
            this.dataGridViewInstructor.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Surname";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phone Number";
            this.Column3.Name = "Column3";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(96, 68);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(257, 20);
            this.textBoxPhoneNumber.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Phone Number";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(96, 37);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(257, 20);
            this.textBoxSurname.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Surname";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(96, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(257, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(96, 166);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(257, 23);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(96, 101);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(257, 20);
            this.textBoxDepartment.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Department";
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(96, 131);
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(257, 20);
            this.textBoxTask.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Task";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Department";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Task";
            this.Column5.Name = "Column5";
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 398);
            this.Controls.Add(this.textBoxTask);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewInstructor);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Name = "InstructorForm";
            this.Text = "InstructorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInstructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}