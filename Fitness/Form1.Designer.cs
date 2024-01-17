namespace Fitness
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tb_username = new TextBox();
            tb_pass = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            bt_login = new Button();
            bt_reset = new Button();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(227, 8);
            label1.Name = "label1";
            label1.Size = new Size(189, 34);
            label1.TabIndex = 15;
            label1.Text = "KEREY FİTNESS";
            // 
            // tb_username
            // 
            tb_username.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tb_username.Location = new Point(291, 88);
            tb_username.Multiline = true;
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(191, 33);
            tb_username.TabIndex = 2;
            // 
            // tb_pass
            // 
            tb_pass.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tb_pass.Location = new Point(291, 139);
            tb_pass.Multiline = true;
            tb_pass.Name = "tb_pass";
            tb_pass.PasswordChar = '*';
            tb_pass.Size = new Size(191, 33);
            tb_pass.TabIndex = 3;
            tb_pass.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(475, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(475, 140);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // bt_login
            // 
            bt_login.BackColor = Color.FromArgb(0, 192, 0);
            bt_login.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_login.Location = new Point(291, 207);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(87, 50);
            bt_login.TabIndex = 6;
            bt_login.Text = "Login";
            bt_login.UseVisualStyleBackColor = false;
            bt_login.Click += bt_login_Click;
            // 
            // bt_reset
            // 
            bt_reset.BackColor = Color.FromArgb(192, 0, 0);
            bt_reset.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_reset.Location = new Point(440, 207);
            bt_reset.Name = "bt_reset";
            bt_reset.Size = new Size(87, 50);
            bt_reset.TabIndex = 7;
            bt_reset.Text = "Reset";
            bt_reset.UseVisualStyleBackColor = false;
            bt_reset.Click += bt_reset_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(538, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(54, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 48);
            panel1.TabIndex = 23;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 311);
            Controls.Add(panel1);
            Controls.Add(bt_reset);
            Controls.Add(bt_login);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(tb_pass);
            Controls.Add(tb_username);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tb_username;
        private TextBox tb_pass;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button bt_login;
        private Button bt_reset;
        private PictureBox pictureBox4;
        private Panel panel1;
    }
}