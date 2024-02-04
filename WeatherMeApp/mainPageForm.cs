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
        {   if (cityField.Text == "Type city name") {
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

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            getWeatherAsync();
        }
    }
}
