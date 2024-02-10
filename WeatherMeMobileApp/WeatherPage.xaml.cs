using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using static System.Net.WebRequestMethods;
using System.IO;
using System.Text.Json.Serialization;
using WeatherMeMobileApp.Services;

namespace WeatherMeMobileApp;

public partial class WeatherPage : ContentPage
{
    public WeatherPage()
    {
        InitializeComponent();
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


    }

    private async void Button_Clicked(object sender, EventArgs e)
    {   
        await GetWeatherDataByCity(cityField.Text);
    }


}
