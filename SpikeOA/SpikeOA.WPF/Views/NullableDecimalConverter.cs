using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Globalization;

namespace SpikeOA.WPF.Views
{
    public class NullableDecimalConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            object result = this.NullableDecimalToZero(value);
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            object result = this.NullableDecimalToZero(value);
            return result;
        }

        private object NullableDecimalToZero(object value)
        {
            if (value == null)
            {
                return 0.0M;
            }
            else
            {
                return value;
            }
        }
    }
}
