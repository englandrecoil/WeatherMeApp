using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMeMobileApp
{
    public class WeatherInfo
    {
        public class Coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class Weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
            public string fullIconUrl => string.Format("http://openweathermap.org/img/wn/{0}@2x.png", icon);
        }

        public class Main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }

        }
        public int visibility { get; set; }

        public class Wind
        {
            public double speed { get; set; }
            public int deg { get; set; }
        }

        public long dt { get; set; }

        public class Clouds
        {
            public int all { get; set; }
        }

        public class Sys
        {
            public long sunrise { get; set; }
            public long sunset { get; set; }
        }


        public class Root
        {
            public Coord coord { get; set; }
            public List<Weather> weather { get; set; }
            public Main main { get; set; }
            public int visibility { get; set; }

            public Wind wind { get; set; }
            public long dt { get; set; }
            public Clouds clouds { get; set; }
            public Sys sys { get; set; }
        }

    }
}