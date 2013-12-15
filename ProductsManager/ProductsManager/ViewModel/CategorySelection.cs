using ProductsManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductsManager.WPF.ViewModel
{
    public class CategorySelection
    {
        private int id;
        private string name;
        private string description;
        private bool isSelected;
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool IsSelected { get; set; }

        public CategorySelection(Category category)
        {
            this.Id = category.Id;
            this.Name = category.Name;
            this.Description = category.Description;
            this.IsSelected = true;
        }
    }
}
