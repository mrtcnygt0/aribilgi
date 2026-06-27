using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Input
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult yesNo = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (yesNo == DialogResult.Yes)
            {
                Application.Exit();
            } else
            {
               
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UrunEklendi();
        }

        public void btnUrunGorseliSec_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                string dosyaYolu = openFileDialog1.FileName;
                txtUrunGorseliYolu.Text = dosyaYolu;
                pbUrunGorseli.Image = Image.FromFile(dosyaYolu);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pbUrunGorseli.Image = null;
            txtUrunGorseliYolu.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void UrunEklendi()
        {
            MessageBox.Show("Ürün eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Emin misiniz diye soran bir messagebox
            
            Application.Exit();
        }
    }
}
