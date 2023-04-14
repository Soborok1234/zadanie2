using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace zadanie2
{
    public partial class Form1 : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=1111;Database=Documentos;");

        //Bitmap memoryImage;
        public Form1()
        {
            Autorization autor = new Autorization();
            autor.ShowDialog();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument1 = new PrintDocument();

            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            PrintDialog printDialog1 = new PrintDialog();

            CaptureScreen();

            printDialog1.ShowHelp = true;
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }
        Bitmap memoryImage;

       
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender,System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string qrtext = textBox1.Text;
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrcode = encoder.Encode(qrtext);
            pictureBox2.Image = qrcode as Image;
        }

        private void insert_button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM dogovor", connection);
               

                

                NpgsqlCommand command_2 = new NpgsqlCommand(string.Format(@"INSERT INTO dogovor(nomer_dog, FIO_obuch, FIO_plata, adres_plata, price) VALUES({0}, '{1}', '{2}', '{3}', {4})", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text), connection);
                command_2.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Запись не была добавлена", "Ошибка");
            }
        }

        private void select_button4_Click(object sender, EventArgs e)
        {
            select_dogovor seldog = new select_dogovor();
            seldog.Show();
        }
    }
}
