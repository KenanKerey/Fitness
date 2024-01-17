using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness
{
    public partial class home_page : Form
    {
        public home_page()
        {
            InitializeComponent();
        }

        private void home_page_Load(object sender, EventArgs e)
        {

        }

        private void bt_odeme_Click(object sender, EventArgs e)
        {
            Odeme odeme = new Odeme();
            odeme.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_uye_ekle_Click(object sender, EventArgs e)
        {
            uye_ekle uye_ekle = new uye_ekle();
            uye_ekle.Show();
            this.Hide();
        }

        private void bt_guncelle_Click(object sender, EventArgs e)
        {
            Uye_Guncelle_sil uye = new Uye_Guncelle_sil();
            uye.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uye_goruntule uye = new Uye_goruntule();
            uye.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        int Move;
        int Mouse_X;
        int Mouse_Y;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
    }
}
