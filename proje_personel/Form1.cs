using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using Newtonsoft.Json;
using System.Collections;

namespace proje_personel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PPM9TPL;Initial Catalog=kullanici_proje;Integrated Security=True");


        private void button2_Click(object sender, EventArgs e)
        {
            string ekle = "INSERT INTO musteri_bilgileri(ad,ikinci_ad,soyad,tc_no,dogum_tarihi,cinsiyet,medeni_durum,doogum_yeri, anne_ad, baba_ad, anne_kizlik_soyad, egitim_durumu, musteri_subesi, musteri_olma_tarihi) values (@ad," +
                " @ikinci_ad, @soyad, @tc_no, @dogum_tarihi, @cinsiyet, @medeni_durum, @doogum_yeri, @anne_ad, @baba_ad, @anne_kizlik_soyad, @egitim_durumu, @musteri_subesi, @musteri_olma_tarihi)";
            /*int cinsiyet = 0;
            int medeni_durum = 0;*/

            SqlCommand komut = new SqlCommand();
            komut = new SqlCommand(ekle, baglanti);
            baglanti.Open();

            komut.Connection = baglanti;

            komut.Parameters.AddWithValue("@ad", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@ikinci_ad", maskedTextBox3.Text);
            komut.Parameters.AddWithValue("@soyad", maskedTextBox4.Text);
            komut.Parameters.AddWithValue("@tc_no", maskedTextBox5.Text);
            komut.Parameters.AddWithValue("@dogum_tarihi", maskedTextBox6.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboBox2.SelectedValue);
            komut.Parameters.AddWithValue("@medeni_durum", comboBox1.SelectedValue);
            komut.Parameters.AddWithValue("@doogum_yeri", comboBox3.SelectedValue);
            komut.Parameters.AddWithValue("@anne_ad", maskedTextBox7.Text);
            komut.Parameters.AddWithValue("@baba_ad", maskedTextBox9.Text);
            komut.Parameters.AddWithValue("@anne_kizlik_soyad", maskedTextBox10.Text);
            komut.Parameters.AddWithValue("@egitim_durumu", comboBox6.SelectedValue);
            komut.Parameters.AddWithValue("@musteri_subesi", comboBox5.SelectedValue);
            komut.Parameters.AddWithValue("@musteri_olma_tarihi", DateTime.Now.ToString("MM - dd - yyyy"));

            komut.ExecuteNonQuery();

            baglanti.Close();

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
            DataTable dataTable = new DataTable();
            string sqlquery = "SELECT ilceadi FROM proje_ilceler WHERE sehirid = " + ((comboBox3.SelectedIndex +1).ToString()) + ";";
            SqlCommand cmd = new SqlCommand(sqlquery, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            var json = JsonConvert.SerializeObject(dataTable);
            var iList = JsonConvert.DeserializeObject<IList>(json);
            comboBox4.DataSource = iList;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}