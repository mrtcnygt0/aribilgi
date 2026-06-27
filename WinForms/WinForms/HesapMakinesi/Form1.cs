using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public double _sayi1 { get; set; }
        public double _sayi2 { get; set; }
        public double _sonuc { get; set; }
        public string _islem { get; set; } = "";
        public bool _islemSecildi { get; set; }


        // üst kısmın siyah olması için
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(
        IntPtr hwnd,
        int attr,
        ref int attrValue,
        int attrSize);

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // önemli
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            if (!DesignMode)
            {
                int useImmersiveDarkMode = 1;

                DwmSetWindowAttribute(
                    this.Handle,
                    20,
                    ref useImmersiveDarkMode,
                    sizeof(int));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public void FontKontrol()
        {
            if (txtEkran.Text.Length >= 8 && txtEkran.Text.Length < 10)
            {
                txtEkran.Font = new Font("Microsoft Tai Le", 40.25f, FontStyle.Bold);
            }
            else if (txtEkran.Text.Length >= 10)
            {
                txtEkran.Font = new Font("Microsoft Tai Le", 30.25f, FontStyle.Bold);
            }
            else
            {
                txtEkran.Font = new Font("Microsoft Tai Le", 50.25f, FontStyle.Bold);
            }
        }

        private void RakamGoster(object sender, EventArgs e)
        {
            // gelen sender objesi buton mu diye kontrol ediyoruz , butonsa butona çevirelim değilse direk gelen değeri string olarak alalım
            var basilan = (sender is Button) ? ((Button)sender).Text : sender.ToString();
            if (txtEkran.Text == "0" || _islemSecildi == true)
            {
                txtEkran.Text = string.Empty;
                _islemSecildi = false;
                txtEkran.Text += basilan;
            } 
            else if (txtEkran.Text.Length < 14)
                txtEkran.Text += basilan;

            FontKontrol();
        }

        private void btnVirgul_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0" || _islemSecildi)
            {
                txtEkran.Text = "0";
                _islemSecildi = false;
            }

            if (!txtEkran.Text.Contains(","))
            {
                txtEkran.Text += btnVirgul.Text;
            }

        }

        private void Oprt(object sender, EventArgs e)
        {
            // gelen sender objesi buton mu diye kontrol ediyoruz , butonsa butona çevirelim değilse direk gelen değeri string olarak alalım
            var btn = (sender is Button) ? ((Button)sender).Text : sender.ToString();

            if (_islem != "" && !_islemSecildi)
            {
                _sayi2 = Convert.ToDouble(txtEkran.Text);

                switch (_islem)
                {
                    case "+":
                        _sayi1 += _sayi2;
                        break;

                    case "-":
                        _sayi1 -= _sayi2;
                        break;

                    case "X":
                        _sayi1 *= _sayi2;
                        break;

                    case "÷":
                        _sayi1 /= _sayi2;
                        break;
                }

                txtEkran.Text = _sayi1.ToString();
            }
            else
            {
                _sayi1 = Convert.ToDouble(txtEkran.Text);
            }

            _islem = btn;
            _islemSecildi = true;
            FontKontrol();
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            _sayi2 = Convert.ToDouble(txtEkran.Text);

            switch (_islem)
            {
                case "+":
                    _sonuc = _sayi1 + _sayi2;
                    break;
                case "-":
                    _sonuc = _sayi1 - _sayi2;
                    break;
                case "X":
                    _sonuc = _sayi1 * _sayi2;
                    break;
                case "÷":
                    if(_sayi2 != 0)
                    {
                        _sonuc = _sayi1 / _sayi2;
                    }
                    else
                    {
                        txtEkran.Text = "Hata";
                        _sonuc = 0;
                        return;
                    }
                    break;

                default:
                    break;
            }
            txtEkran.Text = _sonuc.ToString();
            _sayi1 = _sonuc;
            _islemSecildi = true;
            FontKontrol();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            // txtEkran.text in son rakamını siler
            if (txtEkran.Text.Length > 1)
            {
                txtEkran.Text = txtEkran.Text.Substring(0, txtEkran.Text.Length - 1);
            }
            else
            {
                txtEkran.Text = "0";
            }
            FontKontrol();

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "0";
            _sayi1 = 0;
            _sayi2 = 0;
            _sonuc = 0;
            _islem = "";
            _islemSecildi = false;
            FontKontrol();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                InsertDigit(e.KeyChar);
            }
            else if (e.KeyChar == ',')
            {
                btnVirgul_Click(sender, e);
            }
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
            {
                Oprt(sender, e);
            }
            else if (e.KeyChar == '=' || e.KeyChar == '\r')
            {
                btnEsittir_Click(sender, e);
            }
            else if (e.KeyChar == '\b')
            {
                btnSil_Click(sender, e);
            }
            else if (e.KeyChar == 'c' || e.KeyChar == 'C')
            {
                btnC_Click(sender, e);
            }
        }

        private void InsertDigit(char digit)
        {
            RakamGoster(digit.ToString(), EventArgs.Empty);

        }
    }
}
