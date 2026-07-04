namespace OkulADO
{
    partial class OgrSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrSil));
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chkOnay = new System.Windows.Forms.CheckBox();
            this.lblOgrAd = new System.Windows.Forms.Label();
            this.lblSecilenOgr = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
>>>>>>> 63620e45edfceb8a922fcb4a4f55438ec242b0d6
            this.SuspendLayout();
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            this.dgvListe.Location = new System.Drawing.Point(0, 52);
=======
            this.dgvListe.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvListe.Location = new System.Drawing.Point(0, 0);
>>>>>>> 63620e45edfceb8a922fcb4a4f55438ec242b0d6
            this.dgvListe.MultiSelect = false;
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.Size = new System.Drawing.Size(813, 344);
            this.dgvListe.TabIndex = 30;
            this.dgvListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(282, 452);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(231, 68);
            this.btnSil.TabIndex = 31;
            this.btnSil.Text = "KAYDI SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.richTextBox1.Location = new System.Drawing.Point(46, 425);
=======
            this.richTextBox1.Location = new System.Drawing.Point(46, 411);
>>>>>>> 63620e45edfceb8a922fcb4a4f55438ec242b0d6
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(755, 21);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = "* Bu işlemin geri dönüşü olmadığını biliyorum ve silme işleminin sorumluluklarını" +
    " kabul ediyorum.";
            // 
            // chkOnay
            // 
            this.chkOnay.AutoSize = true;
<<<<<<< HEAD
            this.chkOnay.Location = new System.Drawing.Point(15, 430);
=======
            this.chkOnay.Location = new System.Drawing.Point(15, 416);
>>>>>>> 63620e45edfceb8a922fcb4a4f55438ec242b0d6
            this.chkOnay.Name = "chkOnay";
            this.chkOnay.Size = new System.Drawing.Size(15, 14);
            this.chkOnay.TabIndex = 33;
            this.chkOnay.UseVisualStyleBackColor = true;
            // 
            // lblOgrAd
            // 
            this.lblOgrAd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrAd.ForeColor = System.Drawing.SystemColors.ButtonFace;
<<<<<<< HEAD
            this.lblOgrAd.Location = new System.Drawing.Point(42, 399);
=======
            this.lblOgrAd.Location = new System.Drawing.Point(42, 363);
>>>>>>> 63620e45edfceb8a922fcb4a4f55438ec242b0d6
            this.lblOgrAd.Name = "lblOgrAd";
            this.lblOgrAd.Size = new System.Drawing.Size(141, 23);
            this.lblOgrAd.TabIndex = 34;
            this.lblOgrAd.Text = "Seçilen Öğrenci:";
            // 
            // lblSecilenOgr
            // 
            this.lblSecilenOgr.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecilenOgr.ForeColor = System.Drawing.SystemColors.MenuHighlight;
<<<<<<< HEAD
            this.lblSecilenOgr.Location = new System.Drawing.Point(180, 399);
=======
            this.lblSecilenOgr.Location = new System.Drawing.Point(179, 363);
>>>>>>> 63620e45edfceb8a922fcb4a4f55438ec242b0d6
            this.lblSecilenOgr.Name = "lblSecilenOgr";
            this.lblSecilenOgr.Size = new System.Drawing.Size(324, 23);
            this.lblSecilenOgr.TabIndex = 35;
            this.lblSecilenOgr.Text = "Henüz seçim yapılmadı.";
            // 
<<<<<<< HEAD
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAra.Location = new System.Drawing.Point(55, 12);
            this.txtAra.MaxLength = 50;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(735, 28);
            this.txtAra.TabIndex = 36;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
=======
>>>>>>> 63620e45edfceb8a922fcb4a4f55438ec242b0d6
            // OgrSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(813, 532);
<<<<<<< HEAD
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtAra);
=======
>>>>>>> 63620e45edfceb8a922fcb4a4f55438ec242b0d6
            this.Controls.Add(this.lblSecilenOgr);
            this.Controls.Add(this.lblOgrAd);
            this.Controls.Add(this.chkOnay);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvListe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrSil";
<<<<<<< HEAD
            this.Text = "Öğrenci Kayıt Silme Formu";
            this.Load += new System.EventHandler(this.OgrSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
=======
            this.Text = "OgrSil";
            this.Load += new System.EventHandler(this.OgrSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
>>>>>>> 63620e45edfceb8a922fcb4a4f55438ec242b0d6
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox chkOnay;
        private System.Windows.Forms.Label lblOgrAd;
        private System.Windows.Forms.Label lblSecilenOgr;
<<<<<<< HEAD
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAra;
=======
>>>>>>> 63620e45edfceb8a922fcb4a4f55438ec242b0d6
    }
}