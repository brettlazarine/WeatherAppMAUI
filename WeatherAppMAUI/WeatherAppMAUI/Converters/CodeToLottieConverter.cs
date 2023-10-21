using SkiaSharp.Extended.UI.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppMAUI.Converters
{
    public class CodeToLottieConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var code = (int)value;
            var lottieImageSource = new SKFileLottieImageSource();

            switch (code)
            {
                case 0:
                    lottieImageSource.File = "sunny.json";
                    return lottieImageSource;
                case 1:
                    lottieImageSource.File = "sunny.json";
                    return lottieImageSource;
                case 2:
                    lottieImageSource.File = "foggy.json";
                    return lottieImageSource;
                case 3:
                    lottieImageSource.File = "foggy.json";
                    return lottieImageSource;
                case 45:
                    lottieImageSource.File = "foggy.json";
                    return lottieImageSource;
                case 48:
                    lottieImageSource.File = "foggy.json";
                    return lottieImageSource;
                case 51:
                    lottieImageSource.File = "partly-shower.json";
                    return lottieImageSource;
                case 53:
                    lottieImageSource.File = "partly-shower.json";
                    return lottieImageSource;
                case 55:
                    lottieImageSource.File = "partly-shower.json";
                    return lottieImageSource;
                case 56:
                    lottieImageSource.File = "partly-shower.json";
                    return lottieImageSource;
                case 57:
                    lottieImageSource.File = "partly-shower.json";
                    return lottieImageSource;
                case 61:
                    lottieImageSource.File = "stormshowersday.json";
                    return lottieImageSource;
                case 63:
                    lottieImageSource.File = "stormshowersday.json";
                    return lottieImageSource;
                case 65:
                    lottieImageSource.File = "stormshowersday.json";
                    return lottieImageSource;
                case 66:
                    lottieImageSource.File = "snow.json";
                    return lottieImageSource;
                case 67:
                    lottieImageSource.File = "snow.json";
                    return lottieImageSource;
                case 71:
                    lottieImageSource.File = "snow.json";
                    return lottieImageSource;
                case 73:
                    lottieImageSource.File = "snow.json";
                    return lottieImageSource;
                case 75:
                    lottieImageSource.File = "snow.json";
                    return lottieImageSource;
                case 77:
                    lottieImageSource.File = "snow.json";
                    return lottieImageSource;
                case 80:
                    lottieImageSource.File = "storm.json";
                    return lottieImageSource;
                case 81:
                    lottieImageSource.File = "storm.json";
                    return lottieImageSource;
                case 82:
                    lottieImageSource.File = "storm.json";
                    return lottieImageSource;
                case 85:
                    lottieImageSource.File = "storm.json";
                    return lottieImageSource;
                case 86:
                    lottieImageSource.File = "storm.json";
                    return lottieImageSource;
                case 95:
                    lottieImageSource.File = "storm.json";
                    return lottieImageSource;

                case 96:
                case 99:
                    lottieImageSource.File = "storm.json";
                    return lottieImageSource;

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
