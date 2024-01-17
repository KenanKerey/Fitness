using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Fitness
{
    public partial class Uye_goruntule : Form
    {
        public Uye_goruntule()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\QP\Documents\FitnessDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void uyeler()
        {
            baglanti.Open();
            string query = "select *from Uyetbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            Uye_listele.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Uye_goruntule_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            home_page home_Page = new home_page();
            home_Page.Show();
            this.Hide();
        }
        private void AdFiltrele()
        {
            baglanti.Open();
            string query = "select *from Uyetbl where UAdSoyad='" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            Uye_listele.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void bt_ekle_Click(object sender, EventArgs e)
        {
            AdFiltrele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyeler();
            textBox1.Text = "";
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
