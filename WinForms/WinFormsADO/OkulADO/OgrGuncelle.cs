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

namespace OkulADO
{
    public partial class OgrGuncelle : Form
    {
        public SqlConnection conn = new SqlConnection("Server=MERT\\SQLEXPRESS;Database=OgrenciDB;Integrated Security=True;Encrypt=False;");

        SqlCommand cmdSelect = new SqlCommand("SELECT OgrNO, Ad, Soyad, Sinif, Sube, KayitTarih, Uyruk, Aciklama, Mezun FROM Ogrenciler");

        SqlCommand cmdUpdate = new SqlCommand("UPDATE Ogrenciler SET Ad = @Ad, Soyad = @Soyad, Sinif = @Sinif, Sube = @Sube, KayitTarih = @KayitTarih, Uyruk = @Uyruk, Aciklama = @Aciklama, Mezun = @Mezun WHERE OgrNO = @OgrenciID");

        private int secilenOgrenciID;

        private void ListeyiYenile()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmdSelect.CommandText, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvListe.DataSource = dt;

        }

        private void BtnReset()
        {
            btnKaydet.Enabled = true;
            btnSil.Enabled = false;
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtSoyisim.Clear();
            txtAciklama.Clear();
            cmbMezun.SelectedIndex = 0;
            cmbSinif.SelectedIndex = 0;
            cmbSube.SelectedIndex = 0;
            cmbUyruk.SelectedIndex = 0;
            dtpTarih.Value = DateTime.Now;
        }

        private void Kontrol()
        {
            if (secilenOgrenciID == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz öğrenciyi seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

            DialogResult dugme = MessageBox.Show("Kayıt güncellenecek. Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dugme == DialogResult.No)
            {
                return;
            }

            cmdUpdate.Connection = conn;
            cmdUpdate.Parameters.Clear();
            cmdUpdate.Parameters.AddWithValue("@Ad", txtAd.Text);
            cmdUpdate.Parameters.AddWithValue("@Soyad", txtSoyisim.Text);
            cmdUpdate.Parameters.AddWithValue("@Sinif", cmbSinif.SelectedItem);
            cmdUpdate.Parameters.AddWithValue("@Sube", cmbSube.SelectedItem);
            cmdUpdate.Parameters.AddWithValue("@KayitTarih", dtpTarih.Value);
            cmdUpdate.Parameters.AddWithValue("@Uyruk", cmbUyruk.SelectedItem);
            cmdUpdate.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
            cmdUpdate.Parameters.AddWithValue("@Mezun", cmbMezun.SelectedItem);
            cmdUpdate.Parameters.AddWithValue("@OgrenciID", secilenOgrenciID);

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            cmdUpdate.ExecuteNonQuery();

            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
            MessageBox.Show("Kayıt başarıyla güncellendi.");

            ListeyiYenile();
            Temizle();
            BtnReset();
        }

        public OgrGuncelle()
        {
            InitializeComponent();
        }

        private void OgrGuncelle_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
            BtnReset();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kontrol();
        }

        private void dgvListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvListe.Rows[e.RowIndex];
            row.Selected = true;

            if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() != string.Empty)
            {
                secilenOgrenciID = Convert.ToInt32(row.Cells[0].Value);
                this.txtAd.Text = row.Cells[1].Value.ToString();
                this.txtSoyisim.Text = row.Cells[2].Value.ToString();
                this.cmbSinif.SelectedItem = row.Cells[3].Value.ToString().Trim();
                this.cmbSube.SelectedItem = row.Cells[4].Value.ToString().Trim();
                this.dtpTarih.Value = (DateTime)row.Cells[5].Value;
                this.cmbUyruk.SelectedItem = row.Cells[6].Value.ToString().Trim();
                this.txtAciklama.Text = row.Cells[7].Value.ToString();
                this.cmbMezun.SelectedItem = row.Cells[8].Value.ToString().Trim();

                btnSil.Enabled = true;
            }
        }

        private void BtnAktif()
        {
            btnKaydet.Enabled = true;
            btnSil.Enabled = true;
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
