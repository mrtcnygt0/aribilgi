namespace OkulADO
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciKayıtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.gbOgrBilgi = new System.Windows.Forms.GroupBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblMezun = new System.Windows.Forms.Label();
            this.lblAktif = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOgrAd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.gbOgrBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.öğrenciKayıtToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(800, 29);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileToolStripMenuItem,
            this.yazdırToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            this.dosyaToolStripMenuItem.MouseHover += new System.EventHandler(this.dosyaToolStripMenuItem_MouseHover);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Enabled = false;
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // öğrenciKayıtToolStripMenuItem
            // 
            this.öğrenciKayıtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciKayıtToolStripMenuItem1,
            this.öğrenciGüncellemeToolStripMenuItem,
            this.öğrenciSilmeToolStripMenuItem});
            this.öğrenciKayıtToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.öğrenciKayıtToolStripMenuItem.Name = "öğrenciKayıtToolStripMenuItem";
            this.öğrenciKayıtToolStripMenuItem.Size = new System.Drawing.Size(135, 25);
            this.öğrenciKayıtToolStripMenuItem.Text = "Öğrenci İşlemleri";
            // 
            // öğrenciKayıtToolStripMenuItem1
            // 
            this.öğrenciKayıtToolStripMenuItem1.Name = "öğrenciKayıtToolStripMenuItem1";
            this.öğrenciKayıtToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.öğrenciKayıtToolStripMenuItem1.Text = "Öğrenci Kayıt";
            this.öğrenciKayıtToolStripMenuItem1.Click += new System.EventHandler(this.öğrenciKayıtToolStripMenuItem1_Click);
            // 
            // öğrenciGüncellemeToolStripMenuItem
            // 
            this.öğrenciGüncellemeToolStripMenuItem.Name = "öğrenciGüncellemeToolStripMenuItem";
            this.öğrenciGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.öğrenciGüncellemeToolStripMenuItem.Text = "Öğrenci Güncelleme";
            this.öğrenciGüncellemeToolStripMenuItem.Click += new System.EventHandler(this.öğrenciGüncellemeToolStripMenuItem_Click);
            // 
            // öğrenciSilmeToolStripMenuItem
            // 
            this.öğrenciSilmeToolStripMenuItem.Name = "öğrenciSilmeToolStripMenuItem";
            this.öğrenciSilmeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.öğrenciSilmeToolStripMenuItem.Text = "Öğrenci Silme";
            this.öğrenciSilmeToolStripMenuItem.Click += new System.EventHandler(this.öğrenciSilmeToolStripMenuItem_Click);
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
            this.dgvListe.Location = new System.Drawing.Point(0, 307);
            this.dgvListe.MultiSelect = false;
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.Size = new System.Drawing.Size(800, 333);
            this.dgvListe.TabIndex = 30;
            // 
            // gbOgrBilgi
            // 
            this.gbOgrBilgi.Controls.Add(this.lblToplam);
            this.gbOgrBilgi.Controls.Add(this.lblMezun);
            this.gbOgrBilgi.Controls.Add(this.lblAktif);
            this.gbOgrBilgi.Controls.Add(this.label1);
            this.gbOgrBilgi.Controls.Add(this.lblOgrAd);
            this.gbOgrBilgi.Controls.Add(this.label4);
            this.gbOgrBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbOgrBilgi.ForeColor = System.Drawing.Color.White;
            this.gbOgrBilgi.Location = new System.Drawing.Point(12, 222);
            this.gbOgrBilgi.Name = "gbOgrBilgi";
            this.gbOgrBilgi.Size = new System.Drawing.Size(776, 79);
            this.gbOgrBilgi.TabIndex = 31;
            this.gbOgrBilgi.TabStop = false;
            this.gbOgrBilgi.Text = "Kurum İstatistikleri";
            // 
            // lblToplam
            // 
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplam.ForeColor = System.Drawing.Color.Turquoise;
            this.lblToplam.Location = new System.Drawing.Point(667, 30);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(62, 23);
            this.lblToplam.TabIndex = 22;
            this.lblToplam.Text = "AKTİF:";
            // 
            // lblMezun
            // 
            this.lblMezun.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMezun.ForeColor = System.Drawing.Color.Turquoise;
            this.lblMezun.Location = new System.Drawing.Point(281, 30);
            this.lblMezun.Name = "lblMezun";
            this.lblMezun.Size = new System.Drawing.Size(62, 23);
            this.lblMezun.TabIndex = 21;
            this.lblMezun.Text = "AKTİF:";
            // 
            // lblAktif
            // 
            this.lblAktif.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAktif.ForeColor = System.Drawing.Color.Turquoise;
            this.lblAktif.Location = new System.Drawing.Point(89, 30);
            this.lblAktif.Name = "lblAktif";
            this.lblAktif.Size = new System.Drawing.Size(62, 23);
            this.lblAktif.TabIndex = 20;
            this.lblAktif.Text = "AKTİF:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(195, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "MEZUN:";
            // 
            // lblOgrAd
            // 
            this.lblOgrAd.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrAd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOgrAd.Location = new System.Drawing.Point(479, 30);
            this.lblOgrAd.Name = "lblOgrAd";
            this.lblOgrAd.Size = new System.Drawing.Size(182, 23);
            this.lblOgrAd.TabIndex = 3;
            this.lblOgrAd.Text = "TOPLAM ÖĞRENCİ:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(23, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "AKTİF:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(241, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(525, 52);
            this.label2.TabIndex = 23;
            this.label2.Text = "ARI BİLGİ ÖĞRENCİ İŞLERİ";
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbOgrBilgi);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.menu);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 1089);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci İşlemleri Yazılımı";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.gbOgrBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciKayıtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciGüncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.GroupBox gbOgrBilgi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOgrAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblMezun;
        private System.Windows.Forms.Label lblAktif;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
    }
}

