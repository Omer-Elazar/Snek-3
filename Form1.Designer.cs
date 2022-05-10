namespace Snek
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
            this.Scoretxt = new System.Windows.Forms.Label();
            this.HighScoretxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Startbtn = new System.Windows.Forms.Button();
            this.Pausebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Snapbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GoldenTimer = new System.Windows.Forms.Timer(this.components);
            this.Loadbtn = new System.Windows.Forms.Button();
            this.Applebtn = new System.Windows.Forms.RadioButton();
            this.Goldenbtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Scoretxt
            // 
            this.Scoretxt.AutoSize = true;
            this.Scoretxt.BackColor = System.Drawing.Color.White;
            this.Scoretxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Scoretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoretxt.Location = new System.Drawing.Point(12, 69);
            this.Scoretxt.Name = "Scoretxt";
            this.Scoretxt.Size = new System.Drawing.Size(97, 22);
            this.Scoretxt.TabIndex = 0;
            this.Scoretxt.Text = "Score:          ";
            // 
            // HighScoretxt
            // 
            this.HighScoretxt.AutoSize = true;
            this.HighScoretxt.BackColor = System.Drawing.Color.White;
            this.HighScoretxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HighScoretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoretxt.Location = new System.Drawing.Point(148, 69);
            this.HighScoretxt.Name = "HighScoretxt";
            this.HighScoretxt.Size = new System.Drawing.Size(130, 22);
            this.HighScoretxt.TabIndex = 1;
            this.HighScoretxt.Text = "HighScore:          ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(12, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 580);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Startbtn
            // 
            this.Startbtn.Location = new System.Drawing.Point(12, 12);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(75, 34);
            this.Startbtn.TabIndex = 3;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // Pausebtn
            // 
            this.Pausebtn.Enabled = false;
            this.Pausebtn.Location = new System.Drawing.Point(148, 12);
            this.Pausebtn.Name = "Pausebtn";
            this.Pausebtn.Size = new System.Drawing.Size(75, 34);
            this.Pausebtn.TabIndex = 4;
            this.Pausebtn.Text = "Pause";
            this.Pausebtn.UseVisualStyleBackColor = true;
            this.Pausebtn.Click += new System.EventHandler(this.Pausebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Enabled = false;
            this.Savebtn.Location = new System.Drawing.Point(288, 12);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 34);
            this.Savebtn.TabIndex = 5;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Snapbtn
            // 
            this.Snapbtn.Location = new System.Drawing.Point(534, 12);
            this.Snapbtn.Name = "Snapbtn";
            this.Snapbtn.Size = new System.Drawing.Size(75, 34);
            this.Snapbtn.TabIndex = 6;
            this.Snapbtn.Text = "Snap";
            this.Snapbtn.UseVisualStyleBackColor = true;
            this.Snapbtn.Click += new System.EventHandler(this.Snapbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // GoldenTimer
            // 
            this.GoldenTimer.Interval = 5000;
            this.GoldenTimer.Tick += new System.EventHandler(this.GoldenTimerTick);
            // 
            // Loadbtn
            // 
            this.Loadbtn.Location = new System.Drawing.Point(413, 12);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(75, 34);
            this.Loadbtn.TabIndex = 7;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // Applebtn
            // 
            this.Applebtn.AutoSize = true;
            this.Applebtn.Location = new System.Drawing.Point(351, 67);
            this.Applebtn.Name = "Applebtn";
            this.Applebtn.Size = new System.Drawing.Size(75, 24);
            this.Applebtn.TabIndex = 8;
            this.Applebtn.TabStop = true;
            this.Applebtn.Text = "Apple";
            this.Applebtn.UseVisualStyleBackColor = true;
            // 
            // Goldenbtn
            // 
            this.Goldenbtn.AutoSize = true;
            this.Goldenbtn.Location = new System.Drawing.Point(483, 67);
            this.Goldenbtn.Name = "Goldenbtn";
            this.Goldenbtn.Size = new System.Drawing.Size(131, 24);
            this.Goldenbtn.TabIndex = 9;
            this.Goldenbtn.TabStop = true;
            this.Goldenbtn.Text = "Golden Apple";
            this.Goldenbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 744);
            this.Controls.Add(this.Goldenbtn);
            this.Controls.Add(this.Applebtn);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.Snapbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Pausebtn);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HighScoretxt);
            this.Controls.Add(this.Scoretxt);
            this.MaximumSize = new System.Drawing.Size(700, 800);
            this.MinimumSize = new System.Drawing.Size(700, 800);
            this.Name = "Form1";
            this.Text = "Snek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.Button Pausebtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Snapbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer GoldenTimer;
        public System.Windows.Forms.Label Scoretxt;
        public System.Windows.Forms.Label HighScoretxt;
        private System.Windows.Forms.Button Loadbtn;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton Applebtn;
        private System.Windows.Forms.RadioButton Goldenbtn;
    }
}

