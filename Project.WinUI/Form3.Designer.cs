namespace Project.WinUI
{
    partial class Form3
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
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstSiparis = new System.Windows.Forms.ListBox();
            this.txtSiparis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstGonderici = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGonderici = new System.Windows.Forms.TextBox();
            this.btnGonderici = new System.Windows.Forms.Button();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(287, 43);
            this.lstUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(188, 238);
            this.lstUrunler.TabIndex = 60;
            this.lstUrunler.Click += new System.EventHandler(this.lstUrunler_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Lime;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(363, 348);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(112, 39);
            this.btnEkle.TabIndex = 67;
            this.btnEkle.Text = "ADRES EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstSiparis
            // 
            this.lstSiparis.FormattingEnabled = true;
            this.lstSiparis.Location = new System.Drawing.Point(615, 43);
            this.lstSiparis.Margin = new System.Windows.Forms.Padding(4);
            this.lstSiparis.Name = "lstSiparis";
            this.lstSiparis.Size = new System.Drawing.Size(188, 238);
            this.lstSiparis.TabIndex = 68;
            // 
            // txtSiparis
            // 
            this.txtSiparis.Location = new System.Drawing.Point(287, 321);
            this.txtSiparis.Name = "txtSiparis";
            this.txtSiparis.Size = new System.Drawing.Size(188, 20);
            this.txtSiparis.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Siparis Adresi Giriniz:";
            // 
            // lstGonderici
            // 
            this.lstGonderici.FormattingEnabled = true;
            this.lstGonderici.Location = new System.Drawing.Point(11, 43);
            this.lstGonderici.Margin = new System.Windows.Forms.Padding(4);
            this.lstGonderici.Name = "lstGonderici";
            this.lstGonderici.Size = new System.Drawing.Size(188, 238);
            this.lstGonderici.TabIndex = 71;
            this.lstGonderici.Click += new System.EventHandler(this.lstGonderici_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Gönderici ismi Giriniz:";
            // 
            // txtGonderici
            // 
            this.txtGonderici.Location = new System.Drawing.Point(11, 321);
            this.txtGonderici.Name = "txtGonderici";
            this.txtGonderici.Size = new System.Drawing.Size(188, 20);
            this.txtGonderici.TabIndex = 72;
            // 
            // btnGonderici
            // 
            this.btnGonderici.BackColor = System.Drawing.Color.Lime;
            this.btnGonderici.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGonderici.Location = new System.Drawing.Point(87, 348);
            this.btnGonderici.Margin = new System.Windows.Forms.Padding(4);
            this.btnGonderici.Name = "btnGonderici";
            this.btnGonderici.Size = new System.Drawing.Size(112, 39);
            this.btnGonderici.TabIndex = 74;
            this.btnGonderici.Text = "EKLE";
            this.btnGonderici.UseVisualStyleBackColor = false;
            this.btnGonderici.Click += new System.EventHandler(this.btnGonderici_Click);
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.BackColor = System.Drawing.Color.White;
            this.btnSiparisVer.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisVer.Location = new System.Drawing.Point(691, 302);
            this.btnSiparisVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(112, 39);
            this.btnSiparisVer.TabIndex = 87;
            this.btnSiparisVer.Text = "SiPARiS VER";
            this.btnSiparisVer.UseVisualStyleBackColor = false;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.Lime;
            this.btnUrunEkle.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunEkle.Location = new System.Drawing.Point(530, 302);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(112, 39);
            this.btnUrunEkle.TabIndex = 88;
            this.btnUrunEkle.Text = "ÜRÜN EKLE";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 89;
            this.label3.Text = "Gönderici Seçiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 16);
            this.label4.TabIndex = 90;
            this.label4.Text = "Istediginiz Ürünleri Seçiniz";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(832, 397);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.btnGonderici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGonderici);
            this.Controls.Add(this.lstGonderici);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSiparis);
            this.Controls.Add(this.lstSiparis);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstUrunler);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstSiparis;
        private System.Windows.Forms.TextBox txtSiparis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstGonderici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGonderici;
        private System.Windows.Forms.Button btnGonderici;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}