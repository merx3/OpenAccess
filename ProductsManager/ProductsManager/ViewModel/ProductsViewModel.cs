using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsManager.Model;
using System.Windows.Controls;
using System.Windows;
using System.ComponentModel;

namespace ProductsManager.WPF.ViewModel
{
    public class ProductsViewModel<ViewType> : IDisposable, INotifyPropertyChanged
        where ViewType:IMainWindow
    {
        private object DataContext;
        private ViewType view;

        private readonly ProductsManagerModel context;
        private List<AvailableProduct> displayedProducts;
        public List<AvailableProduct> DisplayedProducts
        {
            get
            {
                return this.displayedProducts;
            }
            set
            {
                this.displayedProducts = value;
            }
        }

        private List<CategorySelection> productsCategories;
        public List<CategorySelection> ProductsCategories
        {
            get
            {
                return this.productsCategories;
            }
            set
            {
                this.productsCategories = value;
            }
        }
        public string productCategoryFilter { get; set; }

        public ProductsViewModel(ViewType v)
        {
            this.view = v;
            this.DataContext = this;
            v.DataContext = this.DataContext;
            this.context = new ProductsManagerModel();
            this.GetProductsAndCategories();
        }

        public void Dispose()
        {
            if (this.context != null)
            {
                this.context.Dispose();
            }
        }

        public void Show()
        {
            this.view.Show();
        }

        public void GetProductsAndCategories()
        {
            this.context.ClearChanges();
            if (this.ProductsCategories == null)
            {
                this.ProductsCategories = this.context.Categories.Select(x => new CategorySelection(x)).ToList();
            }

            //retrieve all cars
            var selectedCategoriesIds = this.ProductsCategories.Where(x => x.IsSelected == true).Select(x => x.Id).ToList();
            this.DisplayedProducts = this.context.Products.Where(t => selectedCategoriesIds.Contains(t.CategoryId)).Select(x => new AvailableProduct(x)).ToList();
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("DisplayedProducts"));
            }
        }

        public void DeleteProducts()
        {
            foreach (var item in this.DisplayedProducts)
            {
                if (item.ToDelete)
                {
                    this.context.Delete(this.context.Products.Where(x => x.Id == item.Id).FirstOrDefault());
                }
            }
            this.context.SaveChanges();
            this.GetProductsAndCategories();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
