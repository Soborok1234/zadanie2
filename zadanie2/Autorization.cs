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
    public partial class Autorization : Form
    {
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


            if (counter == 0)
            {
                MessageBox.Show("Изменить пароль", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewPassword newpas = new NewPassword();
                newpas.ShowDialog();
                
                //further instructions
            }
        }
    }
}
