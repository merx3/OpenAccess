using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductsManager.WPF.ViewModel
{
    public interface IMainWindow
    {
        object DataContext { get; set; }
        void Close();
        void Show();
        object FindName(string name);
    }
}
