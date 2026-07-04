namespace OkulADO
{
    partial class OgrGuncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrGuncelle));
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.gbEgitimBilgi = new System.Windows.Forms.GroupBox();
            this.cmbSinif = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbSube = new System.Windows.Forms.ComboBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbOgrBilgi = new System.Windows.Forms.GroupBox();
            this.cmbMezun = new System.Windows.Forms.ComboBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.cmbUyruk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOgrAd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbEgitimBilgi.SuspendLayout();
            this.gbOgrBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAciklama.Location = new System.Drawing.Point(12, 177);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(776, 143);
            this.txtAciklama.TabIndex = 25;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(171, 326);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(231, 68);
            this.btnSil.TabIndex = 28;
            this.btnSil.Text = "TEMİZLE";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // gbEgitimBilgi
            // 
            this.gbEgitimBilgi.Controls.Add(this.cmbSinif);
            this.gbEgitimBilgi.Controls.Add(this.label1);
            this.gbEgitimBilgi.Controls.Add(this.dtpTarih);
            this.gbEgitimBilgi.Controls.Add(this.cmbSube);
            this.gbEgitimBilgi.Controls.Add(this.lblTarih);
            this.gbEgitimBilgi.Controls.Add(this.label3);
            this.gbEgitimBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbEgitimBilgi.ForeColor = System.Drawing.Color.White;
            this.gbEgitimBilgi.Location = new System.Drawing.Point(479, 12);
            this.gbEgitimBilgi.Name = "gbEgitimBilgi";
            this.gbEgitimBilgi.Size = new System.Drawing.Size(309, 159);
            this.gbEgitimBilgi.TabIndex = 26;
            this.gbEgitimBilgi.TabStop = false;
            this.gbEgitimBilgi.Text = "Kurum Bilgileri";
            // 
            // cmbSinif
            // 
            this.cmbSinif.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.cmbSinif.FormattingEnabled = true;
            this.cmbSinif.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbSinif.Location = new System.Drawing.Point(131, 24);
            this.cmbSinif.Name = "cmbSinif";
            this.cmbSinif.Size = new System.Drawing.Size(62, 29);
            this.cmbSinif.TabIndex = 6;
            this.cmbSinif.Text = "5";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "SINIF:";
            // 
            // dtpTarih
            // 
            this.dtpTarih.CalendarFont = new System.Drawing.Font("Leelawadee UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTarih.Location = new System.Drawing.Point(131, 115);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(152, 28);
            this.dtpTarih.TabIndex = 15;
            // 
            // cmbSube
            // 
            this.cmbSube.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.cmbSube.FormattingEnabled = true;
            this.cmbSube.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.cmbSube.Location = new System.Drawing.Point(131, 68);
            this.cmbSube.Name = "cmbSube";
            this.cmbSube.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbSube.Size = new System.Drawing.Size(62, 29);
            this.cmbSube.TabIndex = 10;
            this.cmbSube.Text = "A";
            // 
            // lblTarih
            // 
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarih.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTarih.Location = new System.Drawing.Point(17, 117);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(133, 23);
            this.lblTarih.TabIndex = 14;
            this.lblTarih.Text = "Kayıt Tarihi:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(17, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "ŞUBE:";
            // 
            // gbOgrBilgi
            // 
            this.gbOgrBilgi.Controls.Add(this.cmbMezun);
            this.gbOgrBilgi.Controls.Add(this.txtAd);
            this.gbOgrBilgi.Controls.Add(this.label5);
            this.gbOgrBilgi.Controls.Add(this.txtSoyisim);
            this.gbOgrBilgi.Controls.Add(this.cmbUyruk);
            this.gbOgrBilgi.Controls.Add(this.label2);
            this.gbOgrBilgi.Controls.Add(this.lblOgrAd);
            this.gbOgrBilgi.Controls.Add(this.label4);
            this.gbOgrBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbOgrBilgi.ForeColor = System.Drawing.Color.White;
            this.gbOgrBilgi.Location = new System.Drawing.Point(12, 12);
            this.gbOgrBilgi.Name = "gbOgrBilgi";
            this.gbOgrBilgi.Size = new System.Drawing.Size(461, 159);
            this.gbOgrBilgi.TabIndex = 24;
            this.gbOgrBilgi.TabStop = false;
            this.gbOgrBilgi.Text = "Öğrenci Bilgileri";
            // 
            // cmbMezun
            // 
            this.cmbMezun.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMezun.FormattingEnabled = true;
            this.cmbMezun.Items.AddRange(new object[] {
            "EVET",
            "HAYIR"});
            this.cmbMezun.Location = new System.Drawing.Point(133, 120);
            this.cmbMezun.Name = "cmbMezun";
            this.cmbMezun.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbMezun.Size = new System.Drawing.Size(304, 26);
            this.cmbMezun.TabIndex = 19;
            this.cmbMezun.Text = "HAYIR";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.Location = new System.Drawing.Point(133, 19);
            this.txtAd.MaxLength = 50;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(303, 28);
            this.txtAd.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(16, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "MEZUN:";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyisim.Location = new System.Drawing.Point(133, 53);
            this.txtSoyisim.MaxLength = 50;
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(303, 28);
            this.txtSoyisim.TabIndex = 8;
            // 
            // cmbUyruk
            // 
            this.cmbUyruk.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUyruk.FormattingEnabled = true;
            this.cmbUyruk.Items.AddRange(new object[] {
            "TÜRKİYE",
            "AZERBAYCAN",
            "KUZEY KIBRIS T.C.",
            "ALMANYA",
            "KAZAKİSTAN",
            "KIRGIZİSTAN",
            "TACİKİSTAN",
            "ABD",
            "İNGİLTERE",
            "YUNANİSTAN",
            "İRAN",
            "IRAK"});
            this.cmbUyruk.Location = new System.Drawing.Point(133, 87);
            this.cmbUyruk.Name = "cmbUyruk";
            this.cmbUyruk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbUyruk.Size = new System.Drawing.Size(304, 26);
            this.cmbUyruk.TabIndex = 17;
            this.cmbUyruk.Text = "TÜRKİYE";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "SOYİSİM:";
            // 
            // lblOgrAd
            // 
            this.lblOgrAd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrAd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOgrAd.Location = new System.Drawing.Point(15, 24);
            this.lblOgrAd.Name = "lblOgrAd";
            this.lblOgrAd.Size = new System.Drawing.Size(57, 23);
            this.lblOgrAd.TabIndex = 3;
            this.lblOgrAd.Text = "İSİM:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(16, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "UYRUK:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LightGreen;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(408, 326);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(231, 68);
            this.btnKaydet.TabIndex = 27;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListe.Location = new System.Drawing.Point(0, 441);
            this.dgvListe.MultiSelect = false;
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.Size = new System.Drawing.Size(800, 316);
            this.dgvListe.TabIndex = 29;
            this.dgvListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellClick);
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAra.Location = new System.Drawing.Point(53, 407);
            this.txtAra.MaxLength = 50;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(735, 28);
            this.txtAra.TabIndex = 20;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // OgrGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 757);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.gbEgitimBilgi);
            this.Controls.Add(this.gbOgrBilgi);
            this.Controls.Add(this.btnKaydet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrGuncelle";
            this.Opacity = 0.95D;
            this.Text = "Öğrenci Güncelleme Formu";
            this.Load += new System.EventHandler(this.OgrGuncelle_Load);
            this.gbEgitimBilgi.ResumeLayout(false);
            this.gbOgrBilgi.ResumeLayout(false);
            this.gbOgrBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox gbEgitimBilgi;
        private System.Windows.Forms.ComboBox cmbSinif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cmbSube;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbOgrBilgi;
        private System.Windows.Forms.ComboBox cmbMezun;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.ComboBox cmbUyruk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOgrAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}