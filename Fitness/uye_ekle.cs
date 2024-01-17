using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Devices;

namespace Fitness
{
    public partial class uye_ekle : Form
    {
        public uye_ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\QP\Documents\FitnessDb.mdf;Integrated Security=True;Connect Timeout=30");


        public void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bt_ekle_Click(object sender, EventArgs e)
        {
            if (AdSoaydTb.Text == "" || TelefonTb.Text == "" || TutarTb.Text == "" || YasTb.Text == "" || CinsiyetCb.Text == "" || ZamanCb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into Uyetbl values('" + AdSoaydTb.Text + "','" + TelefonTb.Text + "','" + CinsiyetCb.SelectedItem.ToString() + "','" + YasTb.Text + "','" + TutarTb.Text + "','" + ZamanCb.SelectedItem.ToString() + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Eklendi");
                    baglanti.Close();
                    AdSoaydTb.Text = "";
                    YasTb.Text = "";
                    TutarTb.Text = "";
                    TelefonTb.Text = "";
                    CinsiyetCb.Text = "";
                    ZamanCb.Text = "";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            AdSoaydTb.Text = "";
            YasTb.Text = "";
            TutarTb.Text = "";
            TelefonTb.Text = "";
            CinsiyetCb.Text = "";
            ZamanCb.Text = "";

        }

        private void bt_geri_Click(object sender, EventArgs e)
        {
            home_page home = new home_page();
            home.Show();
            this.Hide();
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
