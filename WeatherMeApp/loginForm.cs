using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMeApp
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            this.FormClosing += loginForm_FormClosing;
        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private static bool isValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        private static bool isValidPassword(string password)
        {
            return password.Length >= 8;
        }

        // Проверки корректности данных
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if ((emailFieldLogin.Text == "") | (passwordFieldLogin.Text == ""))
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!isValidEmail(emailFieldLogin.Text))
            {
                MessageBox.Show("Введите корректный адрес электронной почты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!isValidPassword(passwordFieldLogin.Text))
            {
                MessageBox.Show("Пароль должен содержать минимум 8 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            mainPageForm mainPageFormLink = new mainPageForm();
            mainPageFormLink.Show();

        }

        private void linkToReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm registerFormLink = new registerForm();
            registerFormLink.Show();
        }

    }
}
