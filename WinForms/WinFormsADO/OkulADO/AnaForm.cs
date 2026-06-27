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
    public partial class AnaForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=OgrenciDB;Integrated Security=True;Encrypt=False;");

        public AnaForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Çıkmak istediğinize emin misiniz messagebox
            DialogResult result = MessageBox.Show("Çıkmak istediğinize emin misiniz?",
                "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dosyaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void öğrenciKayıtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OgrKayit ogrkayit = new OgrKayit();
            ogrkayit.ShowDialog();
        }
    }
}
