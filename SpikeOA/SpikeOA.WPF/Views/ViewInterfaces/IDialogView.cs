﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeOA.WPF.Views.ViewInterfaces
{
    public interface IDialogView : IView
    {
        bool? ShowDialog();
        bool? DialogResult { get; set; }
        System.Windows.Window Owner { get; set; }
    }
}
