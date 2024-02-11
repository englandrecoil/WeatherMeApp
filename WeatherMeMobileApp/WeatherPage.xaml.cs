using System.Collections.ObjectModel;
using System.Text;
using WeatherMeMobileApp.Models;
using WeatherMeMobileApp.Services;

namespace WeatherMeMobileApp;

public partial class WeatherPage : ContentPage
{
    private ObservableCollection<FavoriteItem> favorites = new ObservableCollection<FavoriteItem>();
    public WeatherPage()
    {
        InitializeComponent();
        favoritesListView.ItemsSource = favorites;
    }

    private string GetWindDirection(double degrees)
    {
        string[] directions = { "N", "NE", "E", "SE", "S", "SW", "W", "NW" };

        while (degrees < 0)
        {
            degrees += 360;
        }
        degrees = degrees % 360;

        int index = (int)((degrees + 22.5) / 45) % 8;

        return directions[index];
    }

    private double ConvertPressure(double pressureHpa)
    {
        return Math.Round(pressureHpa * 0.75006);
    }

    DateTime convertDateTime(long seconds)
    {
        DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
        day = day.AddSeconds(seconds).ToLocalTime();
        return day;
    }

    private DateTime ConvertUnixTimeToDateTime(long unixTime)
    {
        DateTimeOffset dateTimeOffsetUtc = DateTimeOffset.FromUnixTimeSeconds((long)unixTime);
        DateTime utcDateTime = dateTimeOffsetUtc.UtcDateTime;

        DateTime localDateTime = utcDateTime.ToLocalTime();

        return localDateTime;
    }

    private double ConvertKelvinToCelsius(double kelvinTemperature)
    {
        return Math.Round(kelvinTemperature - 273.15, 1);
    }


    public async Task GetWeatherDataByCity(string city)
    {
        var apiService = new APIService();
        var result = await apiService.GetWeatherByCity(city);

        temperatureInfo.Text = ConvertKelvinToCelsius(result.main.temp).ToString("0.0") + "°";
        feelsLikeInfo.Text = ConvertKelvinToCelsius(result.main.feels_like).ToString("0.0") + "°";
        windspeedInfo.Text = result.wind.speed.ToString() + " m/c";
        windDirInfo.Text = GetWindDirection(result.wind.deg);
        sunRiseInfo.Text = convertDateTime(result.sys.sunrise).ToShortTimeString();
        sunSetInfo.Text = convertDateTime(result.sys.sunset).ToShortTimeString();
        pressureInfo.Text = ConvertPressure(result.main.pressure).ToString() + " mmHg";
        cloudinessInfo.Text = result.clouds.all.ToString() + "%";
        humidityInfo.Text = result.main.humidity.ToString() + "%";
        visibilityInfo.Text = (result.visibility / 1000).ToString() + " km";
        datetimeInfo.Text = ConvertUnixTimeToDateTime(result.dt).ToString();
        cityInfo.Text = cityField.Text;
        pictureIcon.Source = result.weather[0].fullIconUrl;


    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(cityField.Text))
        {
            return;
        }
        else await GetWeatherDataByCity(cityField.Text);

    }

    // Recommendations
    private async void ButtonRecommendations_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(cityField.Text))
        {
            return;
        }
        else
        {
            try
            {
                var apiService = new APIService();
                var result = await apiService.GetWeatherByCity(cityInfo.Text);
                string recommendations = GetWeatherRecommendations(result);

                DisplayAlert("Weather recommendations", recommendations, "OK");


            }

            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error getting recommendations: {ex.Message}");
            }
        }

    }

    private string GetWeatherRecommendations(WeatherInfo.Root weatherData)
    {
        StringBuilder recommendations = new StringBuilder();

        string weatherType = weatherData.weather[0].main;
        if (weatherType == "mist" | weatherType == "smoke" | weatherType == "haze" | weatherType == "dust"
            | weatherType == "fog" | weatherType == "sand" | weatherType == "dust" | weatherType == "ash" |
            weatherType == "squall" | weatherType == "tornado")
        {
            recommendations.AppendLine("   - Pay attention to local weather alerts and updates.\r\n   " +
                "- Dress appropriately for the specific conditions – wear protective gear if necessary.\r\n  " +
                " - Carry essentials like a flashlight, a charged phone, and a first aid kit.\r\n   " +
                "- Stay indoors if the conditions pose risks to health and safety.\r\n   " +
                "- If outside, be cautious of surroundings, especially in low visibility conditions.\r\n   " +
                "- Follow local authorities' advice and seek shelter as needed..");
        }
        else
        {
            switch (weatherType.ToLowerInvariant())
            {
                case "rain":
                    recommendations.AppendLine("   - Grab a waterproof jacket and some sturdy boots.\r\n   " +
                        "- Take an umbrella or a raincoat to stay dry.\r\n   " +
                        "- Bring a plastic bag to keep your phone and wallet safe.");
                    break;
                case "snow":
                    recommendations.AppendLine("   - Dress in layers and wear a warm coat, hat, and gloves.\r\n   " +
                        "- Don't forget waterproof boots for the snow.\r\n   - Bring sunglasses to shield your eyes from the bright snow.");
                    break;
                case "thunderstom":
                    recommendations.AppendLine("   - Wear a raincoat or a waterproof jacket.\r\n  " +
                        " - Carry an umbrella and avoid open areas.\r\n   " +
                        "- Be cautious of lightning – better to stay indoors if possible. ");
                    break;
                case "drizzle":
                    recommendations.AppendLine("   - Wear a light waterproof jacket or coat.\r\n   " +
                        "- Take a small umbrella just in case.\r\n   - Bring a plastic bag to keep your belongings dry.");
                    break;
                case "clear":
                    recommendations.AppendLine("   - Dress comfortably for the temperature.\r\n   " +
                        "- Wear sunglasses and bring sunscreen for sun protection.\r\n   - Stay hydrated, especially on hot days.");
                    break;
                case "clouds":
                    recommendations.AppendLine("   - Dress in layers for potential temperature changes.\r\n   " +
                        "- Bring a light jacket or sweater.\r\n   - Don't forget your sunglasses " +
                        "– even if it's cloudy, UV rays can still be strong.");
                    break;
            }
        }
        return recommendations.ToString();
    }

    // Favorites

    private void AddFavorite(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(cityField.Text))
        {
            return;
        }

        if (favorites.Any(favorite => favorite.City == cityField.Text))
        {
            return;
        }
        var newFavorite = new FavoriteItem { City = cityField.Text, Temperature= double.NaN };
        favorites.Add(newFavorite);

    }

    private async void FavoriteItem_Tapped(object sender, EventArgs e)
    {
        var tappedItem = (sender as Grid)?.BindingContext as FavoriteItem;
        if (tappedItem != null)
        {
            bool answer = await DisplayAlert("Confirmation", $"Do you want to remove {tappedItem.City}?", "Yes", "No");

            if (answer)
            {
                favorites.Remove(tappedItem);
            }
        }
    }

    private async void ButtonRefresh(object sender, EventArgs e)
    {   
        var apiService = new APIService();


        foreach (var favorite in favorites)
        {
            var result = await apiService.GetWeatherByCity(favorite.City);

            favorite.Temperature = ConvertKelvinToCelsius(result.main.temp);

        }

    }



}
