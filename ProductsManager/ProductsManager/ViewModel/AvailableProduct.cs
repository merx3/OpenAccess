using ProductsManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductsManager.WPF.ViewModel
{
    public class AvailableProduct
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; private set; }
        public decimal? Price { get; set; }
        public bool IsAvailable { get; set; }
        public bool ToDelete { get; set; }

        public AvailableProduct(Model.Product x)
        {
            this.Id = x.Id;
            this.Name = x.Name;
            this.Category = x.Category;
            this.CategoryId = x.CategoryId;
            this.Price = x.Price;
            this.IsAvailable = x.IsAvailable;
            this.ToDelete = false;
        }
    }
}
