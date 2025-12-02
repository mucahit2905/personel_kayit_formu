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
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N2OM1VP;Initial Catalog=dersler;Integrated Security=True;Encrypt=False");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmgiris_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from admin_table where kullanıcıadı=@a1 and şifre=@a2", baglanti);
            komut.Parameters.AddWithValue("@a1", textBox1.Text);
            komut.Parameters.AddWithValue("@a2", textBox2.Text);
            SqlDataReader dr1 = komut.ExecuteReader();
            if (dr1.Read())
            {
                anaform frm = new anaform();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı yada şifre hatalı ");
            }

            baglanti.Close();
        }
    }
}
