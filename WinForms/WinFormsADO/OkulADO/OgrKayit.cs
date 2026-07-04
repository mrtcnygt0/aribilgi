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

        private void BtnAktif()
        {
            btnKaydet.Enabled = true;
            btnSil.Enabled = true;
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
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                MessageBox.Show("Lütfen öğrencinin adını giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAd.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoyisim.Text))
            {
                MessageBox.Show("Lütfen öğrencinin soyadını giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoyisim.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbSinif.Text))
            {
                MessageBox.Show("Lütfen sınıf seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSinif.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbSube.Text))
            {
                MessageBox.Show("Lütfen şube seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSube.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbUyruk.Text))
            {
                MessageBox.Show("Lütfen uyruk seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbUyruk.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbMezun.Text))
            {
                MessageBox.Show("Lütfen mezun bilgisini seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMezun.Focus();
                return;
            }

            cmdInsertOgrenci.Connection = conn;
            cmdInsertOgrenci.Parameters.Clear();


            cmdInsertOgrenci.Parameters.AddWithValue("@Ad", txtAd.Text.Trim());
            cmdInsertOgrenci.Parameters.AddWithValue("@Soyad", txtSoyisim.Text.Trim());
            cmdInsertOgrenci.Parameters.AddWithValue("@Sinif", cmbSinif.Text);
            cmdInsertOgrenci.Parameters.AddWithValue("@Sube", cmbSube.Text);
            cmdInsertOgrenci.Parameters.AddWithValue("@KayitTarih", dtpTarih.Value);
            cmdInsertOgrenci.Parameters.AddWithValue("@Uyruk", cmbUyruk.Text);
            cmdInsertOgrenci.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
            cmdInsertOgrenci.Parameters.AddWithValue("@Mezun", cmbMezun.Text);

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            cmdInsertOgrenci.ExecuteNonQuery();

            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }

            MessageBox.Show(txtAd.Text.Trim() + " " + txtSoyisim.Text.Trim() + " öğrencisi başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            BtnAktif();
        }

        private void txtSoyisim_TextChanged(object sender, EventArgs e)
        {
            BtnAktif();
        }

        private void cmbUyruk_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnAktif();
        }

        private void cmbMezun_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnAktif();
        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {
            BtnAktif();
        }

        private void cmbSinif_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnAktif();
        }

        private void cmbSube_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnAktif();
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            BtnAktif();
        }

        private void OgrKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
