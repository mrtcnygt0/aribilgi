using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1000 ms = 1 saniye
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int rastgele = rnd.Next(5);

            if (rastgele == 0)
            {
                lblMesaj.ForeColor = Color.Black;
                lblRenk.Text = "SİYAH"; 
                lblRenk.Location = new Point(258, 355);
            }
            else if (rastgele == 1)
            {
                lblMesaj.ForeColor = Color.Red;
                lblRenk.Text = "KIRMIZI";
                lblRenk.Location = new Point(242, 355);
            }
            else if (rastgele == 2)
            {
                lblMesaj.ForeColor = Color.Yellow;
                lblRenk.Text = "SARI";
                lblRenk.Location = new Point(268, 355);
            }
            else if (rastgele == 3)
            {
                lblMesaj.ForeColor = Color.Blue;
                lblRenk.Text = "MAVİ";
                lblRenk.Location = new Point(268, 355);
            }
            else if (rastgele == 4)
            {
                lblMesaj.ForeColor = Color.White;
                lblRenk.Text = "BEYAZ";
                lblRenk.Location = new Point(258, 355);
            }

            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}