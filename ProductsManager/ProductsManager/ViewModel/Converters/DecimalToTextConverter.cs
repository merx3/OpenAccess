using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace ProductsManager.WPF.ViewModel.Converters
{
    public class DecimalToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            decimal price = (decimal)value;
            string priceText = price.ToString ("0.00");
            return priceText;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var priceText = ((TextBox)value).Text;
            decimal price;
            bool priceIsOk = 
                decimal.TryParse(priceText, out price) 
                && price > 0
                && price.ToString("0.00") == priceText;

            object errorLbl = Window.GetWindow((TextBox)value).FindName("LblPriceError");
            if (priceIsOk)
            {
                ((Label)errorLbl).Visibility = Visibility.Hidden;
                return price;
            }
            else
            {
                ((Label)errorLbl).Visibility = Visibility.Visible;
                return 0.0M;
            }
        }
    }
}
