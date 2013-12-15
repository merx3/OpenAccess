using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ProductsManager.WPF.ViewModel;

namespace ProductsManager.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ProductsViewModel<IMainWindow> mainViewModel;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindow = new MainWindow();
            this.mainViewModel = new ProductsViewModel<IMainWindow>(mainWindow);
            this.mainViewModel.Show();
        }
    }
}
