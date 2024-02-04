﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMeApp
{
    internal class weatherInfo
    {
        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }

        }
        public int visibility { get; set; }

        public class wind
        {
            public double speed { get; set; }
            public int deg { get; set; }
        }

        public long dt { get; set; }

        public class clouds
        {
            public int all { get; set; }
        }

        public class sys
         {
            public long sunrise { get; set; }
            public long sunset { get; set; }
        }


            public class root
            {
                public coord coord { get; set; }
                public List<weather> weather { get; set; }
                public main main { get; set; }
                public int visibility { get; set; }

                public wind wind { get; set; }
                public long dt { get; set; }
                public clouds clouds { get; set; }
                public sys sys { get; set; }
            }

        }
}