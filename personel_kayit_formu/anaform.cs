using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //sql kütüphanesini projeye dahil ettik

namespace _11.sql_ile_birleştirme
{
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-N2OM1VP;Initial Catalog=dersler;Integrated Security=True;Encrypt=False");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'derslerDataSet.tbl_personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_personelTableAdapter.Fill(this.derslerDataSet.tbl_personel);

        }
        void temizle()
        {
            txtad.Text = "";
            txtsoyad.Text = "";
            combsehir.Text = "";
            txtmaas.Text = "";
            txtmeslek.Text = "";
            rdbtnbekar.Checked = false;
            rdbtnevli.Checked = false;
            txtad.Focus();
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_personelTableAdapter.Fill(this.derslerDataSet.tbl_personel);
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();//Veritabanı ile bağlantıyı açıyor
            SqlCommand komut=new SqlCommand("insert into tbl_personel(personelad,personelsoyad,sehir,maas,meslek,durum) values(@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);//Yeni bir SQL komutu oluşturuyorsun.
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);//sorgudaki parametrelere değer atamak için uygulanır
            komut.Parameters.AddWithValue("@p3", combsehir.Text);
            komut.Parameters.AddWithValue("@p4", txtmaas.Text);
            komut.Parameters.AddWithValue("@p5", txtmeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();//Bu satır çok önemli: SQL komutunu çalıştırıyor.(INSERT, UPDATE, DELETE)

           
            baglanti.Close();//İşin bittiğinde bağlantıyı kapatıyorsun.
        }

        private void rdbtnevli_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnevli.Checked) {
                label8.Text = "True";
            }
        }

        private void rdbtnbekar_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbtnbekar.Checked) { 
                label8.Text = "false";
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen=dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text=dataGridView1.Rows[secilen].Cells[0].Value.ToString();// DataGridView’de seçilen satırdaki hücre değerlerini ilgili textbox, combobox ve labellara aktarmak için kullanılır

            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            combsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtmeslek.Text = dataGridView1.Rows[secilen ].Cells[6].Value.ToString();


        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True") { 
                rdbtnevli.Checked = true;
            }
            if (label8.Text == "False") { 
                rdbtnbekar.Checked = true;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand kayıtsil=new SqlCommand("delete from tbl_personel where personelid=@k1",baglanti); //kayıt silmek için gereken komut

            kayıtsil.Parameters.AddWithValue("@k1",txtid.Text);
            kayıtsil.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("kayıt silindi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand guncelle=new SqlCommand("update tbl_personel set personelad=@g1,personelsoyad=@g2,sehir=@g3,maas=@g4,meslek=@g5,durum=@g6 where personelid=@g7",baglanti );
            guncelle.Parameters.AddWithValue("@g1", txtad.Text);
            guncelle.Parameters.AddWithValue("@g2",txtsoyad.Text);
            guncelle.Parameters.AddWithValue("@g3",combsehir.Text);
            guncelle.Parameters.AddWithValue("@g4",txtmaas.Text);
            guncelle.Parameters.AddWithValue("@g5", txtmeslek.Text);
            guncelle.Parameters.AddWithValue("@g6", label8.Text);
            guncelle.Parameters.AddWithValue("@g7", txtid.Text);
            guncelle.ExecuteNonQuery();

            baglanti.Close() ;

            MessageBox.Show("Personel bilgisi güncellendi");
        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            frmistatistik fr = new frmistatistik();
            fr.Show();
        }

        private void btngrafikler_Click(object sender, EventArgs e)
        {
            frmgrafik frg = new frmgrafik();
            frg.Show();
        }
    }
}
