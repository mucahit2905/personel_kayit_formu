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
    public partial class frmgrafik : Form
    {
        public frmgrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N2OM1VP;Initial Catalog=dersler;Integrated Security=True;Encrypt=False");
        private void frmgrafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("select sehir,count(*)from tbl_personel group by sehir",baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read()) {

                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            
            baglanti.Close();

            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("select meslek,avg(maas)from tbl_personel group by meslek", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {

                chart2.Series["maas-meslek"].Points.AddXY(dr2[0], dr2[1]);
            }

            baglanti.Close();
        }
    }
}
