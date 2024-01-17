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

namespace Fitness
{
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\QP\Documents\FitnessDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillName()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select UAdSoyad from Uyetbl", baglanti);
            SqlDataReader reader;
            reader = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("UAdSoyad", typeof(string));
            dt.Load(reader);
            AdSoaydCb.ValueMember = "UAdSoyad";
            AdSoaydCb.DataSource = dt;
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            home_page home = new home_page();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdSoaydCb.Text = "";
            OdemeTb.Text = "";

        }
        private void AdFiltrele()
        {
            baglanti.Open();
            string query = "select *from OdemeTbl where OUye='" + AraTb.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            OdemeDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void uyeler()
        {
            baglanti.Open();
            string query = "select *from OdemeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            OdemeDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AdSoaydCb.Text == "" || OdemeTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {


                //string odemeper =Periyot.Value.Day.ToString()+ Periyot.Value.Month.ToString() + Periyot.Value.Year.ToString();
                string odemeper = Periyot.Value.ToString("dd.MM.yyyy");

                baglanti.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from OdemeTbl where OUye='" + AdSoaydCb.SelectedValue.ToString() + "' and OAy='" + odemeper + "'", baglanti);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Zaten Ödeme Yaptı");
                }
                else
                {
                    string query = "insert into OdemeTbl values('" + odemeper + "','" + AdSoaydCb.SelectedValue.ToString() + "'," + OdemeTb.Text + ")";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Tutar Başarıyla Ödendi");


                }
                baglanti.Close();
                uyeler();
            }
        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            FillName();
            uyeler();
        }

        private void Arabt_Click(object sender, EventArgs e)
        {
            AdFiltrele();
        }

        private void Yenilebt_Click(object sender, EventArgs e)
        {
            uyeler();
            AraTb.Text = "";
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
