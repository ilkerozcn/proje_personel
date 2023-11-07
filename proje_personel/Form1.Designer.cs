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
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "İkinci İsim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "TC No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Medeni Durum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Doğum Yeri:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 243);
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
            this.comboBox2.Location = new System.Drawing.Point(125, 279);
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
            this.comboBox1.Location = new System.Drawing.Point(125, 317);
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
            this.comboBox3.Location = new System.Drawing.Point(125, 357);
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
            this.label11.Location = new System.Drawing.Point(66, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Anne Adı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(66, 436);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Baba Adı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 475);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Anne Kızlık Soyadı:";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(125, 133);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBox3.TabIndex = 32;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(125, 169);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBox4.TabIndex = 33;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(125, 205);
            this.maskedTextBox5.Mask = "00000000000";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBox5.TabIndex = 34;
            this.maskedTextBox5.ValidatingType = typeof(int);
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Location = new System.Drawing.Point(125, 241);
            this.maskedTextBox6.Mask = "00/00/0000";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBox6.TabIndex = 35;
            this.maskedTextBox6.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.Location = new System.Drawing.Point(125, 395);
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBox7.TabIndex = 36;
            // 
            // maskedTextBox9
            // 
            this.maskedTextBox9.Location = new System.Drawing.Point(125, 433);
            this.maskedTextBox9.Name = "maskedTextBox9";
            this.maskedTextBox9.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBox9.TabIndex = 38;
            // 
            // maskedTextBox10
            // 
            this.maskedTextBox10.Location = new System.Drawing.Point(125, 472);
            this.maskedTextBox10.Name = "maskedTextBox10";
            this.maskedTextBox10.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBox10.TabIndex = 39;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "button2";
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
            this.comboBox4.Location = new System.Drawing.Point(374, 357);
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
            this.maskedTextBox1.Location = new System.Drawing.Point(125, 96);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBox1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "İsim:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 512);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Eğitim Durumu:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label14.Location = new System.Drawing.Point(84, 551);
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
            this.comboBox5.Location = new System.Drawing.Point(125, 548);
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
            this.comboBox6.Location = new System.Drawing.Point(125, 509);
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
            this.label7.Location = new System.Drawing.Point(262, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "MÜŞTERİ KAYIT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 703);
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
    }
}