using ProductsManager.Model;
using ProductsManager.WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductsManager.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ApplyCategoriesFiltes(object sender, RoutedEventArgs e)
        {
            ((ProductsDataHolder)this.DataContext).GetProductsAndCategories();
        }

        private void DeleteSelectedProducts(object sender, RoutedEventArgs e)
        {
            ((ProductsDataHolder)this.DataContext).DeleteProducts();
        }

        private void OpenCreateWindow(object sender, RoutedEventArgs e)
        {
            ProductModify productEditWindow = new ProductModify();
            
            productEditWindow.DataContext = this.DataContext;
            Product createdProduct = new Product()
            {
                Id = -1,
                Name = "",
                CategoryId = -1,
                Category = null,
                IsAvailable = true,
                Price = 0.0M
            };
            ((ProductsDataHolder)this.DataContext).ProductToModify = new AvailableProduct(createdProduct);

            productEditWindow.Title = "Create New Product";
            productEditWindow.Owner = this;
            productEditWindow.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
            bool? newProductCreated = productEditWindow.ShowDialog();
            if (newProductCreated.GetValueOrDefault(false) == true)
            {
                ((ProductsViewModel<IMainWindow>)this.DataContext).GetProductsAndCategories();
            }
        }

        private void EditProduct(object sender, RoutedEventArgs e)
        {
            ProductModify productEditWindow = new ProductModify();
            productEditWindow.DataContext = this.DataContext;

            string productId = ((Button)sender).Tag.ToString();
            var dataContext = ((ProductsDataHolder)this.DataContext);
            var product = dataContext.Context.Products.Where(x => x.Id.ToString() == productId).FirstOrDefault();
            dataContext.ProductToModify = new AvailableProduct(product);

            productEditWindow.Title = "Edit Product: " + product.Name;
            productEditWindow.Owner = this;
            productEditWindow.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
            bool? newProductCreated = productEditWindow.ShowDialog();
            if (newProductCreated.GetValueOrDefault(false) == true)
            {
                ((ProductsViewModel<IMainWindow>)this.DataContext).GetProductsAndCategories();
            }

        }
    }
}
