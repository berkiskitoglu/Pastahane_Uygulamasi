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
using System.Xml.Serialization;

namespace Maliyet_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=BERK;Initial Catalog=Test_Maliyet;Integrated Security=True;");

        void MalzemeListe()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void UrunListesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select* from TBLURUNLER", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        void Kasa()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("select* from TBLKASA", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }
        void Urunler()
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from TBLURUNLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbUrun.ValueMember = "URUNID";
            CmbUrun.DisplayMember = "AD";
            CmbUrun.DataSource = dt;
             
            baglanti.Close();
        }
        void Malzemeler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbMalzeme.ValueMember = "MALZEMEID";
            CmbMalzeme.DisplayMember = "AD";
            CmbMalzeme.DataSource = dt;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MalzemeListe();
            Malzemeler();
            Urunler();
        }

        private void BtnUrunListesi_Click(object sender, EventArgs e)
        {
            UrunListesi();
        }

        private void BtnMalzemeListesi_Click(object sender, EventArgs e)
        {
            MalzemeListe();
        }

        private void BtnKasa_Click(object sender, EventArgs e)
        {
            Kasa();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMalzemeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMALZEMELER(AD,STOK,FIYAT,NOTLAR) values(@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtMalzemeAd.Text);
            komut.Parameters.AddWithValue("@p2", decimal.Parse(TxtMalzemeStok.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtMalzemeFiyat.Text));
            komut.Parameters.AddWithValue("@p4", TxtMalzemeNot.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MalzemeListe();
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLURUNLER(AD) values(@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtUrunAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UrunListesi();
        }

        private void BtnUrunGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void BtnUrunOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFIRIN(URUNID,MALZEMEID,MIKTAR,MALIYET) values(@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", CmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@p2", CmbMalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtUrunMiktar.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtUrunMaliyet.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listBox1.Items.Add(CmbMalzeme.Text + " - " + TxtUrunMaliyet.Text);
        }

        private void TxtUrunMiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;
            if(TxtUrunMiktar.Text == "")
            {
                TxtUrunMiktar.Text = "0";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLMALZEMELER where MALZEMEID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", CmbMalzeme.SelectedValue);
            SqlDataReader dr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            while (dr.Read())
            {
                TxtUrunMaliyet.Text = dr[3].ToString();

            }
            baglanti.Close();
            maliyet = Convert.ToDouble(TxtUrunMaliyet.Text) / 1000 * Convert.ToDouble(TxtUrunMiktar.Text);
            TxtUrunMaliyet.Text = maliyet.ToString();
        }

        private void CmbMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtUrunID.Text = dataGridView1.Rows[secilen].Cells[0].ToString();
            TxtUrunAd.Text = dataGridView1.Rows[secilen].Cells[1].ToString();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(MALIYET) from TBLFIRIN where URUNID =@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtUrunID.Text);
            SqlDataReader dr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            while (dr.Read())
            {
                TxtUrunMFiyat.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
    }
}
