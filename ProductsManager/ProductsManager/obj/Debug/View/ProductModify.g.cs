﻿#pragma checksum "..\..\..\View\ProductModify.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5B06B818FAD0358867F1CA5AC04CA284"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProductsManager.WPF.ViewModel.Converters;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ProductsManager.WPF {
    
    
    /// <summary>
    /// ProductModify
    /// </summary>
    public partial class ProductModify : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\View\ProductModify.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ProductIdLabel;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\View\ProductModify.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBName;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\View\ProductModify.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblNameError;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\View\ProductModify.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBPrice;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\View\ProductModify.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblPriceError;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\View\ProductModify.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBAvailable;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\View\ProductModify.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBCategory;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\View\ProductModify.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblCategoryError;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProductsManager;component/view/productmodify.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ProductModify.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ProductIdLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.TBName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.LblNameError = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.TBPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.LblPriceError = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.CBAvailable = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.CBCategory = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.LblCategoryError = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            
            #line 153 "..\..\..\View\ProductModify.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveProduct);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

