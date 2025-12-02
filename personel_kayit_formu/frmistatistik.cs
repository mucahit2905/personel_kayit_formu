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

namespace _11.sql_ile_birleştirme
{
    public partial class frmistatistik : Form
    {
        public frmistatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N2OM1VP;Initial Catalog=dersler;Integrated Security=True;Encrypt=False");
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void frmistatistik_Load(object sender, EventArgs e)
        {
            //toplam personel sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count (*) from tbl_personel",baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read()) {
                lbltoplampersonel.Text = dr1[0].ToString();

            }

            baglanti.Close();

            //evli sayısı

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count (*) from tbl_personel where durum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                lblevli.Text = dr2[0].ToString();

            }

            baglanti.Close();


            //bekar sayısı

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count (*) from tbl_personel where durum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                lblbekar.Text = dr3[0].ToString();

            }

            baglanti.Close();

            //sehir sayisi

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count( distinct (sehir) )from tbl_personel ", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();

            while (dr4.Read())
            {
                lblsehir.Text = dr4[0].ToString();

            }

            baglanti.Close();

            //toplam maaş

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum (maas) from tbl_personel  ", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();

            while (dr5.Read())
            {
                lbltoplammaas.Text = dr5[0].ToString();

            }

            baglanti.Close();


            //ortalama maaş


            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select avg (maas) from tbl_personel  ", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();

            while (dr6.Read())
            {
                lblortalamamaas.Text = dr6[0].ToString();

            }

            baglanti.Close();




        }
    }
}
