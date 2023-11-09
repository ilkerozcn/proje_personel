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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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
            if (!button4.Visible && string.IsNullOrEmpty(maskedTextBox1.Text) || string.IsNullOrEmpty(maskedTextBox4.Text) || string.IsNullOrEmpty(maskedTextBox5.Text)
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

            if (count > 0 && button2.Visible && !button4.Visible)
            {
                MessageBox.Show("Girilen kullanıcı sistemde kayıtlı.");
                baglanti.Close();
                return;
            }

            email_text_kontrol();

            baglanti.Close();

            string musteriNoQuery = "SELECT TOP 1 musteri_no FROM musteri_bilgileri ORDER BY musteri_no DESC;";
            string ekle = "INSERT INTO musteri_bilgileri(musteri_no, ad,ikinci_ad,soyad,tc_no,dogum_tarihi,cinsiyet,medeni_durum,doogum_yeri, anne_ad, baba_ad, anne_kizlik_soyad, egitim_durumu, musteri_subesi, musteri_olma_tarihi) values (@musteri_no, @ad," +
                " @ikinci_ad, @soyad, @tc_no, @dogum_tarihi, @cinsiyet, @medeni_durum, @doogum_yeri, @anne_ad, @baba_ad, @anne_kizlik_soyad, @egitim_durumu, @musteri_subesi, @musteri_olma_tarihi)";
            string iletisimekle = "INSERT INTO musteri_iletisim_bilgileri(musteri_no, il, ilce, koy, mahalle, cadde, sokak, bina_no, ev_no, ev_telefon_no, is_telefon_no, cep_telefon_no, email) " +
                "values (@musteri_no, @il, @ilce, @koy, @mahalle, @cadde, @sokak, @bina_no, @ev_no, @ev_telefon_no, @is_telefon_no, @cep_telefon_no, @email)";

            baglanti.Open();
            SqlCommand idKomut = new SqlCommand();
            idKomut = new SqlCommand(musteriNoQuery, baglanti);
            Int64 musteriNo;
            Int64? sonmusterino = (Int64)idKomut.ExecuteScalar();
            baglanti.Close();

            if (!sonmusterino.HasValue)
            {
                musteriNo = 1;
            }
            else
            {
                musteriNo = sonmusterino.Value + 1;
            }

            SqlCommand komut1 = new SqlCommand();
            komut1 = new SqlCommand(ekle, baglanti);
            baglanti.Open();

            komut1.Connection = baglanti;

            komut1.Parameters.AddWithValue("@musteri_no", musteriNo);
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

            komut2.Parameters.AddWithValue("@musteri_no", musteriNo);
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

        private void email_text_kontrol()
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (maskedTextBox16.Text.Length > 0 && maskedTextBox16.Text.Trim().Length != 0)
            {
                if (!rEmail.IsMatch(maskedTextBox16.Text.Trim()))
                {
                    MessageBox.Show("Email adresinin doğru yazıldığından emin olun.");
                    maskedTextBox16.SelectAll();
                    return;
                }
            }
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox16_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox17_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox6_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"^(\d{1,2})/(\d{1,2})/(\d{4})$");
            Match m = reg.Match(maskedTextBox6.Text);
            if (m.Success)
            {
                int dd = int.Parse(m.Groups[1].Value);
                int mm = int.Parse(m.Groups[2].Value);
                int yyyy = int.Parse(m.Groups[3].Value);
                e.Cancel = dd < 1 || dd > 31 || mm < 1 || mm > 12 || yyyy > 2005;
            }
            else e.Cancel = true;
            if (e.Cancel)
            {
                MessageBox.Show("Doğum tarihini doğru yazdığınızdan emin olunuz.");
                    e.Cancel = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label32.Visible = false;
            label7.Visible = true;
            panel1.Visible = true;
            button2.Visible = true;
            button4.Visible = false;
            maskedTextBox15.Visible = false;
            label31.Visible = false;
            button5.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {   label32.Visible = true;
            label7.Visible = false;
            panel1.Visible = false;
            button2.Visible = false;
            button4.Visible = true;
            maskedTextBox15.Visible = true;
            label31.Visible = true;
            button5.Visible = true;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*
            baglanti.Open();
            SqlCommand musteriKomut = new SqlCommand(mustersorgu, baglanti);
            var musteri = musteriKomut.ExecuteReader();
            Console.WriteLine(musteri);
            baglanti.Close()
            */;
            int cinsiyet = 0, medeniDurum = 0, egitimDurumu = 0, sube = 0, dogumYeri = 0;
            bool musteriVarMi = false;

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PPM9TPL;Initial Catalog=kullanici_proje;Integrated Security=True"))
            {
                connection.Open();

                string mustersorgu = "Select * FROM musteri_bilgileri WHERE tc_no = '" + maskedTextBox15.Text + "'";

                using (SqlCommand command = new SqlCommand(mustersorgu, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {  
                        Int64 musteriNo = reader.GetInt64(reader.GetOrdinal("musteri_no"));
                        if (musteriNo > 0)
                        {
                            panel1.Visible = true;
                            musteriVarMi = true;
                        }
                        else
                        {
                            panel1.Visible = false;
                            MessageBox.Show("Girilen Tc no ile müşteri bulunamadı.");
                        }

                        string ad = reader.GetString(reader.GetOrdinal("ad"));
                        string ikinci_ad = reader.GetString(reader.GetOrdinal("ikinci_ad"));
                        string soyad = reader.GetString(reader.GetOrdinal("soyad"));
                        Int64 tcno = reader.GetInt64(reader.GetOrdinal("tc_no"));
                        DateTime dogumTarihi = reader.GetDateTime(reader.GetOrdinal("dogum_tarihi"));
                        cinsiyet = reader.GetInt32(reader.GetOrdinal("cinsiyet")); ;
                        medeniDurum = reader.GetInt32(reader.GetOrdinal("medeni_durum"));
                        dogumYeri = reader.GetInt32(reader.GetOrdinal("doogum_yeri"));
                        string anneAdi = reader.GetString(reader.GetOrdinal("anne_ad"));
                        string babaAdi = reader.GetString(reader.GetOrdinal("baba_ad"));
                        string anneKizlikSoyad = reader.GetString(reader.GetOrdinal("anne_kizlik_soyad"));
                        egitimDurumu = reader.GetInt32(reader.GetOrdinal("egitim_durumu"));
                        sube = reader.GetInt32(reader.GetOrdinal("musteri_subesi"));

                        maskedTextBox1.Text = ad;
                        maskedTextBox3.Text = ikinci_ad;
                        maskedTextBox4.Text = soyad;
                        maskedTextBox5.Text = tcno.ToString();
                        maskedTextBox6.Text = dogumTarihi.ToString();
                        comboBox2.SelectedValue = cinsiyet;
                        comboBox1.SelectedValue = medeniDurum;
                        comboBox3.SelectedValue = dogumYeri;
                        maskedTextBox7.Text = anneAdi;
                        maskedTextBox9.Text = babaAdi;
                        maskedTextBox10.Text = anneKizlikSoyad;
                        comboBox6.SelectedValue = egitimDurumu;
                        comboBox5.SelectedValue = sube;
                    }
                }
            }
            if (musteriVarMi)
            {
                baglanti.Open();
                SqlCommand komut0 = new SqlCommand();
                komut0 = new SqlCommand("Select musteri_no FROM musteri_bilgileri WHERE tc_no = '" + maskedTextBox15.Text + "'", baglanti);
                komut0.Connection = baglanti;
                Int64 musterino = (Int64)komut0.ExecuteScalar();
                baglanti.Close();
                Console.WriteLine(musterino.ToString());
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PPM9TPL;Initial Catalog=kullanici_proje;Integrated Security=True"))
                {
                    connection.Open();

                    string mustersorgu = "Select * FROM musteri_iletisim_bilgileri WHERE musteri_no = '" + musterino.ToString() + "'";

                    using (SqlCommand command = new SqlCommand(mustersorgu, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Int32 il = reader.GetInt32(reader.GetOrdinal("il"));
                            Int32 ilce = reader.GetInt32(reader.GetOrdinal("ilce"));
                            string koy = reader.GetString(reader.GetOrdinal("koy"));
                            string mahalle = reader.GetString(reader.GetOrdinal("mahalle"));
                            string cadde = reader.GetString(reader.GetOrdinal("cadde"));
                            string sokak = reader.GetString(reader.GetOrdinal("sokak"));
                            string binaNo = reader.GetString(reader.GetOrdinal("bina_no"));
                            string evNo = reader.GetString(reader.GetOrdinal("ev_no"));
                            string evTelelfonNo = reader.GetString(reader.GetOrdinal("ev_telefon_no"));
                            string isTelefonNo = reader.GetString(reader.GetOrdinal("is_telefon_no"));
                            string cepTelefonNo = reader.GetString(reader.GetOrdinal("cep_telefon_no"));
                            string email = reader.GetString(reader.GetOrdinal("email"));

                            comboBox7.SelectedValue = il;
                            comboBox4.SelectedValue = ilce;
                            maskedTextBox2.Text = koy;
                            maskedTextBox8.Text = mahalle;
                            maskedTextBox12.Text = cadde;
                            maskedTextBox11.Text = sokak;
                            maskedTextBox14.Text = binaNo;
                            maskedTextBox13.Text = evNo;
                            maskedTextBox19.Text = evTelelfonNo;
                            maskedTextBox18.Text = isTelefonNo;
                            maskedTextBox17.Text = cepTelefonNo;
                            maskedTextBox16.Text = email;
                        }
                    }
                }
            }
            else {
                panel1.Visible = false;
                MessageBox.Show("Girilen Tc no ile müşteri bulunamadı.");
            }
            /*baglanti.Open();
            SqlCommand komut0 = new SqlCommand();
            komut0 = new SqlCommand("Select cinsiyet FROM proje_cinsiyet WHERE id = '" + cinsiyet.ToString() + "'", baglanti);
            komut0.Connection = baglanti;
            Console.WriteLine((string)komut0.ExecuteScalar());
            //comboBox2.ValueMember = (string)komut0.ExecuteScalar();
            
            komut0 = new SqlCommand("Select medeni_durum FROM proje_medeni_durum WHERE id = '" + medeniDurum.ToString() + "'", baglanti);

            Console.WriteLine((string)komut0.ExecuteScalar());
            baglanti.Close();*/
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }
    }
}