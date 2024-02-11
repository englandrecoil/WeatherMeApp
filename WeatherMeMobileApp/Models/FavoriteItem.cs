using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMeMobileApp.Models
{
    class FavoriteItem : BindableObject
    {
        public static readonly BindableProperty TemperatureProperty = BindableProperty.Create(
                nameof(Temperature), typeof(double), typeof(FavoriteItem), default(double));

        public string City { get; set; }

        public double Temperature
        {
            get => (double)GetValue(TemperatureProperty);
            set => SetValue(TemperatureProperty, value);
        }
    }
}
