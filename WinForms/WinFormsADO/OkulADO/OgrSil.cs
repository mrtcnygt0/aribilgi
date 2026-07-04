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
    public partial class OgrSil : Form
    {
        public SqlConnection conn = new SqlConnection("Server=MERT\\SQLEXPRESS;Database=OgrenciDB;Integrated Security=True;Encrypt=False;");

        SqlCommand cmdSelect = new SqlCommand("SELECT OgrNO, Ad, Soyad, Sinif, Sube, KayitTarih, Uyruk, Aciklama, Mezun FROM Ogrenciler");

        SqlCommand cmdDelete = new SqlCommand("DELETE FROM Ogrenciler WHERE OgrNO = @OgrenciID");

<<<<<<< HEAD
        SqlCommand cmdAra = new SqlCommand("SELECT OgrNO, Ad, Soyad, Sinif, Sube, KayitTarih, Uyruk, Aciklama, Mezun " + "FROM Ogrenciler " + "WHERE Ad LIKE @Ara OR Soyad LIKE @Ara");

        private int secilenOgrenciID;

        private void ListeyiYenile(string arama = "")
        {
            DataTable dt = new DataTable();

            if (arama.Length < 4)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmdSelect.CommandText, conn);
                adapter.Fill(dt);
            }
            else
            {
                cmdAra.Connection = conn;
                cmdAra.Parameters.Clear();
                cmdAra.Parameters.AddWithValue("@Ara", "%" + arama + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmdAra);
                adapter.Fill(dt);
            }

            dgvListe.DataSource = dt;
=======
        private int secilenOgrenciID;

        private void ListeyiYenile()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmdSelect.CommandText, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvListe.DataSource = dt;

>>>>>>> 63620e45edfceb8a922fcb4a4f55438ec242b0d6
        }

        public OgrSil()
        {
            InitializeComponent();
        }

        private void OgrSil_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
            btnSil.Enabled = false;
        }

        private void dgvListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvListe.Rows[e.RowIndex];
            row.Selected = true;

            if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() != string.Empty)
            {
                secilenOgrenciID = Convert.ToInt32(row.Cells[0].Value);
                string ad = row.Cells[1].Value.ToString();
                string soyad = row.Cells[2].Value.ToString();

                string message = $" {ad} {soyad} (ID: {secilenOgrenciID})";

                lblSecilenOgr.Text = message;

                btnSil.Enabled = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(chkOnay.Checked != true)
            {
                MessageBox.Show("Lütfen silme işlemini onaylayın.", "Onay Gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dugme = MessageBox.Show("Kayıt silinecek. Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dugme == DialogResult.No)
            {
                return;
            }

            cmdDelete.Connection = conn;
            cmdDelete.Parameters.Clear();
            cmdDelete.Parameters.AddWithValue("@OgrenciID", secilenOgrenciID);

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

            btnSil.Enabled = false;
            chkOnay.Checked = false;
            lblSecilenOgr.Text = string.Empty;
<<<<<<< HEAD

            txtAra.Text = string.Empty;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            ListeyiYenile(txtAra.Text.Trim());
=======
>>>>>>> 63620e45edfceb8a922fcb4a4f55438ec242b0d6
        }
    }
}
