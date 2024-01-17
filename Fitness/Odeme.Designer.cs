namespace Fitness
{
    partial class Odeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odeme));
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            OdemeTb = new TextBox();
            label4 = new Label();
            Periyot = new DateTimePicker();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            OdemeDGV = new DataGridView();
            AdSoaydCb = new ComboBox();
            AraTb = new TextBox();
            Arabt = new Button();
            Yenilebt = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OdemeDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(316, 49);
            label2.Name = "label2";
            label2.Size = new Size(164, 27);
            label2.TabIndex = 5;
            label2.Text = "Ödemeler";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(302, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 40);
            label1.TabIndex = 4;
            label1.Text = "Kerey Fitness";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 244);
            label3.Name = "label3";
            label3.Size = new Size(130, 27);
            label3.TabIndex = 9;
            label3.Text = "Üye Adı Soyadı";
            // 
            // OdemeTb
            // 
            OdemeTb.Location = new Point(12, 330);
            OdemeTb.Multiline = true;
            OdemeTb.Name = "OdemeTb";
            OdemeTb.Size = new Size(197, 32);
            OdemeTb.TabIndex = 12;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 309);
            label4.Name = "label4";
            label4.Size = new Size(130, 27);
            label4.TabIndex = 11;
            label4.Text = "Tutar";
            // 
            // Periyot
            // 
            Periyot.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Periyot.Format = DateTimePickerFormat.Short;
            Periyot.Location = new Point(12, 203);
            Periyot.Name = "Periyot";
            Periyot.Size = new Size(134, 29);
            Periyot.TabIndex = 14;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 177);
            label5.Name = "label5";
            label5.Size = new Size(130, 23);
            label5.TabIndex = 15;
            label5.Text = "Ödeme Ayı";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 395);
            button2.Name = "button2";
            button2.Size = new Size(87, 50);
            button2.TabIndex = 25;
            button2.Text = "Ödeme";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(122, 395);
            button1.Name = "button1";
            button1.Size = new Size(87, 50);
            button1.TabIndex = 24;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(734, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(238, 395);
            button3.Name = "button3";
            button3.Size = new Size(87, 50);
            button3.TabIndex = 27;
            button3.Text = "Geri";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // OdemeDGV
            // 
            OdemeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OdemeDGV.Location = new Point(238, 166);
            OdemeDGV.Name = "OdemeDGV";
            OdemeDGV.RowTemplate.Height = 25;
            OdemeDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OdemeDGV.Size = new Size(542, 214);
            OdemeDGV.TabIndex = 28;
            // 
            // AdSoaydCb
            // 
            AdSoaydCb.FormattingEnabled = true;
            AdSoaydCb.Location = new Point(12, 274);
            AdSoaydCb.Name = "AdSoaydCb";
            AdSoaydCb.Size = new Size(161, 23);
            AdSoaydCb.TabIndex = 29;
            // 
            // AraTb
            // 
            AraTb.Location = new Point(316, 102);
            AraTb.Multiline = true;
            AraTb.Name = "AraTb";
            AraTb.Size = new Size(184, 32);
            AraTb.TabIndex = 30;
            // 
            // Arabt
            // 
            Arabt.BackColor = Color.FromArgb(192, 0, 0);
            Arabt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Arabt.Location = new Point(523, 93);
            Arabt.Name = "Arabt";
            Arabt.Size = new Size(87, 50);
            Arabt.TabIndex = 31;
            Arabt.Text = "Ara";
            Arabt.UseVisualStyleBackColor = false;
            Arabt.Click += Arabt_Click;
            // 
            // Yenilebt
            // 
            Yenilebt.BackColor = Color.FromArgb(192, 0, 0);
            Yenilebt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Yenilebt.Location = new Point(636, 93);
            Yenilebt.Name = "Yenilebt";
            Yenilebt.Size = new Size(87, 50);
            Yenilebt.TabIndex = 32;
            Yenilebt.Text = "Yenile";
            Yenilebt.UseVisualStyleBackColor = false;
            Yenilebt.Click += Yenilebt_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 51);
            panel1.TabIndex = 33;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // Odeme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 479);
            Controls.Add(Yenilebt);
            Controls.Add(Arabt);
            Controls.Add(AraTb);
            Controls.Add(AdSoaydCb);
            Controls.Add(OdemeDGV);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(Periyot);
            Controls.Add(OdemeTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Odeme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Odeme";
            Load += Odeme_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)OdemeDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox OdemeTb;
        private Label label4;
        private DateTimePicker Periyot;
        private Label label5;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button3;
        private DataGridView OdemeDGV;
        private ComboBox AdSoaydCb;
        private TextBox AraTb;
        private Button Arabt;
        private Button Yenilebt;
        private Panel panel1;
    }
}