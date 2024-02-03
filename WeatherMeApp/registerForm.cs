using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMeApp
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (nameFieldReg.Text == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            else if (passwordFieldReg.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            else if (emailFieldReg.Text == "")
            {
                MessageBox.Show("Введите Email");
            }

        }

        private void linkToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginFormLink = new loginForm();
            loginFormLink.Show();
        }
    }
}
