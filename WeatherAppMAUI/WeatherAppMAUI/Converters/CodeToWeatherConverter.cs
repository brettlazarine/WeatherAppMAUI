using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppMAUI.Converters
{
    public class CodeToWeatherConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var code = (int)value;

            switch (code)
            {
                case 0:
                    return "Clear Sky";
                case 1:
                    return "Mainly Clear";
                case 2:
                    return "Partly Cloudy";
                case 3:
                    return "Overcast";
                case 45:
                    return "Fog";
                case 48:
                    return "Depositing Rime Fog";
                case 51:
                    return "Drizzle: Light Intensity";
                case 53:
                    return "Drizzle: Moderate Intensity";
                case 55:
                    return "Drizzle: Dense Intensity";
                case 56:
                    return "Freezing Drizzle: Light Intensity";
                case 57:
                    return "Freezing Drizzle: Dense Intensity";
                case 61:
                    return "Rain: Slight Intensity";
                case 63:
                    return "Rain: Moderate Intensity";
                case 65:
                    return "Rain: Heavy Intensity";
                case 66:
                    return "Freezing Rain: Light Intensity";
                case 67:
                    return "Freezing Rain: Heavy Intensity";
                case 71:
                    return "Snow fall: Slight Intensity";
                case 73:
                    return "Snow fall: Moderate Intensity";
                case 75:
                    return "Snow fall: Heavy Intensity";
                case 77:
                    return "Snow Grains";
                case 80:
                    return "Rain showers: Slight";
                case 81:
                    return "Rain showers: Moderate";
                case 82:
                    return "Rain showers: Violent";
                case 85:
                    return "Snow Showers Slight";
                case 86:
                    return "Snow Showers Heavy";
                case 95:
                    return "Thunderstorm: Slight or Moderate";

                case 96:
                case 99:
                    return "Thunderstorm with Slight and Heavy Hail";

                default:
                    return "Unkown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
