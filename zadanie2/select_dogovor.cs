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

namespace zadanie2
{

    public partial class select_dogovor : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=1111;Database=Documentos;");

        public select_dogovor()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void select_dogovor_Load(object sender, EventArgs e)
        {
            connection.Open();
            dataGridView1.Columns.Clear();
            string sql = "SELECT * FROM dogovor";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
            dataGridView1.Columns.Add("S1", "Номер договора");
            dataGridView1.Columns.Add("S2", "ФИО Обучающегося");
            dataGridView1.Columns.Add("S3", "ФИО Плательщика");
            dataGridView1.Columns.Add("S4", "Адрес плательщика");
            dataGridView1.Columns.Add("S5", "Цена");

            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["nomer_dog"], reader["FIO_obuch"], reader["FIO_plata"], reader["adres_plata"], reader["price"]);
                }
            }
            connection.Close();
        }
    }
}
