using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Npgsql;
using System.Data.SqlClient;

namespace zadanie2
{
    public partial class NewPassword : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=1111;Database=Documentos;");

        
        public NewPassword()
        {
            
            InitializeComponent();
        }

        private void change_password_button1_Click(object sender, EventArgs e)
        {
            Autorization autor = new Autorization();


            string symb1 = "ABCDEFGHIJKLMNOPRSTUVWXYZ"; 
            string symb2 = "123456789";
            string symb3 = "!\"#$%&'()*+,-./::<=>?@[\\]:_{|}";
            

            try
            {
                if (textBox1.Text.IndexOfAny(symb1.ToCharArray()) == -5 || textBox1.Text.IndexOfAny(symb2.ToCharArray()) == -3 || textBox1.Text.IndexOfAny(symb3.ToCharArray()) == -3 || textBox1.Text.Length < 10)
                {
                    MessageBox.Show("Пароль неверный");
                }
                else
                {
                    connection.Open();
                    var login = autor.log_autor_textBox1.Text;
                    var password = textBox1.Text;

                    var changequery = $"update users set password = '{password}' where login = '{login}'";

                    var command = new NpgsqlCommand(changequery, connection);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Вы успешно изменили пароль");
                        autor.log_autor_textBox1.Text = "";
                        textBox1.Text = "";
                        Form1 frm = new Form1();
                        this.Hide();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка");
                    }
                    connection.Close();
                    this.Close();
                }
                
            }
            catch
            {
                MessageBox.Show("Пользователь не может быть добавлен", "Ошибка");
            }

            this.Close();

            
        }

        private void NewPassword_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
