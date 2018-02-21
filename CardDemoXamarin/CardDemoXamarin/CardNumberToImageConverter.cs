using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace CardDemoXamarin
{
    public class CardNumberToImageConverter: IValueConverter
    {
        public ImageSource Visa { get; set; }
        public ImageSource Amex { get; set; }
        public ImageSource MasterCard { get; set; }
        public ImageSource Dinners { get; set; }
        public ImageSource Discover { get; set; }
        public ImageSource JCB { get; set; }
        public ImageSource NotRecognized { get; set; }

        private static Regex visaRegex = new Regex(@"^4[0-9]{6,}$");
        private static Regex masterRegex = new Regex(@"^5[1-5][0-9]{5,}|222[1-9][0-9]{3,}|22[3-9][0-9]{4,}|2[3-6][0-9]{5,}|27[01][0-9]{4,}|2720[0-9]{3,}$");
        private static Regex dinnersRegex = new Regex(@"^3(?:0[0-5]|[68][0-9])[0-9]{4,}$");
        private static Regex discoverRegex = new Regex(@"^6(?:011|5[0-9]{2})[0-9]{3,}$");
        private static Regex jcbRegex = new Regex(@"^(?:2131|1800|35[0-9]{3})[0-9]{3,}$");
        private static Regex amexRegex = new Regex(@"^3[47][0-9]{5,}$");

         public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return NotRecognized;

            var number = value.ToString();
            var numberNormalized = number.Replace(" ",string.Empty);

            if (visaRegex.IsMatch(numberNormalized)) return Visa;

            if (amexRegex.IsMatch(numberNormalized)) return Amex;

            if (masterRegex.IsMatch(numberNormalized)) return MasterCard;

            if (dinnersRegex.IsMatch(numberNormalized)) return Dinners;

            if (discoverRegex.IsMatch(numberNormalized)) return Discover;

            if (jcbRegex.IsMatch(numberNormalized)) return JCB;

            return NotRecognized;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
