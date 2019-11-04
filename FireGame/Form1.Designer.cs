namespace FireGame
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.Player_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Shoot = new System.Windows.Forms.Button();
            this.Spinner = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnPlayer);
            this.groupBox1.Controls.Add(this.Player_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Player Name";
            // 
            // btnPlayer
            // 
            this.btnPlayer.BackColor = System.Drawing.Color.DimGray;
            this.btnPlayer.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer.ForeColor = System.Drawing.Color.White;
            this.btnPlayer.Location = new System.Drawing.Point(152, 135);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(106, 43);
            this.btnPlayer.TabIndex = 2;
            this.btnPlayer.Text = "Enter ";
            this.btnPlayer.UseVisualStyleBackColor = false;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // Player_Name
            // 
            this.Player_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Name.Location = new System.Drawing.Point(215, 39);
            this.Player_Name.Name = "Player_Name";
            this.Player_Name.Size = new System.Drawing.Size(131, 35);
            this.Player_Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Player Name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Shoot);
            this.groupBox2.Controls.Add(this.Spinner);
            this.groupBox2.Controls.Add(this.Load);
            this.groupBox2.Controls.Add(this.pictureBox);
            this.groupBox2.Location = new System.Drawing.Point(402, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 364);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Shoot
            // 
            this.Shoot.BackColor = System.Drawing.Color.DimGray;
            this.Shoot.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shoot.ForeColor = System.Drawing.Color.White;
            this.Shoot.Location = new System.Drawing.Point(116, 300);
            this.Shoot.Name = "Shoot";
            this.Shoot.Size = new System.Drawing.Size(128, 43);
            this.Shoot.TabIndex = 5;
            this.Shoot.Text = "Shoot";
            this.Shoot.UseVisualStyleBackColor = false;
            this.Shoot.Click += new System.EventHandler(this.Shoot_Click);
            // 
            // Spinner
            // 
            this.Spinner.BackColor = System.Drawing.Color.DimGray;
            this.Spinner.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spinner.ForeColor = System.Drawing.Color.White;
            this.Spinner.Location = new System.Drawing.Point(203, 251);
            this.Spinner.Name = "Spinner";
            this.Spinner.Size = new System.Drawing.Size(106, 43);
            this.Spinner.TabIndex = 4;
            this.Spinner.Text = "Spin";
            this.Spinner.UseVisualStyleBackColor = false;
            this.Spinner.Click += new System.EventHandler(this.Spinner_Click);
            // 
            // Load
            // 
            this.Load.BackColor = System.Drawing.Color.DimGray;
            this.Load.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load.ForeColor = System.Drawing.Color.White;
            this.Load.Location = new System.Drawing.Point(74, 251);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(106, 43);
            this.Load.TabIndex = 3;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = false;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(74, 37);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(235, 208);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackColor = System.Drawing.Color.DimGray;
            this.PlayAgain.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain.ForeColor = System.Drawing.Color.White;
            this.PlayAgain.Location = new System.Drawing.Point(69, 252);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(285, 43);
            this.PlayAgain.TabIndex = 3;
            this.PlayAgain.Text = "Click Here to Play Again";
            this.PlayAgain.UseVisualStyleBackColor = false;
            this.PlayAgain.Visible = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(460, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Shoot Away";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Player_Name;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Spinner;
        private System.Windows.Forms.Button Shoot;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.Button button1;
    }
}

