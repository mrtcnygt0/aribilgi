using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulADO
{

    public partial class OgrKayit : Form
    {
        public SqlConnection conn = new SqlConnection("Server=MERT\\SQLEXPRESS;Database=OgrenciDB;Integrated Security=True;Encrypt=False;");

        SqlCommand cmdInsertOgrenci = new SqlCommand("INSERT INTO Ogrenciler (Ad, Soyad, Sinif, Sube, KayitTarih, Uyruk, Aciklama, Mezun) VALUES (@Ad, @Soyad, @Sinif, @Sube, @KayitTarih, @Uyruk, @Aciklama, @Mezun)");

        private void Temizle()
        {
            txtAd.Clear();
            txtSoyisim.Clear();
            cmbSinif.SelectedIndex = 0;
            cmbSube.SelectedIndex = 0;
            dtpTarih.Value = DateTime.Now;
            cmbUyruk.SelectedIndex = 0;
            txtAciklama.Clear();
            cmbMezun.SelectedIndex = 0;
        }

        private void BtnReset()
        {
            btnKaydet.Enabled = false;
            btnSil.Enabled = false;
        }

        public OgrKayit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nudBorc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            cmdInsertOgrenci.Connection = conn;
            cmdInsertOgrenci.Parameters.Clear();


            cmdInsertOgrenci.Parameters.AddWithValue("@Ad", txtAd.Text);
            cmdInsertOgrenci.Parameters.AddWithValue("@Soyad", txtSoyisim.Text);
            cmdInsertOgrenci.Parameters.AddWithValue("@Sinif", cmbSinif.SelectedItem.ToString());
            cmdInsertOgrenci.Parameters.AddWithValue("@Sube", cmbSube.SelectedItem.ToString());
            cmdInsertOgrenci.Parameters.AddWithValue("@KayitTarih", dtpTarih.Value);
            cmdInsertOgrenci.Parameters.AddWithValue("@Uyruk", cmbUyruk.SelectedItem.ToString());
            cmdInsertOgrenci.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
            cmdInsertOgrenci.Parameters.AddWithValue("@Mezun", cmbMezun.SelectedItem.ToString());

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            cmdInsertOgrenci.ExecuteNonQuery();

            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }

            MessageBox.Show(txtAd.Text + " " + txtSoyisim.Text + " öğrencisi başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            BtnReset();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Temizle();
            BtnReset();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            btnSil.Enabled = true;
        }

        private void txtSoyisim_TextChanged(object sender, EventArgs e)
        {
            btnSil.Enabled = true;
        }

        private void cmbUyruk_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSil.Enabled = true;
        }

        private void cmbMezun_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSil.Enabled = true;
        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {
            btnSil.Enabled = true;
        }

        private void cmbSinif_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSil.Enabled = true;
        }

        private void cmbSube_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSil.Enabled = true;
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            btnSil.Enabled = true;
        }
    }
}
