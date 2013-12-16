using ProductsManager.Model;
using ProductsManager.WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProductsManager.WPF
{
    /// <summary>
    /// Interaction logic for ProductModify.xaml
    /// </summary>
    public partial class ProductModify : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ProductModify()
        {
            InitializeComponent();
        }

        public ProductModify(int ProductId)
        {
            InitializeComponent();
        }

        private void SaveProduct(object sender, RoutedEventArgs e)
        {
            string name = ((TextBox)FindName("TBName")).Text;
            string priceText = ((TextBox)FindName("TBName")).Text;
            decimal price;
            AvailableProduct p = ((ProductsDataHolder)this.DataContext).ProductToModify;
            
            ResetErrorMessages();
            if (!String.IsNullOrEmpty(name) && p.Price > 0.0M && p.Category != null)
            {
                Product productToAdd = new Product()
                {
                    Name = p.Name,
                    Price = p.Price,
                    CategoryId = p.Category.Id,
                    Category = p.Category,
                    IsAvailable = p.IsAvailable,
                };

                ProductsManagerModel context = ((ProductsDataHolder)this.DataContext).Context;
                {
                    context.Add(productToAdd);
                    context.SaveChanges();
                    PropertyChanged(this.Parent, new PropertyChangedEventArgs("DisplayedProducts"));
                    this.DialogResult = true;
                    this.Close();
                }
            }
            else
            {
                if (String.IsNullOrEmpty(name))
                {
                    object nameErrorLbl = this.FindName("LblNameError");
                    ((Label)nameErrorLbl).Visibility = Visibility.Visible;
                }
                if (p.Price == 0.0M)
                {
                    object priceErrorLbl = this.FindName("LblPriceError");
                    ((Label)priceErrorLbl).Visibility = Visibility.Visible;
                }
                if (p.Category == null)
                {
                    object categoryErrorLbl = this.FindName("LblCategoryError");
                    ((Label)categoryErrorLbl).Visibility = Visibility.Visible;
                }
            }
        }

        private void ResetErrorMessages()
        {
            object nameErrorLbl = this.FindName("LblNameError");
            ((Label)nameErrorLbl).Visibility = Visibility.Hidden;

            object priceErrorLbl = this.FindName("LblPriceError");
            ((Label)priceErrorLbl).Visibility = Visibility.Hidden;

            object categoryErrorLbl = this.FindName("LblCategoryError");
            ((Label)categoryErrorLbl).Visibility = Visibility.Hidden;
        }
    }
}
