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



        string APIKey = "729d020e9b0919e6290f6b8cb21dc7de";
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", cityField.Text, APIKey);
                var json = web.DownloadString(url);
                weatherInfo.root Info = JsonConvert.DeserializeObject<weatherInfo.root>(json);

                double kelvinTemp = Info.main.temp;
                double celsTemp = Math.Round(kelvinTemp - 273.15, 1);
                double kelvinFeelsLike = Info.main.feels_like;
                double celsFeelsLike = Math.Round(kelvinFeelsLike - 273.15, 1);

                pictureIcon.ImageLocation = "https://openweathermap.org/img/wn/" + Info.weather[0].icon.ToString() + "@2x.png";
                temperatureInfo.Text = celsTemp.ToString("0.0") + "°";
                feelsLikeInfo.Text = celsFeelsLike.ToString("0.0") + "°";
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
            getWeather();
        }
    }
}
