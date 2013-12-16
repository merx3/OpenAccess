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
    public class ProductsViewModel<ViewType> : ProductsDataHolder, IDisposable, INotifyPropertyChanged
        where ViewType:IMainWindow
    {
        private object DataContext;
        private ViewType view;
        
        public ProductsViewModel(ViewType v)
            :base(new ProductsManagerModel())
        {
            this.view = v;
            this.DataContext = this;
            v.DataContext = this.DataContext;
            this.GetProductsAndCategories();
        }

        public void Dispose()
        {
            if (this.Context != null)
            {
                this.Context.Dispose();
            }
        }

        public void Show()
        {
            this.view.Show();
        }

        public override void GetProductsAndCategories()
        {
            this.Context.ClearChanges();
            if (this.ProductsCategories == null)
            {
                this.ProductsCategories = this.Context.Categories.Select(x => new CategorySelection(x)).ToList();
            }

            //retrieve all cars
            var selectedCategoriesIds = this.ProductsCategories.Where(x => x.IsSelected == true).Select(x => x.Id).ToList();
            this.DisplayedProducts = this.Context.Products.Where(t => selectedCategoriesIds.Contains(t.CategoryId)).Select(x => new AvailableProduct(x)).ToList();
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("DisplayedProducts"));
            }
        }

        public override  void DeleteProducts()
        {
            foreach (var item in this.DisplayedProducts)
            {
                if (item.ToDelete)
                {
                    this.Context.Delete(this.Context.Products.Where(x => x.Id == item.Id).FirstOrDefault());
                }
            }
            this.Context.SaveChanges();
            this.GetProductsAndCategories();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
