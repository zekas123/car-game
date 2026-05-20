namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bg1 = new PictureBox();
            palyer = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            bg2 = new PictureBox();
            enemy2 = new PictureBox();
            enemy1 = new PictureBox();
            labelLouse = new Label();
            btnrestart = new Button();
            coin = new PictureBox();
            labelcoins = new Label();
            ((System.ComponentModel.ISupportInitialize)bg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)palyer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bg2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin).BeginInit();
            SuspendLayout();
            // 
            // bg1
            // 
            bg1.Image = (Image)resources.GetObject("bg1.Image");
            bg1.Location = new Point(1, -2);
            bg1.Name = "bg1";
            bg1.Size = new Size(840, 650);
            bg1.TabIndex = 0;
            bg1.TabStop = false;
            // 
            // palyer
            // 
            palyer.BackColor = Color.Transparent;
            palyer.Image = (Image)resources.GetObject("palyer.Image");
            palyer.Location = new Point(422, 475);
            palyer.Name = "palyer";
            palyer.Size = new Size(128, 163);
            palyer.SizeMode = PictureBoxSizeMode.StretchImage;
            palyer.TabIndex = 1;
            palyer.TabStop = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20;
            timer.Tag = "";
            timer.Tick += timer_Tick;
            // 
            // bg2
            // 
            bg2.Image = (Image)resources.GetObject("bg2.Image");
            bg2.Location = new Point(0, -650);
            bg2.Name = "bg2";
            bg2.Size = new Size(840, 650);
            bg2.TabIndex = 2;
            bg2.TabStop = false;
            // 
            // enemy2
            // 
            enemy2.BackColor = SystemColors.ControlDarkDark;
            enemy2.Image = (Image)resources.GetObject("enemy2.Image");
            enemy2.Location = new Point(163, -400);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(128, 163);
            enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy2.TabIndex = 3;
            enemy2.TabStop = false;
            // 
            // enemy1
            // 
            enemy1.BackColor = SystemColors.ControlDarkDark;
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(524, -130);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(128, 163);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 4;
            enemy1.TabStop = false;
            // 
            // labelLouse
            // 
            labelLouse.AutoSize = true;
            labelLouse.BackColor = Color.Maroon;
            labelLouse.FlatStyle = FlatStyle.Flat;
            labelLouse.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLouse.ForeColor = Color.Black;
            labelLouse.Location = new Point(209, 181);
            labelLouse.Margin = new Padding(5, 0, 3, 0);
            labelLouse.Name = "labelLouse";
            labelLouse.Size = new Size(424, 79);
            labelLouse.TabIndex = 5;
            labelLouse.Text = "You Louse! ";
            // 
            // btnrestart
            // 
            btnrestart.BackColor = SystemColors.ControlDarkDark;
            btnrestart.FlatStyle = FlatStyle.Flat;
            btnrestart.Font = new Font("Rockwell Extra Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnrestart.Location = new Point(305, 294);
            btnrestart.Name = "btnrestart";
            btnrestart.Size = new Size(245, 104);
            btnrestart.TabIndex = 6;
            btnrestart.Text = "louse again";
            btnrestart.UseVisualStyleBackColor = false;
            btnrestart.Click += btnrestart_Click;
            // 
            // coin
            // 
            coin.Image = (Image)resources.GetObject("coin.Image");
            coin.Location = new Point(639, -600);
            coin.Name = "coin";
            coin.Size = new Size(100, 82);
            coin.SizeMode = PictureBoxSizeMode.StretchImage;
            coin.TabIndex = 7;
            coin.TabStop = false;
            // 
            // labelcoins
            // 
            labelcoins.AutoSize = true;
            labelcoins.BackColor = Color.Maroon;
            labelcoins.FlatStyle = FlatStyle.Flat;
            labelcoins.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelcoins.ForeColor = Color.Black;
            labelcoins.Location = new Point(14, 9);
            labelcoins.Margin = new Padding(5, 0, 3, 0);
            labelcoins.Name = "labelcoins";
            labelcoins.Size = new Size(182, 46);
            labelcoins.TabIndex = 8;
            labelcoins.Text = "Coins: 0 ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(840, 650);
            Controls.Add(labelcoins);
            Controls.Add(coin);
            Controls.Add(btnrestart);
            Controls.Add(labelLouse);
            Controls.Add(enemy1);
            Controls.Add(enemy2);
            Controls.Add(palyer);
            Controls.Add(bg1);
            Controls.Add(bg2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)bg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)palyer).EndInit();
            ((System.ComponentModel.ISupportInitialize)bg2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private PictureBox bg1;
        private PictureBox palyer;
        internal System.Windows.Forms.Timer timer;
        private PictureBox bg2;
        private PictureBox enemy2;
        private PictureBox enemy1;
        private Label labelLouse;
        private Button btnrestart;
        private PictureBox coin;
        private Label labelcoins;
    }
}
