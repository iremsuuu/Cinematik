using System;
using System.Windows.Forms;
using SQLitePCL;
using System.Data.SQLite;
using System.Data;

namespace Cinematik
{
    public partial class GirisEkrani : Form
    {
        private SQLiteConnection baglanti;

        public GirisEkrani()
        {
            InitializeComponent();
            baglanti = new SQLiteConnection("Data Source=deneme.db;Version=3;");
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void B(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESÝM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All Files | *";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma iþlemini bu alanda ya da bu kýsýmda gerçekleþtrieceðizz.
                pictureBox4.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESÝM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All Files | *";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma iþlemini bu alanda ya da bu kýsýmda gerçekleþtrieceðizz.
                pictureBox5.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESÝM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All Files | *";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma iþlemini bu alanda ya da bu kýsýmda gerçekleþtrieceðizz.
                pictureBox6.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }

        }

        private void textBox14_TextChanged_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESÝM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All Files | *";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma iþlemini bu alanda ya da bu kýsýmda gerçekleþtrieceðizz.
                pictureBox9.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESÝM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All Files | *";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma iþlemini bu alanda ya da bu kýsýmda gerçekleþtrieceðizz.
                pictureBox8.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESÝM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All Files | *";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma iþlemini bu alanda ya da bu kýsýmda gerçekleþtrieceðizz.
                pictureBox7.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESÝM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All Files | *";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma iþlemini bu alanda ya da bu kýsýmda gerçekleþtrieceðizz.
                pictureBox5.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESÝM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All Files | *";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma iþlemini bu alanda ya da bu kýsýmda gerçekleþtrieceðizz.
                pictureBox6.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESÝM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All Files | *";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma iþlemini bu alanda ya da bu kýsýmda gerçekleþtrieceðizz.
                pictureBox9.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESÝM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All Files | *";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma iþlemini bu alanda ya da bu kýsýmda gerçekleþtrieceðizz.
                pictureBox8.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESÝM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All Files | *";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma iþlemini bu alanda ya da bu kýsýmda gerçekleþtrieceðizz.
                pictureBox7.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESÝM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All Files | *";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma iþlemini bu alanda ya da bu kýsýmda gerçekleþtrieceðizz.
                pictureBox4.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Baðlantýyý aç
                baglanti.Open();

                // Veri ekleme sorgusu
                string sorgu = "INSERT INTO film_ekle (film_adi, film_turu, film_tarihi, yonetmen, sure, ucret) VALUES (@film_adi, @film_turu, @film_tarihi, @yonetmen, @sure, @ucret)";

                // SQLiteCommand nesnesi oluþtur
                SQLiteCommand kayit = new SQLiteCommand(sorgu, baglanti);

                // Parametreleri ekle
                kayit.Parameters.AddWithValue("@film_adi", "Örnek Film Adý");
                kayit.Parameters.AddWithValue("@film_turu", "Örnek Tür");
                kayit.Parameters.AddWithValue("@film_tarihi", DateTime.Now); // Þu anki tarih
                kayit.Parameters.AddWithValue("@yonetmen", "Örnek Yönetmen");
                kayit.Parameters.AddWithValue("@sure", 120); // 120 dakika
                kayit.Parameters.AddWithValue("@ucret", 9.99); // 9.99 birim ücret

                // Sorguyu yürüt ve etkilenen satýr sayýsýný al
                int etkilenenSatirSayisi = kayit.ExecuteNonQuery();

                // Kayýt baþarýlýysa kullanýcýya mesaj göster
                if (etkilenenSatirSayisi > 0)
                {
                    MessageBox.Show("Film baþarýyla eklendi.");
                }
                else
                {
                    MessageBox.Show("Film eklenirken bir hata oluþtu.");
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanýcýya mesaj göster
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Baðlantýyý kapat
                if (baglanti != null && baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}