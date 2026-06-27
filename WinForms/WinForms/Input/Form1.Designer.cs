namespace Input
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.lblUrunMarka = new System.Windows.Forms.Label();
            this.txtUrunMarka = new System.Windows.Forms.TextBox();
            this.lblUrunModel = new System.Windows.Forms.Label();
            this.txtUrunModel = new System.Windows.Forms.TextBox();
            this.lblUrunFiyat = new System.Windows.Forms.Label();
            this.nudUrunFiyat = new System.Windows.Forms.NumericUpDown();
            this.cmbUrunKategori = new System.Windows.Forms.ComboBox();
            this.lblUrunKategori = new System.Windows.Forms.Label();
            this.lblMagaza = new System.Windows.Forms.Label();
            this.lbMagaza = new System.Windows.Forms.ListBox();
            this.rbYuzdeBir = new System.Windows.Forms.RadioButton();
            this.rbYuzdeOn = new System.Windows.Forms.RadioButton();
            this.lblKDVOran = new System.Windows.Forms.Label();
            this.rbYuzdeYirmi = new System.Windows.Forms.RadioButton();
            this.chkSiyah = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBeyaz = new System.Windows.Forms.CheckBox();
            this.chkKirmizi = new System.Windows.Forms.CheckBox();
            this.chkMor = new System.Windows.Forms.CheckBox();
            this.chkGri = new System.Windows.Forms.CheckBox();
            this.chkMavi = new System.Windows.Forms.CheckBox();
            this.chkEflatun = new System.Windows.Forms.CheckBox();
            this.chkYesil = new System.Windows.Forms.CheckBox();
            this.chkPembe = new System.Windows.Forms.CheckBox();
            this.pbUrunGorseli = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbUrunEkle = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnUrunGorseliSec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtUrunGorseliYolu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMüşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriBilgisiGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÜrünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünBilgisiGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performansRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasaRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maliyetAnaliziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunGorseli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunEkle)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(163, 96);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(167, 20);
            this.txtUrunAd.TabIndex = 0;
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAd.Location = new System.Drawing.Point(22, 96);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(84, 20);
            this.lblUrunAd.TabIndex = 1;
            this.lblUrunAd.Text = "Ürün Adı:";
            // 
            // lblUrunMarka
            // 
            this.lblUrunMarka.AutoSize = true;
            this.lblUrunMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunMarka.Location = new System.Drawing.Point(22, 127);
            this.lblUrunMarka.Name = "lblUrunMarka";
            this.lblUrunMarka.Size = new System.Drawing.Size(120, 20);
            this.lblUrunMarka.TabIndex = 3;
            this.lblUrunMarka.Text = "Ürün Markası:";
            // 
            // txtUrunMarka
            // 
            this.txtUrunMarka.Location = new System.Drawing.Point(163, 127);
            this.txtUrunMarka.Name = "txtUrunMarka";
            this.txtUrunMarka.Size = new System.Drawing.Size(167, 20);
            this.txtUrunMarka.TabIndex = 2;
            // 
            // lblUrunModel
            // 
            this.lblUrunModel.AutoSize = true;
            this.lblUrunModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunModel.Location = new System.Drawing.Point(22, 158);
            this.lblUrunModel.Name = "lblUrunModel";
            this.lblUrunModel.Size = new System.Drawing.Size(110, 20);
            this.lblUrunModel.TabIndex = 5;
            this.lblUrunModel.Text = "Ürün Modeli:";
            // 
            // txtUrunModel
            // 
            this.txtUrunModel.Location = new System.Drawing.Point(163, 158);
            this.txtUrunModel.Name = "txtUrunModel";
            this.txtUrunModel.Size = new System.Drawing.Size(167, 20);
            this.txtUrunModel.TabIndex = 4;
            // 
            // lblUrunFiyat
            // 
            this.lblUrunFiyat.AutoSize = true;
            this.lblUrunFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunFiyat.Location = new System.Drawing.Point(22, 189);
            this.lblUrunFiyat.Name = "lblUrunFiyat";
            this.lblUrunFiyat.Size = new System.Drawing.Size(101, 20);
            this.lblUrunFiyat.TabIndex = 7;
            this.lblUrunFiyat.Text = "Ürün Fiyatı:";
            // 
            // nudUrunFiyat
            // 
            this.nudUrunFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudUrunFiyat.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudUrunFiyat.Location = new System.Drawing.Point(163, 189);
            this.nudUrunFiyat.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudUrunFiyat.Name = "nudUrunFiyat";
            this.nudUrunFiyat.Size = new System.Drawing.Size(167, 20);
            this.nudUrunFiyat.TabIndex = 8;
            // 
            // cmbUrunKategori
            // 
            this.cmbUrunKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunKategori.FormattingEnabled = true;
            this.cmbUrunKategori.Items.AddRange(new object[] {
            "Ayakkabı",
            "Bilgisayar",
            "Elektronik",
            "Kozmetik",
            "Tekstil",
            "Temel Gıda",
            "Temizlik Ürünü"});
            this.cmbUrunKategori.Location = new System.Drawing.Point(163, 220);
            this.cmbUrunKategori.Name = "cmbUrunKategori";
            this.cmbUrunKategori.Size = new System.Drawing.Size(167, 21);
            this.cmbUrunKategori.TabIndex = 9;
            this.cmbUrunKategori.Text = "Kategori seçiniz...";
            // 
            // lblUrunKategori
            // 
            this.lblUrunKategori.AutoSize = true;
            this.lblUrunKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunKategori.Location = new System.Drawing.Point(22, 220);
            this.lblUrunKategori.Name = "lblUrunKategori";
            this.lblUrunKategori.Size = new System.Drawing.Size(125, 20);
            this.lblUrunKategori.TabIndex = 10;
            this.lblUrunKategori.Text = "Ürün Kategori:";
            // 
            // lblMagaza
            // 
            this.lblMagaza.AutoSize = true;
            this.lblMagaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMagaza.Location = new System.Drawing.Point(22, 251);
            this.lblMagaza.Name = "lblMagaza";
            this.lblMagaza.Size = new System.Drawing.Size(77, 20);
            this.lblMagaza.TabIndex = 12;
            this.lblMagaza.Text = "Mağaza:";
            // 
            // lbMagaza
            // 
            this.lbMagaza.FormattingEnabled = true;
            this.lbMagaza.Items.AddRange(new object[] {
            "Adana",
            "Ankara",
            "Antalya",
            "Bodrum",
            "Diyarbakır",
            "Hatay",
            "Kars",
            "Sakarya",
            "Samsun",
            "Trabzon",
            "Zonguldak"});
            this.lbMagaza.Location = new System.Drawing.Point(163, 252);
            this.lbMagaza.Name = "lbMagaza";
            this.lbMagaza.Size = new System.Drawing.Size(167, 108);
            this.lbMagaza.TabIndex = 13;
            // 
            // rbYuzdeBir
            // 
            this.rbYuzdeBir.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbYuzdeBir.AutoSize = true;
            this.rbYuzdeBir.Location = new System.Drawing.Point(163, 370);
            this.rbYuzdeBir.Name = "rbYuzdeBir";
            this.rbYuzdeBir.Size = new System.Drawing.Size(34, 23);
            this.rbYuzdeBir.TabIndex = 14;
            this.rbYuzdeBir.TabStop = true;
            this.rbYuzdeBir.Text = "%1 ";
            this.rbYuzdeBir.UseVisualStyleBackColor = true;
            // 
            // rbYuzdeOn
            // 
            this.rbYuzdeOn.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbYuzdeOn.AutoSize = true;
            this.rbYuzdeOn.Location = new System.Drawing.Point(226, 370);
            this.rbYuzdeOn.Name = "rbYuzdeOn";
            this.rbYuzdeOn.Size = new System.Drawing.Size(37, 23);
            this.rbYuzdeOn.TabIndex = 15;
            this.rbYuzdeOn.TabStop = true;
            this.rbYuzdeOn.Text = "%10";
            this.rbYuzdeOn.UseVisualStyleBackColor = true;
            // 
            // lblKDVOran
            // 
            this.lblKDVOran.AutoSize = true;
            this.lblKDVOran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKDVOran.Location = new System.Drawing.Point(22, 370);
            this.lblKDVOran.Name = "lblKDVOran";
            this.lblKDVOran.Size = new System.Drawing.Size(82, 20);
            this.lblKDVOran.TabIndex = 16;
            this.lblKDVOran.Text = "KDV (%):";
            // 
            // rbYuzdeYirmi
            // 
            this.rbYuzdeYirmi.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbYuzdeYirmi.AutoSize = true;
            this.rbYuzdeYirmi.Location = new System.Drawing.Point(293, 370);
            this.rbYuzdeYirmi.Name = "rbYuzdeYirmi";
            this.rbYuzdeYirmi.Size = new System.Drawing.Size(37, 23);
            this.rbYuzdeYirmi.TabIndex = 17;
            this.rbYuzdeYirmi.TabStop = true;
            this.rbYuzdeYirmi.Text = "%20";
            this.rbYuzdeYirmi.UseVisualStyleBackColor = true;
            // 
            // chkSiyah
            // 
            this.chkSiyah.AutoSize = true;
            this.chkSiyah.Location = new System.Drawing.Point(163, 405);
            this.chkSiyah.Name = "chkSiyah";
            this.chkSiyah.Size = new System.Drawing.Size(52, 17);
            this.chkSiyah.TabIndex = 18;
            this.chkSiyah.Text = "Siyah";
            this.chkSiyah.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ürün Renk:";
            // 
            // chkBeyaz
            // 
            this.chkBeyaz.AutoSize = true;
            this.chkBeyaz.Location = new System.Drawing.Point(225, 405);
            this.chkBeyaz.Name = "chkBeyaz";
            this.chkBeyaz.Size = new System.Drawing.Size(55, 17);
            this.chkBeyaz.TabIndex = 20;
            this.chkBeyaz.Text = "Beyaz";
            this.chkBeyaz.UseVisualStyleBackColor = true;
            // 
            // chkKirmizi
            // 
            this.chkKirmizi.AutoSize = true;
            this.chkKirmizi.Location = new System.Drawing.Point(287, 405);
            this.chkKirmizi.Name = "chkKirmizi";
            this.chkKirmizi.Size = new System.Drawing.Size(55, 17);
            this.chkKirmizi.TabIndex = 21;
            this.chkKirmizi.Text = "Kırmızı";
            this.chkKirmizi.UseVisualStyleBackColor = true;
            // 
            // chkMor
            // 
            this.chkMor.AutoSize = true;
            this.chkMor.Location = new System.Drawing.Point(287, 434);
            this.chkMor.Name = "chkMor";
            this.chkMor.Size = new System.Drawing.Size(44, 17);
            this.chkMor.TabIndex = 24;
            this.chkMor.Text = "Mor";
            this.chkMor.UseVisualStyleBackColor = true;
            // 
            // chkGri
            // 
            this.chkGri.AutoSize = true;
            this.chkGri.Location = new System.Drawing.Point(225, 434);
            this.chkGri.Name = "chkGri";
            this.chkGri.Size = new System.Drawing.Size(39, 17);
            this.chkGri.TabIndex = 23;
            this.chkGri.Text = "Gri";
            this.chkGri.UseVisualStyleBackColor = true;
            // 
            // chkMavi
            // 
            this.chkMavi.AutoSize = true;
            this.chkMavi.Location = new System.Drawing.Point(163, 434);
            this.chkMavi.Name = "chkMavi";
            this.chkMavi.Size = new System.Drawing.Size(49, 17);
            this.chkMavi.TabIndex = 22;
            this.chkMavi.Text = "Mavi";
            this.chkMavi.UseVisualStyleBackColor = true;
            // 
            // chkEflatun
            // 
            this.chkEflatun.AutoSize = true;
            this.chkEflatun.Location = new System.Drawing.Point(287, 463);
            this.chkEflatun.Name = "chkEflatun";
            this.chkEflatun.Size = new System.Drawing.Size(59, 17);
            this.chkEflatun.TabIndex = 27;
            this.chkEflatun.Text = "Eflatun";
            this.chkEflatun.UseVisualStyleBackColor = true;
            // 
            // chkYesil
            // 
            this.chkYesil.AutoSize = true;
            this.chkYesil.Location = new System.Drawing.Point(225, 463);
            this.chkYesil.Name = "chkYesil";
            this.chkYesil.Size = new System.Drawing.Size(48, 17);
            this.chkYesil.TabIndex = 26;
            this.chkYesil.Text = "Yeşil";
            this.chkYesil.UseVisualStyleBackColor = true;
            // 
            // chkPembe
            // 
            this.chkPembe.AutoSize = true;
            this.chkPembe.Location = new System.Drawing.Point(163, 463);
            this.chkPembe.Name = "chkPembe";
            this.chkPembe.Size = new System.Drawing.Size(59, 17);
            this.chkPembe.TabIndex = 25;
            this.chkPembe.Text = "Pembe";
            this.chkPembe.UseVisualStyleBackColor = true;
            // 
            // pbUrunGorseli
            // 
            this.pbUrunGorseli.Image = ((System.Drawing.Image)(resources.GetObject("pbUrunGorseli.Image")));
            this.pbUrunGorseli.Location = new System.Drawing.Point(386, 96);
            this.pbUrunGorseli.Name = "pbUrunGorseli";
            this.pbUrunGorseli.Size = new System.Drawing.Size(306, 305);
            this.pbUrunGorseli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUrunGorseli.TabIndex = 28;
            this.pbUrunGorseli.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(679, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 33);
            this.label3.TabIndex = 30;
            this.label3.Text = "ÜRÜN KAYIT FORMU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Eklenme Tarihi:";
            // 
            // pbUrunEkle
            // 
            this.pbUrunEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUrunEkle.Image = ((System.Drawing.Image)(resources.GetObject("pbUrunEkle.Image")));
            this.pbUrunEkle.Location = new System.Drawing.Point(386, 463);
            this.pbUrunEkle.Name = "pbUrunEkle";
            this.pbUrunEkle.Size = new System.Drawing.Size(306, 77);
            this.pbUrunEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUrunEkle.TabIndex = 34;
            this.pbUrunEkle.TabStop = false;
            this.pbUrunEkle.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 504);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // btnUrunGorseliSec
            // 
            this.btnUrunGorseliSec.Location = new System.Drawing.Point(634, 411);
            this.btnUrunGorseliSec.Name = "btnUrunGorseliSec";
            this.btnUrunGorseliSec.Size = new System.Drawing.Size(25, 23);
            this.btnUrunGorseliSec.TabIndex = 36;
            this.btnUrunGorseliSec.Text = "...";
            this.btnUrunGorseliSec.UseVisualStyleBackColor = true;
            this.btnUrunGorseliSec.Click += new System.EventHandler(this.btnUrunGorseliSec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtUrunGorseliYolu
            // 
            this.txtUrunGorseliYolu.Location = new System.Drawing.Point(386, 414);
            this.txtUrunGorseliYolu.Name = "txtUrunGorseliYolu";
            this.txtUrunGorseliYolu.ReadOnly = true;
            this.txtUrunGorseliYolu.Size = new System.Drawing.Size(242, 20);
            this.txtUrunGorseliYolu.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.müşteriİşlemleriToolStripMenuItem,
            this.ürünİşlemleriToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "&Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.açToolStripMenuItem.Text = "&Aç";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kaydetToolStripMenuItem.Text = "&Kaydet";
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.farklıKaydetToolStripMenuItem.Text = "&Farklı Kaydet";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kapatToolStripMenuItem.Text = "&Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniMüşteriEkleToolStripMenuItem,
            this.müşteriBilgisiGüncelleToolStripMenuItem,
            this.müşteriSilToolStripMenuItem});
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.müşteriİşlemleriToolStripMenuItem.Text = "&Müşteri İşlemleri";
            // 
            // yeniMüşteriEkleToolStripMenuItem
            // 
            this.yeniMüşteriEkleToolStripMenuItem.Name = "yeniMüşteriEkleToolStripMenuItem";
            this.yeniMüşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.yeniMüşteriEkleToolStripMenuItem.Text = "Yeni Müşteri Ekle";
            // 
            // müşteriBilgisiGüncelleToolStripMenuItem
            // 
            this.müşteriBilgisiGüncelleToolStripMenuItem.Name = "müşteriBilgisiGüncelleToolStripMenuItem";
            this.müşteriBilgisiGüncelleToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.müşteriBilgisiGüncelleToolStripMenuItem.Text = "Müşteri Bilgisi Güncelle";
            // 
            // müşteriSilToolStripMenuItem
            // 
            this.müşteriSilToolStripMenuItem.Name = "müşteriSilToolStripMenuItem";
            this.müşteriSilToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.müşteriSilToolStripMenuItem.Text = "Müşteri Sil";
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            this.ürünİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniÜrünEkleToolStripMenuItem,
            this.ürünBilgisiGüncelleToolStripMenuItem,
            this.ürünSilToolStripMenuItem});
            this.ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            this.ürünİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.ürünİşlemleriToolStripMenuItem.Text = "&Ürün İşlemleri";
            // 
            // yeniÜrünEkleToolStripMenuItem
            // 
            this.yeniÜrünEkleToolStripMenuItem.Name = "yeniÜrünEkleToolStripMenuItem";
            this.yeniÜrünEkleToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.yeniÜrünEkleToolStripMenuItem.Text = "Yeni Ürün Ekle";
            // 
            // ürünBilgisiGüncelleToolStripMenuItem
            // 
            this.ürünBilgisiGüncelleToolStripMenuItem.Name = "ürünBilgisiGüncelleToolStripMenuItem";
            this.ürünBilgisiGüncelleToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ürünBilgisiGüncelleToolStripMenuItem.Text = "Ürün Bilgisi Güncelle";
            // 
            // ürünSilToolStripMenuItem
            // 
            this.ürünSilToolStripMenuItem.Name = "ürünSilToolStripMenuItem";
            this.ürünSilToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ürünSilToolStripMenuItem.Text = "Ürün Sil";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.performansRaporuToolStripMenuItem,
            this.satışRaporuToolStripMenuItem,
            this.kasaRaporuToolStripMenuItem,
            this.maliyetAnaliziToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "&Raporlar";
            // 
            // performansRaporuToolStripMenuItem
            // 
            this.performansRaporuToolStripMenuItem.Name = "performansRaporuToolStripMenuItem";
            this.performansRaporuToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.performansRaporuToolStripMenuItem.Text = "Performans Raporu";
            // 
            // satışRaporuToolStripMenuItem
            // 
            this.satışRaporuToolStripMenuItem.Name = "satışRaporuToolStripMenuItem";
            this.satışRaporuToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.satışRaporuToolStripMenuItem.Text = "Satış Raporu";
            // 
            // kasaRaporuToolStripMenuItem
            // 
            this.kasaRaporuToolStripMenuItem.Name = "kasaRaporuToolStripMenuItem";
            this.kasaRaporuToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.kasaRaporuToolStripMenuItem.Text = "Kasa Raporu";
            // 
            // maliyetAnaliziToolStripMenuItem
            // 
            this.maliyetAnaliziToolStripMenuItem.Name = "maliyetAnaliziToolStripMenuItem";
            this.maliyetAnaliziToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.maliyetAnaliziToolStripMenuItem.Text = "Maliyet Analizi";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem,
            this.iletişimToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "&Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(716, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUrunGorseliYolu);
            this.Controls.Add(this.btnUrunGorseliSec);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pbUrunEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbUrunGorseli);
            this.Controls.Add(this.chkEflatun);
            this.Controls.Add(this.chkYesil);
            this.Controls.Add(this.chkPembe);
            this.Controls.Add(this.chkMor);
            this.Controls.Add(this.chkGri);
            this.Controls.Add(this.chkMavi);
            this.Controls.Add(this.chkKirmizi);
            this.Controls.Add(this.chkBeyaz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkSiyah);
            this.Controls.Add(this.rbYuzdeYirmi);
            this.Controls.Add(this.lblKDVOran);
            this.Controls.Add(this.rbYuzdeOn);
            this.Controls.Add(this.rbYuzdeBir);
            this.Controls.Add(this.lbMagaza);
            this.Controls.Add(this.lblMagaza);
            this.Controls.Add(this.lblUrunKategori);
            this.Controls.Add(this.cmbUrunKategori);
            this.Controls.Add(this.nudUrunFiyat);
            this.Controls.Add(this.lblUrunFiyat);
            this.Controls.Add(this.lblUrunModel);
            this.Controls.Add(this.txtUrunModel);
            this.Controls.Add(this.lblUrunMarka);
            this.Controls.Add(this.txtUrunMarka);
            this.Controls.Add(this.lblUrunAd);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Kayıt Formu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunGorseli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunEkle)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.Label lblUrunMarka;
        private System.Windows.Forms.TextBox txtUrunMarka;
        private System.Windows.Forms.Label lblUrunModel;
        private System.Windows.Forms.TextBox txtUrunModel;
        private System.Windows.Forms.Label lblUrunFiyat;
        private System.Windows.Forms.NumericUpDown nudUrunFiyat;
        private System.Windows.Forms.ComboBox cmbUrunKategori;
        private System.Windows.Forms.Label lblUrunKategori;
        private System.Windows.Forms.Label lblMagaza;
        private System.Windows.Forms.ListBox lbMagaza;
        private System.Windows.Forms.RadioButton rbYuzdeBir;
        private System.Windows.Forms.RadioButton rbYuzdeOn;
        private System.Windows.Forms.Label lblKDVOran;
        private System.Windows.Forms.RadioButton rbYuzdeYirmi;
        private System.Windows.Forms.CheckBox chkSiyah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBeyaz;
        private System.Windows.Forms.CheckBox chkKirmizi;
        private System.Windows.Forms.CheckBox chkMor;
        private System.Windows.Forms.CheckBox chkGri;
        private System.Windows.Forms.CheckBox chkMavi;
        private System.Windows.Forms.CheckBox chkEflatun;
        private System.Windows.Forms.CheckBox chkYesil;
        private System.Windows.Forms.CheckBox chkPembe;
        private System.Windows.Forms.PictureBox pbUrunGorseli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbUrunEkle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnUrunGorseliSec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtUrunGorseliYolu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniMüşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriBilgisiGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniÜrünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünBilgisiGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performansRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasaRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maliyetAnaliziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
    }
}

