using ProductsManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace ProductsManager.WPF.ViewModel.Converters
{
    public class CategoryToTextConverter : IValueConverter
    {
        private static ProductsManagerModel context = new ProductsManagerModel();

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return ((Category)value).Name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var categoryName = ((ComboBoxItem)value).Content.ToString();
            return context.Categories.Where(x => x.Name == categoryName).FirstOrDefault();
        }
    }
}
