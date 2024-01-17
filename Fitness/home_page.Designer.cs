namespace Fitness
{
    partial class home_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_page));
            panel1 = new Panel();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            bt_odeme = new Button();
            bt_uye_ekle = new Button();
            bt_guncelle = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(bt_odeme);
            panel1.Controls.Add(bt_uye_ekle);
            panel1.Controls.Add(bt_guncelle);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(851, 61);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(344, 14);
            button1.Name = "button1";
            button1.Size = new Size(135, 41);
            button1.TabIndex = 22;
            button1.Text = "Üyeleri Listele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(782, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(661, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // bt_odeme
            // 
            bt_odeme.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_odeme.ForeColor = Color.Red;
            bt_odeme.Location = new Point(500, 14);
            bt_odeme.Name = "bt_odeme";
            bt_odeme.Size = new Size(135, 41);
            bt_odeme.TabIndex = 1;
            bt_odeme.Text = "Ödeme";
            bt_odeme.UseVisualStyleBackColor = true;
            bt_odeme.Click += bt_odeme_Click;
            // 
            // bt_uye_ekle
            // 
            bt_uye_ekle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_uye_ekle.ForeColor = Color.Red;
            bt_uye_ekle.Location = new Point(15, 14);
            bt_uye_ekle.Name = "bt_uye_ekle";
            bt_uye_ekle.Size = new Size(135, 41);
            bt_uye_ekle.TabIndex = 1;
            bt_uye_ekle.Text = "Üye Ekle";
            bt_uye_ekle.UseVisualStyleBackColor = true;
            bt_uye_ekle.Click += bt_uye_ekle_Click;
            // 
            // bt_guncelle
            // 
            bt_guncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_guncelle.ForeColor = Color.Red;
            bt_guncelle.Location = new Point(176, 14);
            bt_guncelle.Name = "bt_guncelle";
            bt_guncelle.Size = new Size(135, 41);
            bt_guncelle.TabIndex = 1;
            bt_guncelle.Text = "Güncelle/Sil";
            bt_guncelle.UseVisualStyleBackColor = true;
            bt_guncelle.Click += bt_guncelle_Click;
            // 
            // home_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(845, 485);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "home_page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "home_page";
            Load += home_page_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bt_uye_ekle;
        private Button bt_guncelle;
        private Button bt_odeme;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
    }
}