using SpikeOA.Model;
using SpikeOA.WPF.Views.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeOA.WPF.ViewModels
{
    public class ProductsViewModel : ViewModelBase<IMainView>, IDisposable
    {
        private const string STATUS_MESSAGE = "{0} cars retrieved from the database.";
        private const string CONFIRM_DELETE_MESSAGE = "You are about to delete {0} {1}. Are you sure?";
        private const string CONFIRM_DELETE_TITLE = "Confirm delete.";
        private const string DELETE_ERROR_RELATED_ENTRY_MESSAGE = "Could not delete this car entry because other entries related to it exist in the database. Exception message:\r\n";
        private const string DELETE_ERROR_MESSAGE = "Internal error has occured. Exception message:\r\n";
        private const string DELETE_ERROR_TITLE = "Deletion error!";

        private readonly ProductsManagerSpike context;
        private string productCategoryFilter;
        private bool isFilteringActive;
        private string status;
        private List<Product> productsToDisplay;
        private Product selectedProduct;
        private RelayCommand command;

        public string ProductCategoryFilter
        {
            get
            {
                return this.productCategoryFilter;
            }
            set
            {
                this.productCategoryFilter = value.Trim();
                this.RaisePropertyChanged("CarMakerFilter");
            }
        }
        public string Status
        {
            get
            {
                return this.status;
            }
            private set
            {
                this.status = value.Trim();
                this.RaisePropertyChanged("Status");
            }
        }
        public List<Product> ProductsToDisplay
        {
            get
            {
                return this.productsToDisplay;
            }
            private set
            {
                this.productsToDisplay = value;
                this.RaisePropertyChanged("ProductsToDisplay");
            }
        }
        public Product SelectedProduct
        {
            get
            {
                return this.selectedProduct;
            }
            set
            {
                this.selectedProduct = value;
                this.RaisePropertyChanged("SelectedProduct");
            }
        }

        public ProductsViewModel()
            : base(new MainWindow())
        {
            this.context = new ProductsManagerSpike();
            this.ProductCategoryFilter = string.Empty;
            this.isFilteringActive = false;
            this.Status = string.Empty;

            this.RetrieveProductsToDisplay();
        }

        public RelayCommand FilterProductsCommand
        {
            get
            {
                this.command = new RelayCommand(this.FilterProducts);
                return this.command;
            }
            set
            {
                this.command = value;
            }
        }

        public RelayCommand RefreshCommand
        {
            get
            {
                this.command = new RelayCommand(this.Refresh);
                return this.command;
            }
            set
            {
                this.command = value;
            }
        }

        private void Refresh()
        {
            if (this.isFilteringActive == false)
            {
                this.ProductCategoryFilter = string.Empty;
            }
            this.RetrieveProductsToDisplay();
        }

        public void Show()
        {
            this.View.Show();
        }

        public void Dispose()
        {
            if (this.context != null)
            {
                this.context.Dispose();
            }
        }

        private void ResetFilter()
        {
            this.ProductCategoryFilter = string.Empty;
            this.isFilteringActive = false;
            this.RetrieveProductsToDisplay();
        }

        private bool CanResetFilter()
        {
            return this.isFilteringActive;
        }

        private void FilterProducts()
        {
            this.RetrieveProductsToDisplay();
            this.isFilteringActive = (string.IsNullOrEmpty(this.ProductCategoryFilter) == false);
        }

        private void RetrieveProductsToDisplay()
        {
            this.ClearCache();
            int? selectedProductId = null;
            //save the Id of the currently selected car
            if (this.SelectedProduct != null)
            {
                selectedProductId = this.SelectedProduct.Id;
            }
            if (string.IsNullOrEmpty(this.productCategoryFilter))
            {
                //retrieve all cars
                this.ProductsToDisplay = this.context.Products.ToList();
            }
            else
            {
                //retrieve cars which comply to the filter
                this.ProductsToDisplay = this.context.Products.Where(product => product.Category.Name == this.productCategoryFilter).ToList();
            }
            //restore the selected car using its saved Id
            if (selectedProductId.HasValue)
            {
                this.SelectedProduct = this.ProductsToDisplay.FirstOrDefault(product => product.Id == selectedProductId);
            }

            this.Status = string.Format(STATUS_MESSAGE, this.ProductsToDisplay.Count);
        }

        private void ClearCache()
        {
            if (this.ProductsToDisplay != null)
            {
                this.context.ClearChanges();
            }
        }
    }
}
