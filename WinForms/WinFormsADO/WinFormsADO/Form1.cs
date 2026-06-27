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

namespace WinFormsADO
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=HastaKayitDB;Integrated Security=True;Encrypt=False;");

        SqlCommand cmdSelect = new SqlCommand("SELECT HastaID, AdSoyad, Adres, Telefon, Sikayet, KayitTarihi, AktifMi, Borc FROM Hastalar WHERE AktifMi = 1");

        SqlCommand cmdInsert = new SqlCommand("INSERT INTO Hastalar (AdSoyad, Adres, Telefon, Sikayet, KayitTarihi, AktifMi, Borc) VALUES (@AdSoyad, @Adres, @Telefon, @Sikayet, @KayitTarihi, @AktifMi, @Borc)");

        SqlCommand cmdUpdate = new SqlCommand("UPDATE Hastalar SET AdSoyad = @AdSoyad, Adres = @Adres, Telefon = @Telefon, Sikayet = @Sikayet, KayitTarihi = @KayitTarihi, AktifMi = @AktifMi, Borc = @Borc WHERE HastaID = @HastaNo");

        SqlCommand cmdDelete = new SqlCommand("DELETE FROM Hastalar WHERE HastaID = @HastaNo");

        private void ListeyiYenile()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmdSelect.CommandText, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvListe.DataSource = dt;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ListeyiYenile();

            Temizle();
            BtnReset();

        }

        private void chkAktif_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            cmdInsert.Connection = conn;
            cmdInsert.Parameters.Clear();
            cmdInsert.Parameters.AddWithValue("@AdSoyad", txtHastaAd.Text);
            cmdInsert.Parameters.AddWithValue("@Adres", txtAdres.Text);
            cmdInsert.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            cmdInsert.Parameters.AddWithValue("@Sikayet", txtSikayet.Text);
            cmdInsert.Parameters.AddWithValue("@KayitTarihi", dtpTarih.Value);
            cmdInsert.Parameters.AddWithValue("@AktifMi", chkAktif.Checked);
            cmdInsert.Parameters.AddWithValue("@Borc", nudBorc.Value);

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            cmdInsert.ExecuteNonQuery();

            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }

            ListeyiYenile();

            MessageBox.Show("Kayıt başarıyla eklendi.");
            Temizle();
            BtnReset();
        }

        private void dgvListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvListe.Rows[e.RowIndex];
            row.Selected = true;

            if (row.Cells[0].Value.ToString() != string.Empty && row.Cells[0].Value != null)
            {
                this.txtHastaNo.Text = row.Cells[0].Value.ToString();
                this.txtHastaAd.Text = row.Cells[1].Value.ToString();
                this.txtAdres.Text = row.Cells[2].Value.ToString();
                this.txtTelefon.Text = row.Cells[3].Value.ToString();
                this.txtSikayet.Text = row.Cells[4].Value.ToString();
                this.dtpTarih.Value = (DateTime)row.Cells[5].Value;
                this.chkAktif.Checked = (bool)row.Cells[6].Value;
                this.nudBorc.Value = (decimal)row.Cells[7].Value;

                btnKaydet.Enabled = false;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            DialogResult dugme = MessageBox.Show("Kayıt güncellenecek. Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dugme == DialogResult.No)
            {
                return;
            }

            cmdUpdate.Connection = conn;
            cmdUpdate.Parameters.Clear();
            cmdUpdate.Parameters.AddWithValue("@HastaNo", txtHastaNo.Text);
            cmdUpdate.Parameters.AddWithValue("@AdSoyad", txtHastaAd.Text);
            cmdUpdate.Parameters.AddWithValue("@Adres", txtAdres.Text);
            cmdUpdate.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            cmdUpdate.Parameters.AddWithValue("@Sikayet", txtSikayet.Text);
            cmdUpdate.Parameters.AddWithValue("@KayitTarihi", dtpTarih.Value);
            cmdUpdate.Parameters.AddWithValue("@AktifMi", chkAktif.Checked);
            cmdUpdate.Parameters.AddWithValue("@Borc", nudBorc.Value);

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            cmdUpdate.ExecuteNonQuery();

            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }

            ListeyiYenile();

            MessageBox.Show("Kayıt başarıyla güncellendi.");
            Temizle();
            BtnReset();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            DialogResult dugme = MessageBox.Show("Kayıt silinecek. Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (dugme == DialogResult.No)
            {
                return;
            }

            cmdDelete.Connection = conn;
            cmdDelete.Parameters.Clear();
            cmdDelete.Parameters.AddWithValue("@HastaNo", txtHastaNo.Text);

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            cmdDelete.ExecuteNonQuery();

            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }

            ListeyiYenile();

            MessageBox.Show("Kayıt başarıyla silindi.");
            Temizle();
            BtnReset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();

            BtnReset();
        }

        private void BtnReset()
        {
            btnKaydet.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void Temizle()
        {
            txtHastaNo.Clear();
            txtHastaAd.Clear();
            txtAdres.Clear();
            txtSikayet.Clear();
            txtTelefon.Clear();
            dtpTarih.Value = DateTime.Now;
            chkAktif.Checked = true;
            nudBorc.Value = 0;
        }

        private void pasifMüşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}
