using System.ComponentModel;
using System.Data.SQLite;

namespace Cinematik
{
    public partial class GirisEkrani : Form
    {
        private SQLiteConnection connection;
        private string connectionString = "Data Source=deneme.db;Version=3;";

        

        private void InitializeDatabase()
        {
            // Veritabanı bağlantısını başlat
            connection = new SQLiteConnection(connectionString);
            connection.Open();

            // Tablo oluşturma işlemini burada gerçekleştirin
            string createFilmTableQuery = "CREATE TABLE IF NOT EXISTS Film (Id INTEGER PRIMARY KEY, Ad TEXT, SeansSaatleri TEXT)";
            using (SQLiteCommand command = new SQLiteCommand(createFilmTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            string createSalonTableQuery = "CREATE TABLE IF NOT EXISTS Salon (Id INTEGER PRIMARY KEY, Ad TEXT, KoltukKapasitesi INTEGER)";
            using (SQLiteCommand command = new SQLiteCommand(createSalonTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            // Diğer tabloları oluşturmak için benzer şekilde devam edebilirsiniz
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Form kapatıldığında veritabanı bağlantısını kapat
                if (connection != null)
                {
                    connection.Close();
                }
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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(GirisEkrani));
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            contextMenuStrip3 = new ContextMenuStrip(components);
            notifyIcon1 = new NotifyIcon(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label21 = new Label();
            label23 = new Label();
            pictureBox13 = new PictureBox();
            textBox20 = new TextBox();
            label2 = new Label();
            textBox18 = new TextBox();
            textBox19 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox4 = new ComboBox();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label16 = new Label();
            tabPage2 = new TabPage();
            comboBox5 = new ComboBox();
            label12 = new Label();
            label5 = new Label();
            label4 = new Label();
            label18 = new Label();
            numericUpDown1 = new NumericUpDown();
            pictureBox2 = new PictureBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            comboBox3 = new ComboBox();
            comboBox7 = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            button4 = new Button();
            label14 = new Label();
            label15 = new Label();
            tabPage3 = new TabPage();
            pictureBox3 = new PictureBox();
            AfisEkleButon = new Button();
            ımageList3 = new ImageList(components);
            label19 = new Label();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            dateTimePicker3 = new DateTimePicker();
            comboBox9 = new ComboBox();
            comboBox11 = new ComboBox();
            label20 = new Label();
            label22 = new Label();
            label24 = new Label();
            film_adi = new ComboBox();
            button2 = new Button();
            label25 = new Label();
            label26 = new Label();
            tabPage4 = new TabPage();
            textBox2 = new TextBox();
            numericUpDown2 = new NumericUpDown();
            textBox13 = new TextBox();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            pictureBox12 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox10 = new PictureBox();
            comboBox1 = new ComboBox();
            tabPage5 = new TabPage();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            textBox17 = new TextBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            process1 = new System.Diagnostics.Process();
            toolTip2 = new ToolTip(components);
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((ISupportInitialize)pictureBox13).BeginInit();
            tabPage2.SuspendLayout();
            ((ISupportInitialize)numericUpDown1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            tabPage3.SuspendLayout();
            ((ISupportInitialize)pictureBox3).BeginInit();
            tabPage4.SuspendLayout();
            ((ISupportInitialize)numericUpDown2).BeginInit();
            ((ISupportInitialize)pictureBox12).BeginInit();
            ((ISupportInitialize)pictureBox11).BeginInit();
            ((ISupportInitialize)pictureBox10).BeginInit();
            tabPage5.SuspendLayout();
            ((ISupportInitialize)pictureBox7).BeginInit();
            ((ISupportInitialize)pictureBox8).BeginInit();
            ((ISupportInitialize)pictureBox9).BeginInit();
            ((ISupportInitialize)pictureBox6).BeginInit();
            ((ISupportInitialize)pictureBox5).BeginInit();
            ((ISupportInitialize)pictureBox4).BeginInit();
            ((ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(32, 32);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 110, 122);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 67);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(993, 0);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(62, 67);
            button1.TabIndex = 4;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 36);
            label1.TabIndex = 0;
            label1.Text = "Ticket For You";
            label1.Click += label1_Click;
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.ImageScalingSize = new Size(24, 24);
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(61, 4);
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(43, 95);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(981, 699);
            tabControl1.TabIndex = 8;
            tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(label23);
            tabPage1.Controls.Add(pictureBox13);
            tabPage1.Controls.Add(textBox20);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox18);
            tabPage1.Controls.Add(textBox19);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(comboBox4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label16);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(973, 661);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Vizyonda";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(692, 307);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(137, 30);
            label21.TabIndex = 72;
            label21.Text = "CHAPTER 4";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(692, 59);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(143, 30);
            label23.TabIndex = 71;
            label23.Text = "JOHN WICK";
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImage = (Image)resources.GetObject("pictureBox13.BackgroundImage");
            pictureBox13.ErrorImage = (Image)resources.GetObject("pictureBox13.ErrorImage");
            pictureBox13.InitialImage = (Image)resources.GetObject("pictureBox13.InitialImage");
            pictureBox13.Location = new Point(692, 94);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(138, 210);
            pictureBox13.TabIndex = 70;
            pictureBox13.TabStop = false;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(294, 201);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(305, 31);
            textBox20.TabIndex = 69;
            textBox20.Text = "CHAD STAHELSKI";
            textBox20.TextChanged += textBox20_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(84, 110, 122);
            label2.Location = new Point(178, 200);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 68;
            label2.Text = "Yönetmen";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(294, 111);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(305, 31);
            textBox18.TabIndex = 67;
            textBox18.Text = "JOHN WICK - CHAPTER 4";
            // 
            // textBox19
            // 
            textBox19.Location = new Point(294, 287);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(305, 31);
            textBox19.TabIndex = 64;
            textBox19.Text = "170 DAKİKA";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(294, 244);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(305, 31);
            dateTimePicker1.TabIndex = 62;
            dateTimePicker1.Value = new DateTime(2023, 3, 22, 0, 0, 0, 0);
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(294, 152);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(305, 33);
            comboBox4.TabIndex = 60;
            comboBox4.Text = "AKSİYON";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bell MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(84, 110, 122);
            label3.Location = new Point(232, 285);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 59;
            label3.Text = "Süre\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bell MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(84, 110, 122);
            label6.Location = new Point(178, 244);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 56;
            label6.Text = "Film Tarihi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bell MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(84, 110, 122);
            label7.Location = new Point(185, 155);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(108, 25);
            label7.TabIndex = 54;
            label7.Text = "Film Türü";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bell MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(84, 110, 122);
            label8.Location = new Point(198, 110);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(93, 25);
            label8.TabIndex = 53;
            label8.Text = "Film Adı";
            // 
            // label16
            // 
            label16.Font = new Font("Bell MT", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(294, 57);
            label16.Name = "label16";
            label16.Size = new Size(202, 49);
            label16.TabIndex = 33;
            label16.Text = "Günün Filmi";
            label16.Click += label16_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(comboBox5);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(numericUpDown1);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(dateTimePicker2);
            tabPage2.Controls.Add(comboBox3);
            tabPage2.Controls.Add(comboBox7);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label15);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.RightToLeft = RightToLeft.No;
            tabPage2.Size = new Size(973, 661);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Satış Sayfası";
            tabPage2.Click += tabPage2_Click;
            // 
            // comboBox5
            // 
            comboBox5.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "AKSİYON", "KOMEDİ", "DRAM", "KORKU", "ROMANTİK", "BİLİMKURGU" });
            comboBox5.Location = new Point(237, 124);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(305, 33);
            comboBox5.TabIndex = 56;
            comboBox5.Text = "Seçiniz :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bell MT", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(432, 41);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(244, 26);
            label12.TabIndex = 55;
            label12.Text = "SATIN ALMA EKRANI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(706, 400);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(137, 30);
            label5.TabIndex = 54;
            label5.Text = "CHAPTER 4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(699, 152);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 30);
            label4.TabIndex = 53;
            label4.Text = "JOHN WICK";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Bell MT", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(84, 110, 122);
            label18.Location = new Point(167, 425);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(58, 26);
            label18.TabIndex = 51;
            label18.Text = "Adet";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(237, 427);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(305, 31);
            numericUpDown1.TabIndex = 50;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(699, 187);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(146, 210);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(237, 374);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(305, 31);
            textBox5.TabIndex = 47;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(237, 328);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(305, 31);
            textBox6.TabIndex = 46;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(237, 232);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(305, 31);
            dateTimePicker2.TabIndex = 45;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "-------PERDE-------", "A - 1 2 3 4 5 6 7 8 9 ", "B - 1 2 3 4 5 6 7 8 9 ", "C - 1 2 3 4 5 6 7 8 9 ", "D - 1 2 3 4 5 6 7 8 9 ", "E - 1 2 3 4 5 6 7 8 9  ", "F - 1 2 3 4 5 6 7 8 9" });
            comboBox3.Location = new Point(237, 281);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(305, 33);
            comboBox3.TabIndex = 44;
            // 
            // comboBox7
            // 
            comboBox7.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "AKSİYON", "KOMEDİ", "DRAM", "KORKU", "ROMANTİK", "BİLİMKURGU" });
            comboBox7.Location = new Point(237, 177);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(305, 33);
            comboBox7.TabIndex = 42;
            comboBox7.Text = "Seçiniz :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bell MT", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(84, 110, 122);
            label9.Location = new Point(167, 373);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(67, 26);
            label9.TabIndex = 41;
            label9.Text = "Ücret";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bell MT", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(84, 110, 122);
            label10.Location = new Point(52, 279);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(178, 26);
            label10.TabIndex = 40;
            label10.Text = "Koltuk Numarası";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bell MT", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(84, 110, 122);
            label11.Location = new Point(126, 327);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(103, 26);
            label11.TabIndex = 39;
            label11.Text = "Ad Soyad";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bell MT", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(84, 110, 122);
            label13.Location = new Point(105, 232);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(126, 26);
            label13.TabIndex = 37;
            label13.Text = "Film Seansı";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(84, 110, 122);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.White;
            button4.Location = new Point(237, 474);
            button4.Name = "button4";
            button4.Size = new Size(305, 48);
            button4.TabIndex = 35;
            button4.Text = "Satın Al";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bell MT", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(84, 110, 122);
            label14.Location = new Point(129, 180);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(114, 26);
            label14.TabIndex = 34;
            label14.Text = "Film Türü";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bell MT", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(84, 110, 122);
            label15.Location = new Point(141, 124);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(98, 26);
            label15.TabIndex = 33;
            label15.Text = "Film Adı";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(pictureBox3);
            tabPage3.Controls.Add(AfisEkleButon);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(textBox8);
            tabPage3.Controls.Add(textBox9);
            tabPage3.Controls.Add(dateTimePicker3);
            tabPage3.Controls.Add(comboBox9);
            tabPage3.Controls.Add(comboBox11);
            tabPage3.Controls.Add(label20);
            tabPage3.Controls.Add(label22);
            tabPage3.Controls.Add(label24);
            tabPage3.Controls.Add(film_adi);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(label25);
            tabPage3.Controls.Add(label26);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(973, 661);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Film Ekle";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(623, 101);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(256, 275);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 71;
            pictureBox3.TabStop = false;
            // 
            // AfisEkleButon
            // 
            AfisEkleButon.BackColor = Color.FromArgb(84, 110, 122);
            AfisEkleButon.Cursor = Cursors.Hand;
            AfisEkleButon.ForeColor = Color.White;
            errorProvider1.SetIconAlignment(AfisEkleButon, ErrorIconAlignment.MiddleLeft);
            AfisEkleButon.ImageList = ımageList3;
            AfisEkleButon.Location = new Point(623, 402);
            AfisEkleButon.Name = "AfisEkleButon";
            AfisEkleButon.Size = new Size(256, 68);
            AfisEkleButon.TabIndex = 70;
            AfisEkleButon.Text = "Afiş Ekle";
            AfisEkleButon.UseVisualStyleBackColor = false;
            AfisEkleButon.Click += button5_Click;
            // 
            // ımageList3
            // 
            ımageList3.ColorDepth = ColorDepth.Depth32Bit;
            ımageList3.ImageStream = (ImageListStreamer)resources.GetObject("ımageList3.ImageStream");
            ımageList3.TransparentColor = Color.Transparent;
            ımageList3.Images.SetKeyName(0, "4211763.png");
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Bell MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.FromArgb(84, 110, 122);
            label19.Location = new Point(179, 305);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(52, 25);
            label19.TabIndex = 69;
            label19.Text = "Süre";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(237, 302);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(305, 31);
            textBox8.TabIndex = 66;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(237, 256);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(305, 31);
            textBox9.TabIndex = 65;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(237, 208);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(305, 31);
            dateTimePicker3.TabIndex = 64;
            // 
            // comboBox9
            // 
            comboBox9.FormattingEnabled = true;
            comboBox9.Location = new Point(237, 343);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(305, 33);
            comboBox9.TabIndex = 63;
            comboBox9.SelectedIndexChanged += comboBox9_SelectedIndexChanged;
            // 
            // comboBox11
            // 
            comboBox11.FormattingEnabled = true;
            comboBox11.Location = new Point(237, 153);
            comboBox11.Name = "comboBox11";
            comboBox11.Size = new Size(305, 33);
            comboBox11.TabIndex = 61;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Bell MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(84, 110, 122);
            label20.Location = new Point(168, 348);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(64, 25);
            label20.TabIndex = 60;
            label20.Text = "Ücret";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Bell MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.FromArgb(84, 110, 122);
            label22.Location = new Point(126, 256);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(106, 25);
            label22.TabIndex = 58;
            label22.Text = "Yönetmen";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Bell MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.FromArgb(84, 110, 122);
            label24.Location = new Point(112, 208);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(120, 25);
            label24.TabIndex = 56;
            label24.Text = "Film Tarihi";
            // 
            // film_adi
            // 
            film_adi.FormattingEnabled = true;
            film_adi.Location = new Point(237, 101);
            film_adi.Name = "film_adi";
            film_adi.Size = new Size(305, 33);
            film_adi.TabIndex = 55;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(84, 110, 122);
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = Color.White;
            button2.Location = new Point(237, 402);
            button2.Name = "button2";
            button2.Size = new Size(305, 68);
            button2.TabIndex = 54;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Bell MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.FromArgb(84, 110, 122);
            label25.Location = new Point(123, 153);
            label25.Margin = new Padding(2, 0, 2, 0);
            label25.Name = "label25";
            label25.Size = new Size(108, 25);
            label25.TabIndex = 53;
            label25.Text = "Film Türü";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Bell MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.FromArgb(84, 110, 122);
            label26.Location = new Point(138, 101);
            label26.Margin = new Padding(2, 0, 2, 0);
            label26.Name = "label26";
            label26.Size = new Size(93, 25);
            label26.TabIndex = 52;
            label26.Text = "Film Adı";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(textBox2);
            tabPage4.Controls.Add(numericUpDown2);
            tabPage4.Controls.Add(textBox13);
            tabPage4.Controls.Add(textBox12);
            tabPage4.Controls.Add(textBox11);
            tabPage4.Controls.Add(textBox4);
            tabPage4.Controls.Add(textBox1);
            tabPage4.Controls.Add(pictureBox12);
            tabPage4.Controls.Add(pictureBox11);
            tabPage4.Controls.Add(pictureBox10);
            tabPage4.Controls.Add(comboBox1);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(973, 661);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Salon";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Bell MT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(165, 54);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 52);
            textBox2.TabIndex = 52;
            textBox2.Text = "Sinema Salonları";
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(238, 208);
            numericUpDown2.Margin = new Padding(2);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(240, 31);
            numericUpDown2.TabIndex = 51;
            numericUpDown2.Value = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // textBox13
            // 
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Bell MT", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox13.Location = new Point(165, 276);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(67, 34);
            textBox13.TabIndex = 49;
            textBox13.Text = "Salon";
            // 
            // textBox12
            // 
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Font = new Font("Bell MT", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox12.Location = new Point(51, 212);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(182, 34);
            textBox12.TabIndex = 48;
            textBox12.Text = "Koltuk Kapasitesi";
            // 
            // textBox11
            // 
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Bell MT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox11.Location = new Point(763, 396);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(198, 52);
            textBox11.TabIndex = 47;
            textBox11.Text = "Prime Salon";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Bell MT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(763, 258);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 52);
            textBox4.TabIndex = 46;
            textBox4.Text = "Gold Class";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bell MT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(757, 101);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 52);
            textBox1.TabIndex = 45;
            textBox1.Text = "Casual";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(546, 208);
            pictureBox12.Margin = new Padding(2);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(205, 138);
            pictureBox12.TabIndex = 44;
            pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(546, 54);
            pictureBox11.Margin = new Padding(2);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(205, 142);
            pictureBox11.TabIndex = 43;
            pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(546, 350);
            pictureBox10.Margin = new Padding(2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(205, 131);
            pictureBox10.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox10.TabIndex = 42;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Casual 1 - Normal Koltuk", "Casual 2 - Normal Koltuk", "Casual 3 - Normal Koltuk", "Gold 1 - Yatan Koltuk ", "Gold 2 - Yatan Koltuk ", "Gold 3 - Yatan Koltuk", "Prime 1 - Sınırsız Özel Servis - Yatan Koltuk", "Prime 1 - Sınırsız Özel Servis - Yatan Koltuk" });
            comboBox1.Location = new Point(238, 277);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 33);
            comboBox1.TabIndex = 39;
            comboBox1.Text = "Seçiniz :";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.White;
            tabPage5.Controls.Add(button9);
            tabPage5.Controls.Add(button8);
            tabPage5.Controls.Add(button7);
            tabPage5.Controls.Add(button6);
            tabPage5.Controls.Add(button5);
            tabPage5.Controls.Add(button3);
            tabPage5.Controls.Add(textBox17);
            tabPage5.Controls.Add(pictureBox7);
            tabPage5.Controls.Add(pictureBox8);
            tabPage5.Controls.Add(pictureBox9);
            tabPage5.Controls.Add(pictureBox6);
            tabPage5.Controls.Add(pictureBox5);
            tabPage5.Controls.Add(pictureBox4);
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(973, 661);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Film Liste";
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(84, 110, 122);
            button9.Cursor = Cursors.Hand;
            button9.ForeColor = Color.White;
            errorProvider1.SetIconAlignment(button9, ErrorIconAlignment.MiddleLeft);
            button9.ImageList = ımageList3;
            button9.Location = new Point(685, 567);
            button9.Name = "button9";
            button9.Size = new Size(142, 39);
            button9.TabIndex = 76;
            button9.Text = "Afiş Ekle";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(84, 110, 122);
            button8.Cursor = Cursors.Hand;
            button8.ForeColor = Color.White;
            errorProvider1.SetIconAlignment(button8, ErrorIconAlignment.MiddleLeft);
            button8.ImageList = ımageList3;
            button8.Location = new Point(448, 567);
            button8.Name = "button8";
            button8.Size = new Size(142, 39);
            button8.TabIndex = 75;
            button8.Text = "Afiş Ekle";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(84, 110, 122);
            button7.Cursor = Cursors.Hand;
            button7.ForeColor = Color.White;
            errorProvider1.SetIconAlignment(button7, ErrorIconAlignment.MiddleLeft);
            button7.ImageList = ımageList3;
            button7.Location = new Point(207, 567);
            button7.Name = "button7";
            button7.Size = new Size(142, 39);
            button7.TabIndex = 74;
            button7.Text = "Afiş Ekle";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(84, 110, 122);
            button6.Cursor = Cursors.Hand;
            button6.ForeColor = Color.White;
            errorProvider1.SetIconAlignment(button6, ErrorIconAlignment.MiddleLeft);
            button6.ImageList = ımageList3;
            button6.Location = new Point(685, 287);
            button6.Name = "button6";
            button6.Size = new Size(142, 39);
            button6.TabIndex = 73;
            button6.Text = "Afiş Ekle";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(84, 110, 122);
            button5.Cursor = Cursors.Hand;
            button5.ForeColor = Color.White;
            errorProvider1.SetIconAlignment(button5, ErrorIconAlignment.MiddleLeft);
            button5.ImageList = ımageList3;
            button5.Location = new Point(448, 287);
            button5.Name = "button5";
            button5.Size = new Size(142, 39);
            button5.TabIndex = 72;
            button5.Text = "Afiş Ekle";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(84, 110, 122);
            button3.Cursor = Cursors.Hand;
            button3.ForeColor = Color.White;
            errorProvider1.SetIconAlignment(button3, ErrorIconAlignment.MiddleLeft);
            button3.ImageList = ımageList3;
            button3.Location = new Point(207, 287);
            button3.Name = "button3";
            button3.Size = new Size(142, 39);
            button3.TabIndex = 71;
            button3.Text = "Afiş Ekle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // textBox17
            // 
            textBox17.BorderStyle = BorderStyle.None;
            textBox17.Font = new Font("Bell MT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox17.Location = new Point(350, 23);
            textBox17.Multiline = true;
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(356, 52);
            textBox17.TabIndex = 43;
            textBox17.Text = "Vizyondaki  En İyi 6 Film";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(685, 370);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(142, 191);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 5;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(448, 370);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(142, 191);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 4;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(207, 370);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(142, 191);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 3;
            pictureBox9.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(685, 90);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(142, 191);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(448, 90);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(142, 191);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(207, 90);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(142, 191);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // GirisEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(1055, 822);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "GirisEkrani";
            Text = "GirisEkrani";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((ISupportInitialize)pictureBox13).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((ISupportInitialize)numericUpDown1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((ISupportInitialize)pictureBox3).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((ISupportInitialize)numericUpDown2).EndInit();
            ((ISupportInitialize)pictureBox12).EndInit();
            ((ISupportInitialize)pictureBox11).EndInit();
            ((ISupportInitialize)pictureBox10).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((ISupportInitialize)pictureBox7).EndInit();
            ((ISupportInitialize)pictureBox8).EndInit();
            ((ISupportInitialize)pictureBox9).EndInit();
            ((ISupportInitialize)pictureBox6).EndInit();
            ((ISupportInitialize)pictureBox5).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            ((ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All Files | *";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlemini bu alanda ya da bu kısımda gerçekleştrieceğizz.
                pictureBox3.Image = new Bitmap(ofd.FileName);
                MessageBox.Show(ofd.FileName.ToString());
            }

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private Panel panel1;
        private Label label1;
        private ToolTip toolTip1;
        private Button button1;
        private ContextMenuStrip contextMenuStrip3;
        private NotifyIcon notifyIcon1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ErrorProvider errorProvider1;
        private PictureBox pictureBox2;
        private TextBox textBox5;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox3;
        private ComboBox comboBox7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private Button button4;
        private Label label14;
        private Label label15;
        private Label label18;
        private NumericUpDown numericUpDown1;
        private TabPage tabPage4;
        private Label label19;
        private TextBox textBox8;
        private TextBox textBox9;
        private DateTimePicker dateTimePicker3;
        private ComboBox comboBox9;
        private ComboBox comboBox11;
        private Label label20;
        private Label label22;
        private Label label24;
        private ComboBox film_adi;
        private Button button2;
        private Label label25;
        private Label label26;
        private System.Diagnostics.Process process1;
        private ImageList ımageList3;
        private Button AfisEkleButon;
        private Label label16;
        private PictureBox pictureBox3;
        private IContainer components;
        private ToolTip toolTip2;
        private ComboBox comboBox1;
        private TabPage tabPage5;
        private PictureBox pictureBox4;
        private TextBox textBox17;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private TextBox textBox18;
        private TextBox textBox19;
        private ComboBox comboBox4;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox20;
        private Label label2;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button3;
        private Label label4;
        private Label label5;
        private Label label12;
        private ComboBox comboBox5;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private TextBox textBox11;
        private TextBox textBox4;
        private TextBox textBox1;
        private TextBox textBox13;
        private TextBox textBox12;
        private TextBox textBox2;
        private NumericUpDown numericUpDown2;
        private Label label21;
        private Label label23;
        private PictureBox pictureBox13;
    }
}
