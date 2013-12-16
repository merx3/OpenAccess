using ProductsManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManager.WPF.ViewModel
{
    public abstract class ProductsDataHolder
    {
        public readonly ProductsManagerModel Context;
        public AvailableProduct ProductToModify { get; set; }
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
        public List<Category> AllCategories
        {
            get
            {
                return this.Context.Categories.ToList();
            }
        }

        public ProductsDataHolder(ProductsManagerModel context)
        {
            this.Context = context;
        }

        public abstract void GetProductsAndCategories();
        public abstract void DeleteProducts();
    }
}
