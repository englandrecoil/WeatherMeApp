using System.Text.RegularExpressions;

namespace WeatherMeMobileApp;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void ButtonLogin(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(emailFieldLogin.Text)
            | string.IsNullOrWhiteSpace(passwordFieldLogin.Text))
        {
            DisplayAlert("Error", "All fields must be filled in", "OK");
            return;
        }
        if (!IsValidEmail(emailFieldLogin.Text))
        {
            DisplayAlert("Error", "Enter a valid e-mail address", "OK");
            return;
        }
        if (!IsValidPassword(passwordFieldLogin.Text))
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
    private void LinkToRegisterTapped(object sender, EventArgs e)
    {
        MainPage mainPage = new MainPage();
        Navigation.PushAsync(mainPage);
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