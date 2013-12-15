using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SpikeOA.WPF.Views
{
    public class BaseDialogWindow : Window
    {
        public BaseDialogWindow()
        {
            this.Owner = App.Current.MainWindow;
            this.ShowInTaskbar = false;
            this.ResizeMode = System.Windows.ResizeMode.NoResize;
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
        }
    }
}
