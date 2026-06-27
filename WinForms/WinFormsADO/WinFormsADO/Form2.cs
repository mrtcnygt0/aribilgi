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
            ListeyiYenile();
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
            cmdUpdate.Parameters.AddWithValue("@AktifMi", 1);
            cmdUpdate.Parameters.AddWithValue("@hastaNo", 1);

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
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            row.Selected = true;

            int hastaNo = int.Parse(row.Cells[0].Value.ToString());
            bool aktifMi = (bool)row.Cells[6].Value;
        }
    }
}
