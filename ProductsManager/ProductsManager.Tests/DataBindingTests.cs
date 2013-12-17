using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductsManager.WPF;
using System.Linq;
using ProductsManager.WPF.ViewModel;


namespace ProductsManager.Tests
{
    [TestClass]
    public class DataBindingTests
    {
        [TestMethod, Ignore]
        public void CanGetAllProducts()
        {
            ProductsViewModel<IMainWindow> mainViewModel = new ProductsViewModel<IMainWindow>(new MainWindow());
            Assert.AreEqual(mainViewModel.DisplayedProducts.Count, 10);
            Assert.AreEqual(mainViewModel.DisplayedProducts.Where(x => x.Name == "Salt").ToList().Count, 1);
            Assert.AreEqual(mainViewModel.ProductsCategories.Count, 4);
        }

        [TestMethod, Ignore]
        public void CanFilterProductsByCategory()
        {
            throw new NotImplementedException();
        }

        [TestMethod, Ignore]
        public void CanSortProductsByName()
        {
            throw new NotImplementedException();
        }

        [TestMethod, Ignore]
        public void CanSortProductsByCategory()
        {
            throw new NotImplementedException();
        }

        [TestMethod, Ignore]
        public void CanSortProductsByPrice()
        {
            throw new NotImplementedException();
        }

        [TestMethod, Ignore]
        public void CanRefreshProducts()
        {
            throw new NotImplementedException();
        }
    }
}
