namespace OkulADO
{
    partial class OgrKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrKayit));
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblOgrAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSinif = new System.Windows.Forms.ComboBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSube = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblTarih = new System.Windows.Forms.Label();
            this.cmbUyruk = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMezun = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbOgrBilgi = new System.Windows.Forms.GroupBox();
            this.gbEgitimBilgi = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.gbOgrBilgi.SuspendLayout();
            this.gbEgitimBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.Location = new System.Drawing.Point(133, 19);
            this.txtAd.MaxLength = 50;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(303, 28);
            this.txtAd.TabIndex = 4;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "SINIF:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.cmbSinif.SelectedIndexChanged += new System.EventHandler(this.cmbSinif_SelectedIndexChanged);
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyisim.Location = new System.Drawing.Point(133, 53);
            this.txtSoyisim.MaxLength = 50;
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(303, 28);
            this.txtSoyisim.TabIndex = 8;
            this.txtSoyisim.TextChanged += new System.EventHandler(this.txtSoyisim_TextChanged);
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
            this.cmbSube.SelectedIndexChanged += new System.EventHandler(this.cmbSube_SelectedIndexChanged);
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
            // dtpTarih
            // 
            this.dtpTarih.CalendarFont = new System.Drawing.Font("Leelawadee UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTarih.Location = new System.Drawing.Point(131, 115);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(152, 28);
            this.dtpTarih.TabIndex = 15;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
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
            this.cmbUyruk.SelectedIndexChanged += new System.EventHandler(this.cmbUyruk_SelectedIndexChanged);
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
            this.cmbMezun.SelectedIndexChanged += new System.EventHandler(this.cmbMezun_SelectedIndexChanged);
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
            this.gbOgrBilgi.TabIndex = 19;
            this.gbOgrBilgi.TabStop = false;
            this.gbOgrBilgi.Text = "Öğrenci Bilgileri";
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
            this.gbEgitimBilgi.TabIndex = 20;
            this.gbEgitimBilgi.TabStop = false;
            this.gbEgitimBilgi.Text = "Kurum Bilgileri";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(171, 326);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(231, 68);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "TEMİZLE";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LightGreen;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(408, 326);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(231, 68);
            this.btnKaydet.TabIndex = 22;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAciklama.Location = new System.Drawing.Point(12, 177);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(776, 143);
            this.txtAciklama.TabIndex = 20;
            this.txtAciklama.TextChanged += new System.EventHandler(this.txtAciklama_TextChanged);
            // 
            // OgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.gbEgitimBilgi);
            this.Controls.Add(this.gbOgrBilgi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 590);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 290);
            this.Name = "OgrKayit";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kayıt Formu";
            this.Load += new System.EventHandler(this.OgrKayit_Load);
            this.gbOgrBilgi.ResumeLayout(false);
            this.gbOgrBilgi.PerformLayout();
            this.gbEgitimBilgi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblOgrAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSinif;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSube;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMezun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbOgrBilgi;
        private System.Windows.Forms.GroupBox gbEgitimBilgi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cmbUyruk;
    }
}