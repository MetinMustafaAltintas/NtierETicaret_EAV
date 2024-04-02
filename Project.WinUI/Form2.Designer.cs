namespace Project.WinUI
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKategoriIsmi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstKategoriler = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuncelle3 = new System.Windows.Forms.Button();
            this.btnSil3 = new System.Windows.Forms.Button();
            this.btnKaydet3 = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUrunIsmi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuncelle2 = new System.Windows.Forms.Button();
            this.btnSil2 = new System.Windows.Forms.Button();
            this.btnKaydet2 = new System.Windows.Forms.Button();
            this.txtTedarikci = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lstTedarikci = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lstOzellikDeger = new System.Windows.Forms.ListBox();
            this.txtOzellikDegerGir = new System.Windows.Forms.TextBox();
            this.lstUrunOzellik = new System.Windows.Forms.ListBox();
            this.txtUrunOzellikGir = new System.Windows.Forms.TextBox();
            this.btnKaydet4 = new System.Windows.Forms.Button();
            this.btnKaydet5 = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 0;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Blue;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(139, 277);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(112, 39);
            this.btnGuncelle.TabIndex = 54;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(259, 277);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(112, 39);
            this.btnSil.TabIndex = 55;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Lime;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(19, 277);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 39);
            this.btnKaydet.TabIndex = 56;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(162, 109);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(186, 20);
            this.txtAciklama.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Açıklama Giriniz -->";
            // 
            // txtKategoriIsmi
            // 
            this.txtKategoriIsmi.Location = new System.Drawing.Point(162, 57);
            this.txtKategoriIsmi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKategoriIsmi.Name = "txtKategoriIsmi";
            this.txtKategoriIsmi.Size = new System.Drawing.Size(186, 20);
            this.txtKategoriIsmi.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(48, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Kategori Giriniz -->";
            // 
            // lstKategoriler
            // 
            this.lstKategoriler.FormattingEnabled = true;
            this.lstKategoriler.Location = new System.Drawing.Point(393, 26);
            this.lstKategoriler.Margin = new System.Windows.Forms.Padding(4);
            this.lstKategoriler.Name = "lstKategoriler";
            this.lstKategoriler.Size = new System.Drawing.Size(244, 290);
            this.lstKategoriler.TabIndex = 49;
            this.lstKategoriler.Click += new System.EventHandler(this.lstKategoriler_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(-9, 330);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(668, 10);
            this.label4.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(649, -23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 363);
            this.label5.TabIndex = 58;
            // 
            // btnGuncelle3
            // 
            this.btnGuncelle3.BackColor = System.Drawing.Color.Blue;
            this.btnGuncelle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle3.Location = new System.Drawing.Point(791, 277);
            this.btnGuncelle3.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle3.Name = "btnGuncelle3";
            this.btnGuncelle3.Size = new System.Drawing.Size(112, 39);
            this.btnGuncelle3.TabIndex = 64;
            this.btnGuncelle3.Text = "Guncelle";
            this.btnGuncelle3.UseVisualStyleBackColor = false;
            this.btnGuncelle3.Click += new System.EventHandler(this.btnGuncelle3_Click);
            // 
            // btnSil3
            // 
            this.btnSil3.BackColor = System.Drawing.Color.Red;
            this.btnSil3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil3.Location = new System.Drawing.Point(911, 277);
            this.btnSil3.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil3.Name = "btnSil3";
            this.btnSil3.Size = new System.Drawing.Size(112, 39);
            this.btnSil3.TabIndex = 65;
            this.btnSil3.Text = "Sil";
            this.btnSil3.UseVisualStyleBackColor = false;
            this.btnSil3.Click += new System.EventHandler(this.btnSil3_Click);
            // 
            // btnKaydet3
            // 
            this.btnKaydet3.BackColor = System.Drawing.Color.Lime;
            this.btnKaydet3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet3.Location = new System.Drawing.Point(671, 277);
            this.btnKaydet3.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet3.Name = "btnKaydet3";
            this.btnKaydet3.Size = new System.Drawing.Size(112, 39);
            this.btnKaydet3.TabIndex = 66;
            this.btnKaydet3.Text = "KAYDET";
            this.btnKaydet3.UseVisualStyleBackColor = false;
            this.btnKaydet3.Click += new System.EventHandler(this.btnKaydet3_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(822, 109);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(186, 20);
            this.txtFiyat.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(722, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Fiyat Giriniz -->";
            // 
            // txtUrunIsmi
            // 
            this.txtUrunIsmi.Location = new System.Drawing.Point(822, 57);
            this.txtUrunIsmi.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunIsmi.Name = "txtUrunIsmi";
            this.txtUrunIsmi.Size = new System.Drawing.Size(186, 20);
            this.txtUrunIsmi.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(721, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Ürün Giriniz -->";
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(1053, 26);
            this.lstUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(244, 238);
            this.lstUrunler.TabIndex = 59;
            this.lstUrunler.Click += new System.EventHandler(this.lstUrunler_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(653, 330);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(685, 10);
            this.label8.TabIndex = 67;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(822, 148);
            this.txtStok.Margin = new System.Windows.Forms.Padding(4);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(186, 20);
            this.txtStok.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(722, 155);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "Stok Giriniz -->";
            // 
            // btnGuncelle2
            // 
            this.btnGuncelle2.BackColor = System.Drawing.Color.Blue;
            this.btnGuncelle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle2.Location = new System.Drawing.Point(139, 626);
            this.btnGuncelle2.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle2.Name = "btnGuncelle2";
            this.btnGuncelle2.Size = new System.Drawing.Size(112, 39);
            this.btnGuncelle2.TabIndex = 75;
            this.btnGuncelle2.Text = "Guncelle";
            this.btnGuncelle2.UseVisualStyleBackColor = false;
            this.btnGuncelle2.Click += new System.EventHandler(this.btnGuncelle2_Click);
            // 
            // btnSil2
            // 
            this.btnSil2.BackColor = System.Drawing.Color.Red;
            this.btnSil2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil2.Location = new System.Drawing.Point(259, 626);
            this.btnSil2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil2.Name = "btnSil2";
            this.btnSil2.Size = new System.Drawing.Size(112, 39);
            this.btnSil2.TabIndex = 76;
            this.btnSil2.Text = "Sil";
            this.btnSil2.UseVisualStyleBackColor = false;
            this.btnSil2.Click += new System.EventHandler(this.btnSil2_Click);
            // 
            // btnKaydet2
            // 
            this.btnKaydet2.BackColor = System.Drawing.Color.Lime;
            this.btnKaydet2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet2.Location = new System.Drawing.Point(19, 626);
            this.btnKaydet2.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet2.Name = "btnKaydet2";
            this.btnKaydet2.Size = new System.Drawing.Size(112, 39);
            this.btnKaydet2.TabIndex = 77;
            this.btnKaydet2.Text = "KAYDET";
            this.btnKaydet2.UseVisualStyleBackColor = false;
            this.btnKaydet2.Click += new System.EventHandler(this.btnKaydet2_Click);
            // 
            // txtTedarikci
            // 
            this.txtTedarikci.Location = new System.Drawing.Point(162, 406);
            this.txtTedarikci.Margin = new System.Windows.Forms.Padding(4);
            this.txtTedarikci.Name = "txtTedarikci";
            this.txtTedarikci.Size = new System.Drawing.Size(186, 20);
            this.txtTedarikci.TabIndex = 74;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(76, 413);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 72;
            this.label11.Text = "Firma Adı -->";
            // 
            // lstTedarikci
            // 
            this.lstTedarikci.FormattingEnabled = true;
            this.lstTedarikci.Location = new System.Drawing.Point(393, 375);
            this.lstTedarikci.Margin = new System.Windows.Forms.Padding(4);
            this.lstTedarikci.Name = "lstTedarikci";
            this.lstTedarikci.Size = new System.Drawing.Size(244, 290);
            this.lstTedarikci.TabIndex = 70;
            this.lstTedarikci.Click += new System.EventHandler(this.lstTedarikci_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(649, 330);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 381);
            this.label10.TabIndex = 78;
            // 
            // lstOzellikDeger
            // 
            this.lstOzellikDeger.FormattingEnabled = true;
            this.lstOzellikDeger.Location = new System.Drawing.Point(1122, 373);
            this.lstOzellikDeger.Name = "lstOzellikDeger";
            this.lstOzellikDeger.Size = new System.Drawing.Size(186, 238);
            this.lstOzellikDeger.TabIndex = 82;
            // 
            // txtOzellikDegerGir
            // 
            this.txtOzellikDegerGir.Location = new System.Drawing.Point(992, 493);
            this.txtOzellikDegerGir.Name = "txtOzellikDegerGir";
            this.txtOzellikDegerGir.Size = new System.Drawing.Size(112, 20);
            this.txtOzellikDegerGir.TabIndex = 81;
            // 
            // lstUrunOzellik
            // 
            this.lstUrunOzellik.FormattingEnabled = true;
            this.lstUrunOzellik.Location = new System.Drawing.Point(793, 373);
            this.lstUrunOzellik.Name = "lstUrunOzellik";
            this.lstUrunOzellik.Size = new System.Drawing.Size(186, 238);
            this.lstUrunOzellik.TabIndex = 80;
            // 
            // txtUrunOzellikGir
            // 
            this.txtUrunOzellikGir.Location = new System.Drawing.Point(671, 493);
            this.txtUrunOzellikGir.Name = "txtUrunOzellikGir";
            this.txtUrunOzellikGir.Size = new System.Drawing.Size(112, 20);
            this.txtUrunOzellikGir.TabIndex = 79;
            // 
            // btnKaydet4
            // 
            this.btnKaydet4.BackColor = System.Drawing.Color.Lime;
            this.btnKaydet4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet4.Location = new System.Drawing.Point(671, 572);
            this.btnKaydet4.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet4.Name = "btnKaydet4";
            this.btnKaydet4.Size = new System.Drawing.Size(112, 39);
            this.btnKaydet4.TabIndex = 83;
            this.btnKaydet4.Text = "KAYDET";
            this.btnKaydet4.UseVisualStyleBackColor = false;
            this.btnKaydet4.Click += new System.EventHandler(this.btnKaydet4_Click);
            // 
            // btnKaydet5
            // 
            this.btnKaydet5.BackColor = System.Drawing.Color.Lime;
            this.btnKaydet5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet5.Location = new System.Drawing.Point(992, 572);
            this.btnKaydet5.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet5.Name = "btnKaydet5";
            this.btnKaydet5.Size = new System.Drawing.Size(112, 39);
            this.btnKaydet5.TabIndex = 84;
            this.btnKaydet5.Text = "KAYDET";
            this.btnKaydet5.UseVisualStyleBackColor = false;
            this.btnKaydet5.Click += new System.EventHandler(this.btnKaydet5_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.White;
            this.btnGoster.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoster.Location = new System.Drawing.Point(1053, 277);
            this.btnGoster.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(244, 39);
            this.btnGoster.TabIndex = 85;
            this.btnGoster.Text = "Seçilen Ürünün Tüm Özellikleri";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnForm3
            // 
            this.btnForm3.BackColor = System.Drawing.Color.White;
            this.btnForm3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm3.Location = new System.Drawing.Point(1196, 618);
            this.btnForm3.Margin = new System.Windows.Forms.Padding(4);
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(112, 39);
            this.btnForm3.TabIndex = 86;
            this.btnForm3.Text = "SiPARiS VER";
            this.btnForm3.UseVisualStyleBackColor = false;
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1334, 666);
            this.Controls.Add(this.btnForm3);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnKaydet5);
            this.Controls.Add(this.btnKaydet4);
            this.Controls.Add(this.lstOzellikDeger);
            this.Controls.Add(this.txtOzellikDegerGir);
            this.Controls.Add(this.lstUrunOzellik);
            this.Controls.Add(this.txtUrunOzellikGir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGuncelle2);
            this.Controls.Add(this.btnSil2);
            this.Controls.Add(this.btnKaydet2);
            this.Controls.Add(this.txtTedarikci);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lstTedarikci);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGuncelle3);
            this.Controls.Add(this.btnSil3);
            this.Controls.Add(this.btnKaydet3);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUrunIsmi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKategoriIsmi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstKategoriler);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKategoriIsmi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstKategoriler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuncelle3;
        private System.Windows.Forms.Button btnSil3;
        private System.Windows.Forms.Button btnKaydet3;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUrunIsmi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuncelle2;
        private System.Windows.Forms.Button btnSil2;
        private System.Windows.Forms.Button btnKaydet2;
        private System.Windows.Forms.TextBox txtTedarikci;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstTedarikci;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstOzellikDeger;
        private System.Windows.Forms.TextBox txtOzellikDegerGir;
        private System.Windows.Forms.ListBox lstUrunOzellik;
        private System.Windows.Forms.TextBox txtUrunOzellikGir;
        private System.Windows.Forms.Button btnKaydet4;
        private System.Windows.Forms.Button btnKaydet5;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnForm3;
    }
}