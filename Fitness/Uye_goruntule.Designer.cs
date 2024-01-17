namespace Fitness
{
    partial class Uye_goruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uye_goruntule));
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            bt_ekle = new Button();
            button1 = new Button();
            Uye_listele = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)Uye_listele).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(311, 49);
            label2.Name = "label2";
            label2.Size = new Size(164, 27);
            label2.TabIndex = 3;
            label2.Text = "Üyelerei Listele";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(297, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 40);
            label1.TabIndex = 2;
            label1.Text = "Kerey Fitness";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 108);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 28);
            textBox1.TabIndex = 4;
            // 
            // bt_ekle
            // 
            bt_ekle.BackColor = Color.FromArgb(192, 0, 0);
            bt_ekle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_ekle.Location = new Point(388, 97);
            bt_ekle.Name = "bt_ekle";
            bt_ekle.Size = new Size(87, 50);
            bt_ekle.TabIndex = 16;
            bt_ekle.Text = "Ara";
            bt_ekle.UseVisualStyleBackColor = false;
            bt_ekle.Click += bt_ekle_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(501, 97);
            button1.Name = "button1";
            button1.Size = new Size(87, 50);
            button1.TabIndex = 17;
            button1.Text = "Yenile";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Uye_listele
            // 
            Uye_listele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Uye_listele.Location = new Point(44, 153);
            Uye_listele.Name = "Uye_listele";
            Uye_listele.RowTemplate.Height = 25;
            Uye_listele.Size = new Size(727, 214);
            Uye_listele.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(734, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(370, 373);
            button2.Name = "button2";
            button2.Size = new Size(87, 50);
            button2.TabIndex = 23;
            button2.Text = "Geri";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 52);
            panel1.TabIndex = 24;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // Uye_goruntule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 430);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Uye_listele);
            Controls.Add(button1);
            Controls.Add(bt_ekle);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Uye_goruntule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uye_goruntule";
            Load += Uye_goruntule_Load;
            ((System.ComponentModel.ISupportInitialize)Uye_listele).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button bt_ekle;
        private Button button1;
        private DataGridView Uye_listele;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button2;
        private Panel panel1;
    }
}