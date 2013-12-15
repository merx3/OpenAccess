using SpikeOA.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SpikeOA.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ProductsViewModel mainViewModel;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            this.mainViewModel = new ProductsViewModel();
            this.mainViewModel.Show();
        }
        
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            if (this.mainViewModel != null)
            {
                this.mainViewModel.Dispose();
            }
        }    
    }
}
