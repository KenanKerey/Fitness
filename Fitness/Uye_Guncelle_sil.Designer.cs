namespace Fitness
{
    partial class Uye_Guncelle_sil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uye_Guncelle_sil));
            pictureBox1 = new PictureBox();
            CinsiyetCb = new ComboBox();
            ZamanCb = new ComboBox();
            TutarTb = new TextBox();
            YasTb = new TextBox();
            TelefonTb = new TextBox();
            AdSoaydTb = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Uye_listele = new DataGridView();
            bt_geri = new Button();
            bt_reset = new Button();
            bt_ekle = new Button();
            button1 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Uye_listele).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(721, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // CinsiyetCb
            // 
            CinsiyetCb.FormattingEnabled = true;
            CinsiyetCb.Items.AddRange(new object[] { "Erkek", "Kadın" });
            CinsiyetCb.Location = new Point(4, 235);
            CinsiyetCb.Name = "CinsiyetCb";
            CinsiyetCb.Size = new Size(197, 23);
            CinsiyetCb.TabIndex = 4;
            CinsiyetCb.SelectedIndexChanged += CinsiyetCb_SelectedIndexChanged;
            // 
            // ZamanCb
            // 
            ZamanCb.FormattingEnabled = true;
            ZamanCb.Items.AddRange(new object[] { "İstediği Zaman" });
            ZamanCb.Location = new Point(578, 236);
            ZamanCb.Name = "ZamanCb";
            ZamanCb.Size = new Size(196, 23);
            ZamanCb.TabIndex = 6;
            // 
            // TutarTb
            // 
            TutarTb.Location = new Point(290, 236);
            TutarTb.Multiline = true;
            TutarTb.Name = "TutarTb";
            TutarTb.Size = new Size(197, 32);
            TutarTb.TabIndex = 5;
            // 
            // YasTb
            // 
            YasTb.Location = new Point(578, 121);
            YasTb.Multiline = true;
            YasTb.Name = "YasTb";
            YasTb.Size = new Size(197, 32);
            YasTb.TabIndex = 3;
            // 
            // TelefonTb
            // 
            TelefonTb.Location = new Point(290, 121);
            TelefonTb.Multiline = true;
            TelefonTb.Name = "TelefonTb";
            TelefonTb.Size = new Size(197, 32);
            TelefonTb.TabIndex = 2;
            // 
            // AdSoaydTb
            // 
            AdSoaydTb.Location = new Point(4, 121);
            AdSoaydTb.Multiline = true;
            AdSoaydTb.Name = "AdSoaydTb";
            AdSoaydTb.Size = new Size(197, 32);
            AdSoaydTb.TabIndex = 1;
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(578, 215);
            label8.Name = "label8";
            label8.Size = new Size(143, 27);
            label8.TabIndex = 28;
            label8.Text = "Zamanlama";
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(290, 215);
            label7.Name = "label7";
            label7.Size = new Size(143, 27);
            label7.TabIndex = 27;
            label7.Text = "Aylık Tutar";
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(4, 215);
            label6.Name = "label6";
            label6.Size = new Size(143, 27);
            label6.TabIndex = 26;
            label6.Text = "Cinsiyet";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(578, 100);
            label5.Name = "label5";
            label5.Size = new Size(143, 27);
            label5.TabIndex = 25;
            label5.Text = "Yaş";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(290, 102);
            label4.Name = "label4";
            label4.Size = new Size(143, 27);
            label4.TabIndex = 24;
            label4.Text = "Telefon Numarası";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(4, 100);
            label3.Name = "label3";
            label3.Size = new Size(130, 27);
            label3.TabIndex = 23;
            label3.Text = "Üye Adı Soyadı";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(331, 49);
            label2.Name = "label2";
            label2.Size = new Size(167, 27);
            label2.TabIndex = 22;
            label2.Text = "Üye Güncelle/Sil";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(321, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 40);
            label1.TabIndex = 21;
            label1.Text = "Kerey Fitness";
            // 
            // Uye_listele
            // 
            Uye_listele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Uye_listele.Location = new Point(22, 274);
            Uye_listele.Name = "Uye_listele";
            Uye_listele.RowTemplate.Height = 25;
            Uye_listele.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Uye_listele.Size = new Size(727, 214);
            Uye_listele.TabIndex = 36;
            Uye_listele.CellContentClick += Uye_listele_CellContentClick;
            // 
            // bt_geri
            // 
            bt_geri.BackColor = Color.FromArgb(192, 0, 0);
            bt_geri.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_geri.Location = new Point(539, 508);
            bt_geri.Name = "bt_geri";
            bt_geri.Size = new Size(103, 50);
            bt_geri.TabIndex = 39;
            bt_geri.Text = "Geri";
            bt_geri.UseVisualStyleBackColor = false;
            bt_geri.Click += bt_geri_Click;
            // 
            // bt_reset
            // 
            bt_reset.BackColor = Color.FromArgb(192, 0, 0);
            bt_reset.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_reset.Location = new Point(290, 508);
            bt_reset.Name = "bt_reset";
            bt_reset.Size = new Size(103, 50);
            bt_reset.TabIndex = 38;
            bt_reset.Text = "Reset";
            bt_reset.UseVisualStyleBackColor = false;
            bt_reset.Click += bt_reset_Click;
            // 
            // bt_ekle
            // 
            bt_ekle.BackColor = Color.FromArgb(192, 0, 0);
            bt_ekle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_ekle.Location = new Point(168, 508);
            bt_ekle.Name = "bt_ekle";
            bt_ekle.Size = new Size(103, 50);
            bt_ekle.TabIndex = 37;
            bt_ekle.Text = "Güncelle";
            bt_ekle.UseVisualStyleBackColor = false;
            bt_ekle.Click += bt_ekle_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(416, 508);
            button1.Name = "button1";
            button1.Size = new Size(103, 50);
            button1.TabIndex = 337;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 61);
            panel1.TabIndex = 338;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // Uye_Guncelle_sil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 570);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(bt_geri);
            Controls.Add(bt_reset);
            Controls.Add(bt_ekle);
            Controls.Add(Uye_listele);
            Controls.Add(CinsiyetCb);
            Controls.Add(ZamanCb);
            Controls.Add(TutarTb);
            Controls.Add(YasTb);
            Controls.Add(TelefonTb);
            Controls.Add(AdSoaydTb);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Uye_Guncelle_sil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uye_Guncelle_sil";
            Load += Uye_Guncelle_sil_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Uye_listele).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox CinsiyetCb;
        private ComboBox ZamanCb;
        private TextBox TutarTb;
        private TextBox YasTb;
        private TextBox TelefonTb;
        private TextBox AdSoaydTb;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView Uye_listele;
        private Button bt_geri;
        private Button bt_reset;
        private Button bt_ekle;
        private Button button1;
        private Panel panel1;
    }
}