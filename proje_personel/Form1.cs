using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using Newtonsoft.Json;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace proje_personel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PPM9TPL;Initial Catalog=kullanici_proje;Integrated Security=True");
        int ilceid;

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBox1.Text) || string.IsNullOrEmpty(maskedTextBox4.Text) || string.IsNullOrEmpty(maskedTextBox5.Text)
                || string.IsNullOrEmpty(maskedTextBox6.Text) || string.IsNullOrEmpty(comboBox2.SelectedValue.ToString()) || string.IsNullOrEmpty(comboBox3.SelectedValue.ToString()) || string.IsNullOrEmpty(maskedTextBox7.Text) ||
                string.IsNullOrEmpty(maskedTextBox9.Text) || string.IsNullOrEmpty(maskedTextBox10.Text) || string.IsNullOrEmpty(comboBox5.SelectedValue.ToString()) || string.IsNullOrEmpty(comboBox7.SelectedValue.ToString()) || string.IsNullOrEmpty(ilceid.ToString()) ||
                string.IsNullOrEmpty(maskedTextBox8.Text) || string.IsNullOrEmpty(maskedTextBox14.Text) || string.IsNullOrEmpty(maskedTextBox13.Text) || string.IsNullOrEmpty(maskedTextBox17.Text))
            {
                MessageBox.Show("Tüm zorunlu alanlar doldurulmalı.");
                return;
            }

            string kontrol = "SELECT COUNT(*) FROM musteri_bilgileri WHERE tc_no = @tc_no";

            baglanti.Open();
            SqlCommand komut0 = new SqlCommand();
            komut0 = new SqlCommand(kontrol, baglanti);
            komut0.Connection = baglanti;

            komut0.Parameters.AddWithValue("@tc_no", maskedTextBox5.Text);

            int count = (int)komut0.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Girilen kullanıcı sistemde kayıtlı.");
                baglanti.Close();
                return;
            }

            baglanti.Close();

            string ekle = "INSERT INTO musteri_bilgileri(ad,ikinci_ad,soyad,tc_no,dogum_tarihi,cinsiyet,medeni_durum,doogum_yeri, anne_ad, baba_ad, anne_kizlik_soyad, egitim_durumu, musteri_subesi, musteri_olma_tarihi) values (@ad," +
                " @ikinci_ad, @soyad, @tc_no, @dogum_tarihi, @cinsiyet, @medeni_durum, @doogum_yeri, @anne_ad, @baba_ad, @anne_kizlik_soyad, @egitim_durumu, @musteri_subesi, @musteri_olma_tarihi)";
            string iletisimekle = "INSERT INTO musteri_iletisim_bilgileri(il, ilce, koy, mahalle, cadde, sokak, bina_no, ev_no, ev_telefon_no, is_telefon_no, cep_telefon_no, email) " +
                "values (@il, @ilce, @koy, @mahalle, @cadde, @sokak, @bina_no, @ev_no, @ev_telefon_no, @is_telefon_no, @cep_telefon_no, @email)";

            SqlCommand komut1 = new SqlCommand();
            komut1 = new SqlCommand(ekle, baglanti);
            baglanti.Open();

            komut1.Connection = baglanti;

            komut1.Parameters.AddWithValue("@ad", maskedTextBox1.Text);
            komut1.Parameters.AddWithValue("@ikinci_ad", maskedTextBox3.Text);
            komut1.Parameters.AddWithValue("@soyad", maskedTextBox4.Text);
            komut1.Parameters.AddWithValue("@tc_no", maskedTextBox5.Text);
            komut1.Parameters.AddWithValue("@dogum_tarihi", maskedTextBox6.Text);
            komut1.Parameters.AddWithValue("@cinsiyet", comboBox2.SelectedValue);
            komut1.Parameters.AddWithValue("@medeni_durum", comboBox1.SelectedValue);
            komut1.Parameters.AddWithValue("@doogum_yeri", comboBox3.SelectedValue);
            komut1.Parameters.AddWithValue("@anne_ad", maskedTextBox7.Text);
            komut1.Parameters.AddWithValue("@baba_ad", maskedTextBox9.Text);
            komut1.Parameters.AddWithValue("@anne_kizlik_soyad", maskedTextBox10.Text);
            komut1.Parameters.AddWithValue("@egitim_durumu", comboBox6.SelectedValue);
            komut1.Parameters.AddWithValue("@musteri_subesi", comboBox5.SelectedValue);
            komut1.Parameters.AddWithValue("@musteri_olma_tarihi", DateTime.Now.ToString("MM - dd - yyyy"));

            komut1.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand();
            komut2 = new SqlCommand(iletisimekle, baglanti);

            komut2.Connection = baglanti;

            komut2.Parameters.AddWithValue("@il",comboBox7.SelectedValue);
            komut2.Parameters.AddWithValue("@ilce", ilceid);
            komut2.Parameters.AddWithValue("@koy", maskedTextBox2.Text);
            komut2.Parameters.AddWithValue("@mahalle", maskedTextBox8.Text);
            komut2.Parameters.AddWithValue("@cadde", maskedTextBox12.Text);
            komut2.Parameters.AddWithValue("@sokak", maskedTextBox11.Text);
            komut2.Parameters.AddWithValue("@bina_no", maskedTextBox14.Text);
            komut2.Parameters.AddWithValue("@ev_no", maskedTextBox13.Text);
            komut2.Parameters.AddWithValue("@ev_telefon_no", maskedTextBox19.Text);
            komut2.Parameters.AddWithValue("@is_telefon_no", maskedTextBox18.Text);
            komut2.Parameters.AddWithValue("@cep_telefon_no", maskedTextBox17.Text);
            komut2.Parameters.AddWithValue("@email", maskedTextBox16.Text);

            komut2.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt Tamamlandı.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kullanici_projeDataSet.proje_iller' table. You can move, or remove it, as needed.
            this.proje_illerTableAdapter.Fill(this.kullanici_projeDataSet.proje_iller);
            // TODO: This line of code loads data into the 'kullanici_projeDataSet.egitim_durumu' table. You can move, or remove it, as needed.
            this.egitim_durumuTableAdapter.Fill(this.kullanici_projeDataSet.egitim_durumu);
            // TODO: This line of code loads data into the 'kullanici_projeDataSet.proje_subeler' table. You can move, or remove it, as needed.
            this.proje_subelerTableAdapter.Fill(this.kullanici_projeDataSet.proje_subeler);
            // TODO: This line of code loads data into the 'kullanici_projeDataSet.proje_ilceler' table. You can move, or remove it, as needed.
            this.proje_ilcelerTableAdapter.Fill(this.kullanici_projeDataSet.proje_ilceler);
            // TODO: This line of code loads data into the 'kullanici_projeDataSet.proje_ilceler' table. You can move, or remove it, as needed.
            this.proje_ilcelerTableAdapter.Fill(this.kullanici_projeDataSet.proje_ilceler);
            // TODO: This line of code loads data into the 'kullanici_projeDataSet.proje_cinsiyet' table. You can move, or remove it, as needed.
            this.proje_cinsiyetTableAdapter.Fill(this.kullanici_projeDataSet.proje_cinsiyet);
            // TODO: This line of code loads data into the 'kullanici_projeDataSet.proje_medeni_durum' table. You can move, or remove it, as needed.
            this.proje_medeni_durumTableAdapter.Fill(this.kullanici_projeDataSet.proje_medeni_durum);
            // TODO: This line of code loads data into the 'kullanici_projeDataSet.proje_iller' table. You can move, or remove it, as needed.
            this.proje_illerTableAdapter.Fill(this.kullanici_projeDataSet.proje_iller);

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceid = comboBox4.SelectedIndex;
        }

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.proje_ilcelerTableAdapter.FillBy4(this.kullanici_projeDataSet.proje_ilceler);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(comboBox7.SelectedIndex > -1 ))
            {
                comboBox7.SelectedIndex = 0;
            }
            DataTable dataTable = new DataTable();
            string sqlquery = "SELECT ilceadi FROM proje_ilceler WHERE sehirid = " + ((comboBox7.SelectedIndex + 1).ToString()) + ";";
            SqlCommand cmd = new SqlCommand(sqlquery, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            var json = JsonConvert.SerializeObject(dataTable);
            var iList = JsonConvert.DeserializeObject<IList>(json);

            comboBox4.DataSource = iList;
        }
    }
}