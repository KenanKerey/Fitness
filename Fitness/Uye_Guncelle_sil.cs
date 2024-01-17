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
    public partial class Uye_Guncelle_sil : Form
    {
        public Uye_Guncelle_sil()
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
        private void Uye_Guncelle_sil_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_geri_Click(object sender, EventArgs e)
        {
            home_page home = new home_page();
            home.Show();
            this.Hide();
        }
        int key = 0;
        private void Uye_listele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(Uye_listele.SelectedRows[0].Cells[0].Value.ToString());
            AdSoaydTb.Text = Uye_listele.SelectedRows[0].Cells[1].Value.ToString();
            TelefonTb.Text = Uye_listele.SelectedRows[0].Cells[2].Value.ToString();

            CinsiyetCb.Text = Uye_listele.SelectedRows[0].Cells[3].Value.ToString();
            YasTb.Text = Uye_listele.SelectedRows[0].Cells[4].Value.ToString();
            TutarTb.Text = Uye_listele.SelectedRows[0].Cells[5].Value.ToString();

            ZamanCb.Text = Uye_listele.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silincek Öğeyi Seçiniz");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from Uyetbl where UId= " + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla Silindi");
                    baglanti.Close();
                    uyeler();

                    AdSoaydTb.Text = "";
                    TelefonTb.Text = "";
                    YasTb.Text = "";
                    TutarTb.Text = "";
                    CinsiyetCb.Text = "";
                    ZamanCb.Text = "";

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            AdSoaydTb.Text = "";
            TelefonTb.Text = "";
            YasTb.Text = "";
            TutarTb.Text = "";
            CinsiyetCb.Text = "";
            ZamanCb.Text = "";
        }

        private void bt_ekle_Click(object sender, EventArgs e)
        {
            if (key == 0 || AdSoaydTb.Text == "" || TelefonTb.Text == "" || TutarTb.Text == "" || YasTb.Text == "" || CinsiyetCb.Text == "" || ZamanCb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();

                    string query = "update Uyetbl set UAdSoyad='" + AdSoaydTb.Text + "',UYas='" + YasTb.Text + "',UCinsiyet='" + CinsiyetCb.Text + "',UTelefon=" + TelefonTb.Text + ",UOdeme='" + TutarTb.Text + "',UZaman='" + ZamanCb.Text + "' where UId=" + key + ";";









                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla Güncellendi");
                    baglanti.Close();
                    uyeler();
                    AdSoaydTb.Text = "";
                    TelefonTb.Text = "";
                    YasTb.Text = "";
                    TutarTb.Text = "";
                    CinsiyetCb.Text = "";
                    ZamanCb.Text = "";

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void CinsiyetCb_SelectedIndexChanged(object sender, EventArgs e)
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
