using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsManager.Model;
using System.Windows.Controls;
using System.Windows;
using System.ComponentModel;
using System.Reflection;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace ProductsManager.WPF.ViewModel
{
    public class ProductsViewModel<ViewType> : ProductsDataHolder, IDisposable, INotifyPropertyChanged
        where ViewType:IMainWindow
    {
        private object DataContext;
        private ViewType view;
        
        public ProductsViewModel(ViewType v)
            :base(new ProductsManagerModel())
        {
            this.view = v;
            this.DataContext = this;
            v.DataContext = this.DataContext;
            this.InitializeDatabase();
            this.GetProductsAndCategories();
        }

        public void Dispose()
        {
            if (this.Context != null)
            {
                this.Context.Dispose();
            }
        }

        public void Show()
        {
            this.view.Show();
        }

        public override void GetProductsAndCategories()
        {
            this.Context.ClearChanges();
            if (this.ProductsCategories == null)
            {
                this.ProductsCategories = this.Context.Categories.Select(x => new CategorySelection(x)).ToList();
            }

            //retrieve all cars
            var selectedCategoriesIds = this.ProductsCategories.Where(x => x.IsSelected == true).Select(x => x.Id).ToList();
            this.DisplayedProducts = this.Context.Products.Where(t => selectedCategoriesIds.Contains(t.CategoryId)).Select(x => new AvailableProduct(x)).ToList();
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("DisplayedProducts"));
            }
        }

        public override  void DeleteProducts()
        {
            foreach (var item in this.DisplayedProducts)
            {
                if (item.ToDelete)
                {
                    this.Context.Delete(this.Context.Products.Where(x => x.Id == item.Id).FirstOrDefault());
                }
            }
            this.Context.SaveChanges();
            this.GetProductsAndCategories();
        }

        private void InitializeDatabase()
        {
            string script = null;
            //var schemaHandler = this.Context.GetSchemaHandler();

            //if (schemaHandler.DatabaseExists())
            //{
            //    // not working
            //    script = schemaHandler.CreateUpdateDDLScript(null);
            //}
            //else
            //{
            //    var assembly = Assembly.GetExecutingAssembly();
            //    var resourceName = "ProductsManager.WPF.script.MyProjectDb.sql";

            //    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            //    {
            //        using (StreamReader reader = new StreamReader(stream))
            //        {
            //            script = reader.ReadToEnd();
            //        }
            //    }
            
            //    // this too...
            //    //schemaHandler.CreateDatabase();
            //    //script = schemaHandler.CreateDDLScript(); 
            //}

            //if (!string.IsNullOrEmpty(script))
            //{
            //    schemaHandler.ExecuteDDLScript(script);
            //}

            var schemaHandler = this.Context.GetSchemaHandler();

            if (!schemaHandler.DatabaseExists())
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "ProductsManager.WPF.script.MyProjectDb.sql";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        script = reader.ReadToEnd();
                    }
                };

                string connectionString = ConfigurationManager.ConnectionStrings["master"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(
                           connectionString))
                {
                    connection.Open();
                    ExecuteScript(connection, script);
                }
            }
        }

        protected virtual void ExecuteScript(SqlConnection connection, string script)
        {
            string[] commandTextArray = System.Text.RegularExpressions.Regex.Split(script, "\r\n[\t ]*GO");

            SqlCommand _cmd = new SqlCommand(String.Empty, connection);

            foreach (string commandText in commandTextArray)
            {
                if (commandText.Trim() == string.Empty) continue;
                if ((commandText.Length >= 3) && (commandText.Substring(0, 3).ToUpper() == "USE"))
                {
                    throw new Exception("Create-script contains USE-statement. Please provide non-database specific create-scripts!");
                }

                _cmd.CommandText = commandText;
                _cmd.ExecuteNonQuery();
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
