using System.Globalization;

namespace OpenWeatherAPI.Converters
{
    public class LongToDateTimeConverters : IValueConverter
    {
        DateTime _time = new DateTime(1970, 1, 1, 0, 0, 0, 0);
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Defina a cultura como "en-US"
            CultureInfo enUSCulture = new CultureInfo("en-US");
            //CultureInfo ptPTCulture = new CultureInfo("pt-PT");
            //TODO:CultureInfo jpCulture = new CultureInfo("ja-JP");

            long dateTime = (long)value;
            return $"{_time.AddSeconds(dateTime).ToString(enUSCulture)} UTC";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
