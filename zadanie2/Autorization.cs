using Npgsql;
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

namespace zadanie2
{
    public partial class Autorization : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=1111;Database=Documentos;");
        int counter = 3;

        public Autorization()
        {
            InitializeComponent();
            
        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            
        }

        private void enter_button1_Click(object sender, EventArgs e)
        {
            counter--;


            try
            {
                string login = "qqqqqq#%@@##@&@&&@&@qqqqqqqqq";
                string password = "@#^@#*^@U^(@(^*@#^*&@#^";
                connection.Open();
                NpgsqlCommand command1 = new NpgsqlCommand($"SELECT login FROM users WHERE login = '{log_autor_textBox1.Text}'", connection);
                NpgsqlCommand command2 = new NpgsqlCommand($"SELECT password FROM users WHERE password = '{pass_autor_textBox2.Text}'", connection);
                
                    using (var reader = command1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            login = reader["login"].ToString();
                        }
                    }
                    using (var reader = command2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            password = reader["password"].ToString();
                        }
                    }

                    if (login == log_autor_textBox1.Text)
                    {
                        if (password == pass_autor_textBox2.Text)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователя не существует", "Ошибка");
                    }
                    connection.Close();
                
                    if (login == log_autor_textBox1.Text)
                    {
                        if (password == pass_autor_textBox2.Text)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователя не существует", "Ошибка");
                    }
                    connection.Close();


            }
            catch
            {
                MessageBox.Show("Не удалось пройти авторизацию", "Ошибка");
            }




            if (counter == 0)
            {
                MessageBox.Show("Изменить пароль", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewPassword newpas = new NewPassword();
                newpas.ShowDialog();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void log_autor_textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
