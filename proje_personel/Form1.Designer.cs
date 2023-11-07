using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace proje_personel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.projecinsiyetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciprojeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanici_projeDataSet = new proje_personel.kullanici_projeDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.projemedenidurumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.projeillerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox9 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox10 = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.projeillerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proje_illerTableAdapter = new proje_personel.kullanici_projeDataSetTableAdapters.proje_illerTableAdapter();
            this.proje_medeni_durumTableAdapter = new proje_personel.kullanici_projeDataSetTableAdapters.proje_medeni_durumTableAdapter();
            this.proje_cinsiyetTableAdapter = new proje_personel.kullanici_projeDataSetTableAdapters.proje_cinsiyetTableAdapter();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.projeilcelerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projeilcelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proje_ilcelerTableAdapter = new proje_personel.kullanici_projeDataSetTableAdapters.proje_ilcelerTableAdapter();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.projesubelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proje_subelerTableAdapter = new proje_personel.kullanici_projeDataSetTableAdapters.proje_subelerTableAdapter();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.egitimdurumuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.egitim_durumuTableAdapter = new proje_personel.kullanici_projeDataSetTableAdapters.egitim_durumuTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.projeillerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.maskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.maskedTextBox11 = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.maskedTextBox12 = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.maskedTextBox13 = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.maskedTextBox14 = new System.Windows.Forms.MaskedTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.maskedTextBox16 = new System.Windows.Forms.MaskedTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.maskedTextBox17 = new System.Windows.Forms.MaskedTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.maskedTextBox18 = new System.Windows.Forms.MaskedTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.maskedTextBox19 = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projecinsiyetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciprojeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanici_projeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projemedenidurumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeillerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeillerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeilcelerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeilcelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projesubelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egitimdurumuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeillerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "İkinci İsim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "TC No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Medeni Durum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Doğum Yeri:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Doğum Tarihi:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.projecinsiyetBindingSource;
            this.comboBox2.DisplayMember = "cinsiyet";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(163, 310);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(110, 21);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.ValueMember = "id";
            // 
            // projecinsiyetBindingSource
            // 
            this.projecinsiyetBindingSource.DataMember = "proje_cinsiyet";
            this.projecinsiyetBindingSource.DataSource = this.kullaniciprojeDataSetBindingSource;
            // 
            // kullaniciprojeDataSetBindingSource
            // 
            this.kullaniciprojeDataSetBindingSource.DataSource = this.kullanici_projeDataSet;
            this.kullaniciprojeDataSetBindingSource.Position = 0;
            // 
            // kullanici_projeDataSet
            // 
            this.kullanici_projeDataSet.DataSetName = "kullanici_projeDataSet";
            this.kullanici_projeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.projemedenidurumBindingSource;
            this.comboBox1.DisplayMember = "medeni_durum";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(396, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "id";
            // 
            // projemedenidurumBindingSource
            // 
            this.projemedenidurumBindingSource.DataMember = "proje_medeni_durum";
            this.projemedenidurumBindingSource.DataSource = this.kullaniciprojeDataSetBindingSource;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.projeillerBindingSource1;
            this.comboBox3.DisplayMember = "sehiradi";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(396, 165);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(110, 21);
            this.comboBox3.TabIndex = 23;
            this.comboBox3.ValueMember = "id";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // projeillerBindingSource1
            // 
            this.projeillerBindingSource1.DataMember = "proje_iller";
            this.projeillerBindingSource1.DataSource = this.kullaniciprojeDataSetBindingSource;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(337, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Anne Adı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(337, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Baba Adı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(297, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Anne Kızlık Soyadı:";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(163, 164);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBox3.TabIndex = 32;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(163, 200);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBox4.TabIndex = 33;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(163, 236);
            this.maskedTextBox5.Mask = "00000000000";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBox5.TabIndex = 34;
            this.maskedTextBox5.ValidatingType = typeof(int);
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Location = new System.Drawing.Point(163, 272);
            this.maskedTextBox6.Mask = "00/00/0000";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBox6.TabIndex = 35;
            this.maskedTextBox6.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.Location = new System.Drawing.Point(396, 203);
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBox7.TabIndex = 36;
            // 
            // maskedTextBox9
            // 
            this.maskedTextBox9.Location = new System.Drawing.Point(396, 241);
            this.maskedTextBox9.Name = "maskedTextBox9";
            this.maskedTextBox9.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBox9.TabIndex = 38;
            // 
            // maskedTextBox10
            // 
            this.maskedTextBox10.Location = new System.Drawing.Point(396, 280);
            this.maskedTextBox10.Name = "maskedTextBox10";
            this.maskedTextBox10.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBox10.TabIndex = 39;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(542, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 56);
            this.button2.TabIndex = 41;
            this.button2.Text = "KAYIT OL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // projeillerBindingSource
            // 
            this.projeillerBindingSource.DataMember = "proje_iller";
            this.projeillerBindingSource.DataSource = this.kullanici_projeDataSet;
            // 
            // proje_illerTableAdapter
            // 
            this.proje_illerTableAdapter.ClearBeforeFill = true;
            // 
            // proje_medeni_durumTableAdapter
            // 
            this.proje_medeni_durumTableAdapter.ClearBeforeFill = true;
            // 
            // proje_cinsiyetTableAdapter
            // 
            this.proje_cinsiyetTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.projeilcelerBindingSource1;
            this.comboBox4.DisplayMember = "ilceadi";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(706, 158);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(116, 21);
            this.comboBox4.TabIndex = 42;
            this.comboBox4.ValueMember = "id";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // projeilcelerBindingSource1
            // 
            this.projeilcelerBindingSource1.DataMember = "proje_ilceler";
            this.projeilcelerBindingSource1.DataSource = this.kullaniciprojeDataSetBindingSource;
            // 
            // projeilcelerBindingSource
            // 
            this.projeilcelerBindingSource.DataMember = "proje_ilceler";
            this.projeilcelerBindingSource.DataSource = this.kullaniciprojeDataSetBindingSource;
            // 
            // proje_ilcelerTableAdapter
            // 
            this.proje_ilcelerTableAdapter.ClearBeforeFill = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(163, 127);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBox1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "İsim:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Eğitim Durumu:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label14.Location = new System.Drawing.Point(355, 359);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Şube:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.projesubelerBindingSource;
            this.comboBox5.DisplayMember = "sube_adi";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(396, 356);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(110, 21);
            this.comboBox5.TabIndex = 49;
            this.comboBox5.ValueMember = "id";
            // 
            // projesubelerBindingSource
            // 
            this.projesubelerBindingSource.DataMember = "proje_subeler";
            this.projesubelerBindingSource.DataSource = this.kullaniciprojeDataSetBindingSource;
            // 
            // proje_subelerTableAdapter
            // 
            this.proje_subelerTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.egitimdurumuBindingSource;
            this.comboBox6.DisplayMember = "egitim_durumu";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(396, 317);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(110, 21);
            this.comboBox6.TabIndex = 50;
            this.comboBox6.ValueMember = "id";
            // 
            // egitimdurumuBindingSource
            // 
            this.egitimdurumuBindingSource.DataMember = "egitim_durumu";
            this.egitimdurumuBindingSource.DataSource = this.kullaniciprojeDataSetBindingSource;
            // 
            // egitim_durumuTableAdapter
            // 
            this.egitim_durumuTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(511, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "MÜŞTERİ KAYIT";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label15.Location = new System.Drawing.Point(670, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = " İlçe:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(703, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 20);
            this.label16.TabIndex = 53;
            this.label16.Text = "Adres Bilgileri";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label17.Location = new System.Drawing.Point(682, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 13);
            this.label17.TabIndex = 55;
            this.label17.Text = " İl:";
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.projeillerBindingSource2;
            this.comboBox7.DisplayMember = "sehiradi";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(706, 126);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(116, 21);
            this.comboBox7.TabIndex = 54;
            this.comboBox7.ValueMember = "id";
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // projeillerBindingSource2
            // 
            this.projeillerBindingSource2.DataMember = "proje_iller";
            this.projeillerBindingSource2.DataSource = this.kullaniciprojeDataSetBindingSource;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(675, 196);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 57;
            this.label18.Text = "Köy:";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(706, 193);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBox2.TabIndex = 56;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(657, 232);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 59;
            this.label19.Text = "Mahalle:";
            // 
            // maskedTextBox8
            // 
            this.maskedTextBox8.Location = new System.Drawing.Point(707, 229);
            this.maskedTextBox8.Name = "maskedTextBox8";
            this.maskedTextBox8.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBox8.TabIndex = 58;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(662, 307);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 63;
            this.label20.Text = "Sokak:";
            // 
            // maskedTextBox11
            // 
            this.maskedTextBox11.Location = new System.Drawing.Point(706, 304);
            this.maskedTextBox11.Name = "maskedTextBox11";
            this.maskedTextBox11.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBox11.TabIndex = 62;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(663, 268);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 61;
            this.label21.Text = "Cadde:";
            // 
            // maskedTextBox12
            // 
            this.maskedTextBox12.Location = new System.Drawing.Point(707, 265);
            this.maskedTextBox12.Name = "maskedTextBox12";
            this.maskedTextBox12.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBox12.TabIndex = 60;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(661, 378);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 67;
            this.label22.Text = "Ev No:";
            // 
            // maskedTextBox13
            // 
            this.maskedTextBox13.Location = new System.Drawing.Point(707, 375);
            this.maskedTextBox13.Name = "maskedTextBox13";
            this.maskedTextBox13.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBox13.TabIndex = 66;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(657, 342);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 13);
            this.label23.TabIndex = 65;
            this.label23.Text = "Bina No:";
            // 
            // maskedTextBox14
            // 
            this.maskedTextBox14.Location = new System.Drawing.Point(707, 339);
            this.maskedTextBox14.Name = "maskedTextBox14";
            this.maskedTextBox14.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBox14.TabIndex = 64;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(935, 92);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(129, 20);
            this.label24.TabIndex = 68;
            this.label24.Text = "İletişim Bilgileri";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(911, 232);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 13);
            this.label26.TabIndex = 76;
            this.label26.Text = "Email:";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // maskedTextBox16
            // 
            this.maskedTextBox16.Location = new System.Drawing.Point(948, 229);
            this.maskedTextBox16.Name = "maskedTextBox16";
            this.maskedTextBox16.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBox16.TabIndex = 75;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(861, 199);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(85, 13);
            this.label27.TabIndex = 74;
            this.label27.Text = "Cep Telefon No:";
            // 
            // maskedTextBox17
            // 
            this.maskedTextBox17.Location = new System.Drawing.Point(948, 196);
            this.maskedTextBox17.Mask = "0000000000";
            this.maskedTextBox17.Name = "maskedTextBox17";
            this.maskedTextBox17.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBox17.TabIndex = 73;
            this.maskedTextBox17.ValidatingType = typeof(int);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(872, 165);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(74, 13);
            this.label28.TabIndex = 72;
            this.label28.Text = "İş Telefon No:";
            // 
            // maskedTextBox18
            // 
            this.maskedTextBox18.Location = new System.Drawing.Point(948, 162);
            this.maskedTextBox18.Mask = "000000000000";
            this.maskedTextBox18.Name = "maskedTextBox18";
            this.maskedTextBox18.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBox18.TabIndex = 71;
            this.maskedTextBox18.ValidatingType = typeof(int);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(867, 129);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(79, 13);
            this.label29.TabIndex = 70;
            this.label29.Text = "Ev Telefon No:";
            // 
            // maskedTextBox19
            // 
            this.maskedTextBox19.Location = new System.Drawing.Point(948, 126);
            this.maskedTextBox19.Mask = "00000000000";
            this.maskedTextBox19.Name = "maskedTextBox19";
            this.maskedTextBox19.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBox19.TabIndex = 69;
            this.maskedTextBox19.ValidatingType = typeof(int);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(260, 92);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(119, 20);
            this.label25.TabIndex = 77;
            this.label25.Text = "Kişisel Bilgiler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 483);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.maskedTextBox16);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.maskedTextBox17);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.maskedTextBox18);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.maskedTextBox19);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.maskedTextBox13);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.maskedTextBox14);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.maskedTextBox11);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.maskedTextBox12);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.maskedTextBox8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.maskedTextBox10);
            this.Controls.Add(this.maskedTextBox9);
            this.Controls.Add(this.maskedTextBox7);
            this.Controls.Add(this.maskedTextBox6);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.projecinsiyetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciprojeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanici_projeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projemedenidurumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeillerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeillerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeilcelerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeilcelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projesubelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egitimdurumuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeillerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label10;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private Label label11;
        private Label label12;
        private Label label13;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox5;
        private MaskedTextBox maskedTextBox6;
        private MaskedTextBox maskedTextBox7;
        private MaskedTextBox maskedTextBox9;
        private MaskedTextBox maskedTextBox10;
        private Button button2;
        private kullanici_projeDataSet kullanici_projeDataSet;
        private BindingSource projeillerBindingSource;
        private kullanici_projeDataSetTableAdapters.proje_illerTableAdapter proje_illerTableAdapter;
        private BindingSource kullaniciprojeDataSetBindingSource;
        private BindingSource projemedenidurumBindingSource;
        private kullanici_projeDataSetTableAdapters.proje_medeni_durumTableAdapter proje_medeni_durumTableAdapter;
        private BindingSource projecinsiyetBindingSource;
        private kullanici_projeDataSetTableAdapters.proje_cinsiyetTableAdapter proje_cinsiyetTableAdapter;
        private BindingSource projeillerBindingSource1;
        private ComboBox comboBox4;
        private BindingSource projeilcelerBindingSource;
        private kullanici_projeDataSetTableAdapters.proje_ilcelerTableAdapter proje_ilcelerTableAdapter;
        private BindingSource projeilcelerBindingSource1;
        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Label label9;
        private Label label14;
        private ComboBox comboBox5;
        private BindingSource projesubelerBindingSource;
        private kullanici_projeDataSetTableAdapters.proje_subelerTableAdapter proje_subelerTableAdapter;
        private ComboBox comboBox6;
        private BindingSource egitimdurumuBindingSource;
        private kullanici_projeDataSetTableAdapters.egitim_durumuTableAdapter egitim_durumuTableAdapter;
        private Label label7;
        private Label label15;
        private Label label16;
        private Label label17;
        private ComboBox comboBox7;
        private Label label18;
        private MaskedTextBox maskedTextBox2;
        private Label label19;
        private MaskedTextBox maskedTextBox8;
        private Label label20;
        private MaskedTextBox maskedTextBox11;
        private Label label21;
        private MaskedTextBox maskedTextBox12;
        private Label label22;
        private MaskedTextBox maskedTextBox13;
        private Label label23;
        private MaskedTextBox maskedTextBox14;
        private Label label24;
        private Label label26;
        private MaskedTextBox maskedTextBox16;
        private Label label27;
        private MaskedTextBox maskedTextBox17;
        private Label label28;
        private MaskedTextBox maskedTextBox18;
        private Label label29;
        private MaskedTextBox maskedTextBox19;
        private Label label25;
        private BindingSource projeillerBindingSource2;
    }
}