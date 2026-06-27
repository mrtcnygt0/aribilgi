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
    public partial class Form2 : Form
    {
        // SQL bağlantısı için SqlConnection nesnesi oluşturuluyor ve bağlantı dizesi ile başlatılıyor.
        // Burada kendinize özgü bilgileri kullanmanız gerekmektedir. Örneğin, sunucu adı, veritabanı adı ve kimlik doğrulama bilgileri.
        SqlConnection conn = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=HastaKayitDB;Integrated Security=True;Encrypt=False;");

        SqlCommand cmdSelect = new SqlCommand("SELECT HastaID, AdSoyad, Adres, Telefon, Sikayet, KayitTarihi, AktifMi, Borc FROM Hastalar WHERE AktifMi = 0");

        SqlCommand cmdUpdate = new SqlCommand("UPDATE Hastalar SET AktifMi = @AktifMi WHERE HastaID = @hastaNo");

        public Form2()
        {
            InitializeComponent();
        }

        private void ListeyiYenile()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmdSelect.CommandText, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = false;
            ListeyiYenile();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenHastaNo == -1)
            {
                MessageBox.Show("Lütfen bir hasta seçiniz.");
                return;
            }

            DialogResult dugme = MessageBox.Show(
                "Hasta tekrar aktif edilecek. Emin misiniz?",
                "Uyarı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dugme == DialogResult.No)
                return;

            cmdUpdate.Connection = conn;
            cmdUpdate.Parameters.Clear();

            cmdUpdate.Parameters.AddWithValue("@AktifMi", true);
            cmdUpdate.Parameters.AddWithValue("@hastaNo", secilenHastaNo);

            conn.Open();
            cmdUpdate.ExecuteNonQuery();
            conn.Close();

            ListeyiYenile();

            secilenHastaNo = -1;

            MessageBox.Show("Hasta başarıyla aktif edildi.");

            btnGuncelle.Enabled = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private int secilenHastaNo = -1;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGuncelle.Enabled = true;

            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            secilenHastaNo = Convert.ToInt32(row.Cells[0].Value);
            
        }
    }
}
