using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using static System.Net.WebRequestMethods;
using System.IO;

namespace WeatherMeApp
{
    public partial class mainPageForm : Form
    {
        public mainPageForm()
        {
            InitializeComponent();
            cityField.Text = "Type city name";
            cityField.ForeColor = Color.Gray;


        }


        private void cityField_Enter(object sender, EventArgs e)
        {
            if (cityField.Text == "Type city name")
            {
                cityField.Text = "";
                cityField.ForeColor = Color.Black;
            }
        }

        private void cityField_Leave(object sender, EventArgs e)
        {
            if (cityField.Text == "")
            {
                cityField.Text = "Type city name";
                cityField.ForeColor = Color.Gray;
            }
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
            return pressureHpa * 0.75006 / 100.0;
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

        // Weather info
        string APIKey = "729d020e9b0919e6290f6b8cb21dc7de";
        string APIUrl = "http://api.openweathermap.org/data/2.5/weather";

        private async void getWeatherAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string url = $"{APIUrl}?q={cityField.Text}&appid={APIKey}";

                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                weatherInfo.root Info = JsonConvert.DeserializeObject<weatherInfo.root>(json);

                string iconUrl = $"http://openweathermap.org/img/wn/{Info.weather[0].icon}@2x.png";
                byte[] imageBytes = await httpClient.GetByteArrayAsync(iconUrl);
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes))
                {
                    pictureIcon.Image = System.Drawing.Image.FromStream(ms);
                }

                temperatureInfo.Text = ConvertKelvinToCelsius(Info.main.temp).ToString("0.0") + "°";
                feelsLikeInfo.Text = ConvertKelvinToCelsius(Info.main.feels_like).ToString("0.0") + "°";
                windspeedInfo.Text = Info.wind.speed.ToString() + " m/c";
                windDirInfo.Text = GetWindDirection(Info.wind.deg);
                sunRiseInfo.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();
                sunSetInfo.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                pressureInfo.Text = ConvertPressure(Info.main.pressure).ToString("0.##" + " mmHg");
                cloudinessInfo.Text = Info.clouds.all.ToString() + "%";
                humidityInfo.Text = Info.main.humidity.ToString() + "%";
                visibilityInfo.Text = Info.visibility.ToString() + " meters";
                datetimeInfo.Text = ConvertUnixTimeToDateTime(Info.dt).ToString();
                cityInfo.Text = cityField.Text;

                var weatherForRecommendations = Info.weather[0].main.ToString();

            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            getWeatherAsync();
        }

        // Recommendations
        private string GetWeatherRecommendations(weatherInfo.root weatherData)
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

        private void buttonRecommendations_Click(object sender, EventArgs e)
        {
            try
            {
                string city = cityField.Text;
                string url = $"{APIUrl}?q={city}&appid={APIKey}";

                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = httpClient.GetAsync(url).Result;
                    response.EnsureSuccessStatusCode();

                    string json = response.Content.ReadAsStringAsync().Result;
                    weatherInfo.root weatherData = JsonConvert.DeserializeObject<weatherInfo.root>(json);

                    string recommendations = GetWeatherRecommendations(weatherData);

                    MessageBox.Show(recommendations, "Weather recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting recommendations: " + ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string city = cityField.Text;
            if (!string.IsNullOrEmpty(city) && !listViewFavorites.Items.Cast<ListViewItem>().Any(item => item.Text == city) && cityField.Text != "Type city name")
            {
                ListViewItem listItem = new ListViewItem(city);
                listViewFavorites.Items.Add(listItem);

                cityField.Text = "Type city name";
                cityField.ForeColor = Color.Gray;
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listViewFavorites.SelectedItems.Count > 0)
            {
                listViewFavorites.SelectedItems[0].Remove();
            }
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listItem in listViewFavorites.Items)
            {
                string city = listItem.Text;
                if (!string.IsNullOrEmpty(city))
                {
                    string APIUrl = "http://api.openweathermap.org/data/2.5/weather";
                    string APIKey = "729d020e9b0919e6290f6b8cb21dc7de";
                    string url = $"{APIUrl}?q={city}&appid={APIKey}";
                    using (HttpClient httpClient = new HttpClient())
                    {
                        try
                        {
                            HttpResponseMessage response = await httpClient.GetAsync(url);
                            response.EnsureSuccessStatusCode();

                            string json = await response.Content.ReadAsStringAsync();
                            weatherInfo.root weatherData = JsonConvert.DeserializeObject<weatherInfo.root>(json);
                            
                            if (listItem.SubItems.Count <= listViewFavorites.Columns.Count)
                            {
                                listItem.SubItems.Add(ConvertKelvinToCelsius(weatherData.main.temp).ToString("0.0") + "°");
                            }
                            else
                            {
                                listItem.SubItems[listViewFavorites.Columns.Count].Text = ConvertKelvinToCelsius(weatherData.main.temp).ToString("0.0") + "°";
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error updating temperature for {city}: {ex.Message}");
                        }
                    }
                }
            }
        }
    }
}
