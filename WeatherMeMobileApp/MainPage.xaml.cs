using System.Text.RegularExpressions;

namespace WeatherMeMobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonReg(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameFieldReg.Text) | string.IsNullOrWhiteSpace(emailFieldReg.Text) 
                | string.IsNullOrWhiteSpace(passwordFieldReg.Text))
            {
                DisplayAlert("Error", "All fields must be filled in", "OK");
                return;
            }
            if (!IsValidEmail(emailFieldReg.Text))
            {
                DisplayAlert("Error", "Enter a valid e-mail address", "OK");
                return;
            }
            if (!IsValidPassword(passwordFieldReg.Text))
            {
                DisplayAlert("Error", "Password must contain at least 8 characters", "OK");
                return;
            }
            else
            {
                WeatherPage weatherPage = new WeatherPage();
                Navigation.PushAsync(weatherPage);

            }
        }
        private void LinkToLoginTapped(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            Navigation.PushAsync(loginPage);
        }

        private bool IsValidPassword(string password)
        {
            return password.Length >= 8;
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new(pattern);
            return regex.IsMatch(email);
        }

    }

}
