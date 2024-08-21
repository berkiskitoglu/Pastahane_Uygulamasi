namespace Maliyet_Test
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnMalzemeGetir = new System.Windows.Forms.Button();
            this.BtnMalzemeEkle = new System.Windows.Forms.Button();
            this.TxtMalzemeNot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMalzemeFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMalzemeStok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMalzemeAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMalzemeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnUrunGuncelle = new System.Windows.Forms.Button();
            this.BtnUrunEkle = new System.Windows.Forms.Button();
            this.TxtUrunSFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUrunMFiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtUrunStok = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtUrunAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtUrunID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmbMalzeme = new System.Windows.Forms.ComboBox();
            this.CmbUrun = new System.Windows.Forms.ComboBox();
            this.BtnUrunOlustur = new System.Windows.Forms.Button();
            this.TxtUrunMaliyet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtUrunMiktar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnKasa = new System.Windows.Forms.Button();
            this.BtnMalzemeListesi = new System.Windows.Forms.Button();
            this.BtnUrunListesi = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnMalzemeGetir);
            this.groupBox1.Controls.Add(this.BtnMalzemeEkle);
            this.groupBox1.Controls.Add(this.TxtMalzemeNot);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtMalzemeFiyat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtMalzemeStok);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtMalzemeAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtMalzemeID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzeme Girişi";
            // 
            // BtnMalzemeGetir
            // 
            this.BtnMalzemeGetir.Location = new System.Drawing.Point(73, 329);
            this.BtnMalzemeGetir.Name = "BtnMalzemeGetir";
            this.BtnMalzemeGetir.Size = new System.Drawing.Size(186, 36);
            this.BtnMalzemeGetir.TabIndex = 11;
            this.BtnMalzemeGetir.Text = "Getir";
            this.BtnMalzemeGetir.UseVisualStyleBackColor = true;
            // 
            // BtnMalzemeEkle
            // 
            this.BtnMalzemeEkle.Location = new System.Drawing.Point(73, 290);
            this.BtnMalzemeEkle.Name = "BtnMalzemeEkle";
            this.BtnMalzemeEkle.Size = new System.Drawing.Size(186, 36);
            this.BtnMalzemeEkle.TabIndex = 10;
            this.BtnMalzemeEkle.Text = "Malzeme Ekle";
            this.BtnMalzemeEkle.UseVisualStyleBackColor = true;
            this.BtnMalzemeEkle.Click += new System.EventHandler(this.BtnMalzemeEkle_Click);
            // 
            // TxtMalzemeNot
            // 
            this.TxtMalzemeNot.Location = new System.Drawing.Point(73, 176);
            this.TxtMalzemeNot.Multiline = true;
            this.TxtMalzemeNot.Name = "TxtMalzemeNot";
            this.TxtMalzemeNot.Size = new System.Drawing.Size(186, 108);
            this.TxtMalzemeNot.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Notlar:";
            // 
            // TxtMalzemeFiyat
            // 
            this.TxtMalzemeFiyat.Location = new System.Drawing.Point(73, 141);
            this.TxtMalzemeFiyat.Name = "TxtMalzemeFiyat";
            this.TxtMalzemeFiyat.Size = new System.Drawing.Size(186, 29);
            this.TxtMalzemeFiyat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fiyat:";
            // 
            // TxtMalzemeStok
            // 
            this.TxtMalzemeStok.Location = new System.Drawing.Point(73, 106);
            this.TxtMalzemeStok.Name = "TxtMalzemeStok";
            this.TxtMalzemeStok.Size = new System.Drawing.Size(186, 29);
            this.TxtMalzemeStok.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stok:";
            // 
            // TxtMalzemeAd
            // 
            this.TxtMalzemeAd.Location = new System.Drawing.Point(73, 71);
            this.TxtMalzemeAd.Name = "TxtMalzemeAd";
            this.TxtMalzemeAd.Size = new System.Drawing.Size(186, 29);
            this.TxtMalzemeAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD:";
            // 
            // TxtMalzemeID
            // 
            this.TxtMalzemeID.Location = new System.Drawing.Point(73, 36);
            this.TxtMalzemeID.Name = "TxtMalzemeID";
            this.TxtMalzemeID.Size = new System.Drawing.Size(186, 29);
            this.TxtMalzemeID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(882, 201);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Malzemeler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(876, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnUrunGuncelle);
            this.groupBox3.Controls.Add(this.BtnUrunEkle);
            this.groupBox3.Controls.Add(this.TxtUrunSFiyat);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtUrunMFiyat);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TxtUrunStok);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TxtUrunAd);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtUrunID);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(309, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 385);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Girişi";
            // 
            // BtnUrunGuncelle
            // 
            this.BtnUrunGuncelle.Location = new System.Drawing.Point(73, 261);
            this.BtnUrunGuncelle.Name = "BtnUrunGuncelle";
            this.BtnUrunGuncelle.Size = new System.Drawing.Size(186, 36);
            this.BtnUrunGuncelle.TabIndex = 11;
            this.BtnUrunGuncelle.Text = "Güncelle";
            this.BtnUrunGuncelle.UseVisualStyleBackColor = true;
            this.BtnUrunGuncelle.Click += new System.EventHandler(this.BtnUrunGuncelle_Click);
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.Location = new System.Drawing.Point(73, 222);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(186, 36);
            this.BtnUrunEkle.TabIndex = 10;
            this.BtnUrunEkle.Text = "Ürün Ekle";
            this.BtnUrunEkle.UseVisualStyleBackColor = true;
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // TxtUrunSFiyat
            // 
            this.TxtUrunSFiyat.Location = new System.Drawing.Point(73, 178);
            this.TxtUrunSFiyat.Name = "TxtUrunSFiyat";
            this.TxtUrunSFiyat.Size = new System.Drawing.Size(186, 29);
            this.TxtUrunSFiyat.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "S.Fiyat:";
            // 
            // TxtUrunMFiyat
            // 
            this.TxtUrunMFiyat.Location = new System.Drawing.Point(73, 143);
            this.TxtUrunMFiyat.Name = "TxtUrunMFiyat";
            this.TxtUrunMFiyat.Size = new System.Drawing.Size(186, 29);
            this.TxtUrunMFiyat.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "M.Fiyat:";
            // 
            // TxtUrunStok
            // 
            this.TxtUrunStok.Location = new System.Drawing.Point(73, 108);
            this.TxtUrunStok.Name = "TxtUrunStok";
            this.TxtUrunStok.Size = new System.Drawing.Size(186, 29);
            this.TxtUrunStok.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Stok:";
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.AcceptsReturn = true;
            this.TxtUrunAd.Location = new System.Drawing.Point(73, 73);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(186, 29);
            this.TxtUrunAd.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "AD:";
            // 
            // TxtUrunID
            // 
            this.TxtUrunID.Location = new System.Drawing.Point(73, 38);
            this.TxtUrunID.Name = "TxtUrunID";
            this.TxtUrunID.Size = new System.Drawing.Size(186, 29);
            this.TxtUrunID.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmbMalzeme);
            this.groupBox4.Controls.Add(this.CmbUrun);
            this.groupBox4.Controls.Add(this.BtnUrunOlustur);
            this.groupBox4.Controls.Add(this.TxtUrunMaliyet);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.TxtUrunMiktar);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(604, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 385);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ürün Oluştur";
            // 
            // CmbMalzeme
            // 
            this.CmbMalzeme.FormattingEnabled = true;
            this.CmbMalzeme.Location = new System.Drawing.Point(73, 73);
            this.CmbMalzeme.Name = "CmbMalzeme";
            this.CmbMalzeme.Size = new System.Drawing.Size(186, 30);
            this.CmbMalzeme.TabIndex = 12;
            this.CmbMalzeme.SelectedIndexChanged += new System.EventHandler(this.CmbMalzeme_SelectedIndexChanged);
            // 
            // CmbUrun
            // 
            this.CmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUrun.FormattingEnabled = true;
            this.CmbUrun.Location = new System.Drawing.Point(73, 38);
            this.CmbUrun.Name = "CmbUrun";
            this.CmbUrun.Size = new System.Drawing.Size(186, 30);
            this.CmbUrun.TabIndex = 11;
            // 
            // BtnUrunOlustur
            // 
            this.BtnUrunOlustur.Location = new System.Drawing.Point(73, 223);
            this.BtnUrunOlustur.Name = "BtnUrunOlustur";
            this.BtnUrunOlustur.Size = new System.Drawing.Size(186, 36);
            this.BtnUrunOlustur.TabIndex = 10;
            this.BtnUrunOlustur.Text = "Ekle";
            this.BtnUrunOlustur.UseVisualStyleBackColor = true;
            this.BtnUrunOlustur.Click += new System.EventHandler(this.BtnUrunOlustur_Click);
            // 
            // TxtUrunMaliyet
            // 
            this.TxtUrunMaliyet.Location = new System.Drawing.Point(73, 143);
            this.TxtUrunMaliyet.Name = "TxtUrunMaliyet";
            this.TxtUrunMaliyet.Size = new System.Drawing.Size(186, 29);
            this.TxtUrunMaliyet.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 22);
            this.label12.TabIndex = 6;
            this.label12.Text = "Maliyet:";
            // 
            // TxtUrunMiktar
            // 
            this.TxtUrunMiktar.Location = new System.Drawing.Point(73, 108);
            this.TxtUrunMiktar.Name = "TxtUrunMiktar";
            this.TxtUrunMiktar.Size = new System.Drawing.Size(186, 29);
            this.TxtUrunMiktar.TabIndex = 5;
            this.TxtUrunMiktar.TextChanged += new System.EventHandler(this.TxtUrunMiktar_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 22);
            this.label13.TabIndex = 4;
            this.label13.Text = "Miktar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 22);
            this.label14.TabIndex = 2;
            this.label14.Text = "Malzeme:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 22);
            this.label15.TabIndex = 0;
            this.label15.Text = "Ürün:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnCikis);
            this.groupBox5.Controls.Add(this.BtnKasa);
            this.groupBox5.Controls.Add(this.BtnMalzemeListesi);
            this.groupBox5.Controls.Add(this.BtnUrunListesi);
            this.groupBox5.Location = new System.Drawing.Point(923, 403);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(290, 201);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ürün Oluştur";
            // 
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(22, 159);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(251, 36);
            this.BtnCikis.TabIndex = 14;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnKasa
            // 
            this.BtnKasa.Location = new System.Drawing.Point(22, 117);
            this.BtnKasa.Name = "BtnKasa";
            this.BtnKasa.Size = new System.Drawing.Size(251, 36);
            this.BtnKasa.TabIndex = 13;
            this.BtnKasa.Text = "Kasa";
            this.BtnKasa.UseVisualStyleBackColor = true;
            this.BtnKasa.Click += new System.EventHandler(this.BtnKasa_Click);
            // 
            // BtnMalzemeListesi
            // 
            this.BtnMalzemeListesi.Location = new System.Drawing.Point(22, 75);
            this.BtnMalzemeListesi.Name = "BtnMalzemeListesi";
            this.BtnMalzemeListesi.Size = new System.Drawing.Size(251, 36);
            this.BtnMalzemeListesi.TabIndex = 12;
            this.BtnMalzemeListesi.Text = "Malzeme Listesi";
            this.BtnMalzemeListesi.UseVisualStyleBackColor = true;
            this.BtnMalzemeListesi.Click += new System.EventHandler(this.BtnMalzemeListesi_Click);
            // 
            // BtnUrunListesi
            // 
            this.BtnUrunListesi.Location = new System.Drawing.Point(22, 33);
            this.BtnUrunListesi.Name = "BtnUrunListesi";
            this.BtnUrunListesi.Size = new System.Drawing.Size(251, 36);
            this.BtnUrunListesi.TabIndex = 11;
            this.BtnUrunListesi.Text = "Ürün Listesi";
            this.BtnUrunListesi.UseVisualStyleBackColor = true;
            this.BtnUrunListesi.Click += new System.EventHandler(this.BtnUrunListesi_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBox1);
            this.groupBox6.Location = new System.Drawing.Point(923, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(290, 385);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ürün Oluştur";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(3, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(284, 357);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1225, 673);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnMalzemeGetir;
        private System.Windows.Forms.Button BtnMalzemeEkle;
        private System.Windows.Forms.TextBox TxtMalzemeNot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMalzemeFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtMalzemeStok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMalzemeAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMalzemeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnUrunGuncelle;
        private System.Windows.Forms.Button BtnUrunEkle;
        private System.Windows.Forms.TextBox TxtUrunSFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUrunMFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtUrunStok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtUrunAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtUrunID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnUrunOlustur;
        private System.Windows.Forms.TextBox TxtUrunMaliyet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtUrunMiktar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnKasa;
        private System.Windows.Forms.Button BtnMalzemeListesi;
        private System.Windows.Forms.Button BtnUrunListesi;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox CmbMalzeme;
        private System.Windows.Forms.ComboBox CmbUrun;
    }
}

