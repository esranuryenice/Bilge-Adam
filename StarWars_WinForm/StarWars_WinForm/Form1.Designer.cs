namespace StarWars_WinForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Spaceship = new System.Windows.Forms.PictureBox();
            this.rocket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wallRight = new System.Windows.Forms.Label();
            this.wallUp = new System.Windows.Forms.Label();
            this.wallLeft = new System.Windows.Forms.Label();
            this.wallDown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Spaceship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).BeginInit();
            this.SuspendLayout();
            // 
            // Spaceship
            // 
            this.Spaceship.BackColor = System.Drawing.Color.Transparent;
            this.Spaceship.Image = ((System.Drawing.Image)(resources.GetObject("Spaceship.Image")));
            this.Spaceship.Location = new System.Drawing.Point(238, 106);
            this.Spaceship.Name = "Spaceship";
            this.Spaceship.Size = new System.Drawing.Size(80, 74);
            this.Spaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Spaceship.TabIndex = 0;
            this.Spaceship.TabStop = false;
            // 
            // rocket
            // 
            this.rocket.BackColor = System.Drawing.Color.Transparent;
            this.rocket.Image = ((System.Drawing.Image)(resources.GetObject("rocket.Image")));
            this.rocket.Location = new System.Drawing.Point(151, 42);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(19, 19);
            this.rocket.TabIndex = 1;
            this.rocket.TabStop = false;
            this.rocket.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // wallRight
            // 
            this.wallRight.BackColor = System.Drawing.Color.Transparent;
            this.wallRight.Location = new System.Drawing.Point(562, 2);
            this.wallRight.Name = "wallRight";
            this.wallRight.Size = new System.Drawing.Size(10, 295);
            this.wallRight.TabIndex = 2;
            this.wallRight.Text = "label1";
            // 
            // wallUp
            // 
            this.wallUp.BackColor = System.Drawing.Color.Transparent;
            this.wallUp.Location = new System.Drawing.Point(1, 1);
            this.wallUp.Name = "wallUp";
            this.wallUp.Size = new System.Drawing.Size(571, 10);
            this.wallUp.TabIndex = 3;
            this.wallUp.Text = "label1";
            // 
            // wallLeft
            // 
            this.wallLeft.BackColor = System.Drawing.Color.Transparent;
            this.wallLeft.Location = new System.Drawing.Point(1, 2);
            this.wallLeft.Name = "wallLeft";
            this.wallLeft.Size = new System.Drawing.Size(10, 295);
            this.wallLeft.TabIndex = 4;
            this.wallLeft.Text = "label1";
            // 
            // wallDown
            // 
            this.wallDown.BackColor = System.Drawing.Color.Transparent;
            this.wallDown.Location = new System.Drawing.Point(1, 287);
            this.wallDown.Name = "wallDown";
            this.wallDown.Size = new System.Drawing.Size(571, 10);
            this.wallDown.TabIndex = 5;
            this.wallDown.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 298);
            this.Controls.Add(this.rocket);
            this.Controls.Add(this.Spaceship);
            this.Controls.Add(this.wallRight);
            this.Controls.Add(this.wallDown);
            this.Controls.Add(this.wallUp);
            this.Controls.Add(this.wallLeft);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(590, 337);
            this.MinimumSize = new System.Drawing.Size(590, 337);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Spaceship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Spaceship;
        private System.Windows.Forms.PictureBox rocket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label wallRight;
        private System.Windows.Forms.Label wallUp;
        private System.Windows.Forms.Label wallLeft;
        private System.Windows.Forms.Label wallDown;
    }
}

