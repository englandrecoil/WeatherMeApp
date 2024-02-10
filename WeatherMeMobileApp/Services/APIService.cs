using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMeMobileApp.Services
{
    public class APIService
    {
        private const string APIKey = "729d020e9b0919e6290f6b8cb21dc7de";
        private const string APIUrl = "http://api.openweathermap.org/data/2.5/weather";

        public async Task<WeatherInfo.Root> GetWeatherByCity(string city)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.Timeout = TimeSpan.FromSeconds(180);
                    string url = $"{APIUrl}?q={city}&appid={APIKey}";

                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    string result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<WeatherInfo.Root>(result);

                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HttpRequestException: {ex.Message}");
                throw;
            }

        }
    }
}
