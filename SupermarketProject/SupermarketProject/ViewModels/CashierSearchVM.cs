using Microsoft.EntityFrameworkCore;
using SupermarketProject.Models;
using SupermarketProject.Models.EntityLayer;
using SupermarketProject.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SupermarketProject.ViewModels
{
    public class CashierSearchVM : BasePropertyChanged
    {
        private string productName;
        private string barcode;
        private DateTime? expirationDate;
        private ObservableCollection<Producer> producers;
        private ObservableCollection<Category> categories;
        private string producerName;
        private string categoryName;

        public ObservableCollection<SearchProductResult> ProductsList { get; set; } = new ObservableCollection<SearchProductResult>();

        public string ProductName
        {
            get => productName;
            set { productName = value; NotifyPropertyChanged("ProductName"); }
        }

        public string Barcode
        {
            get => barcode;
            set { barcode = value; NotifyPropertyChanged("Barcode"); }
        }

        public DateTime? ExpirationDate
        {
            get => expirationDate;
            set
            {
                expirationDate = value;
                NotifyPropertyChanged("ExpirationDate");
            }
        }

        public ObservableCollection<Producer> Producers
        {
            get => producers;
            set
            {
                producers = value;
                NotifyPropertyChanged("Producers");
            }
        }

        public string ProducerName
        {
            get => producerName;
            set
            {
                producerName = value;
                NotifyPropertyChanged("ProducerName");
            }
        }

        public string CategoryName
        {
            get => categoryName;
            set
            {
                categoryName = value;
                NotifyPropertyChanged("CategoryName");
            }
        }

        public ObservableCollection<Category> Categories
        {
            get => categories;
            set
            {
                categories = value;
                NotifyPropertyChanged("Categories");
            }
        }

        private ICommand searchCommand;
        public ICommand SearchCommand
        {
            get
            {
                if (searchCommand == null)
                    searchCommand = new NonGenericCommand(SearchProducts);
                return searchCommand;
            }
        }

        public CashierSearchVM()
        {
            Initialize();
        }

        public void Initialize()
        {
            Categories = new ObservableCollection<Category>();
            Producers = new ObservableCollection<Producer>();

            using (var dbContext = new SupermarketDBContext())
            {
                var catList = dbContext.Categories.ToList();
                foreach (var item in catList)
                {
                    if (item.IsActive)
                        Categories.Add(item);
                }

                var prodList = dbContext.Producers.ToList();
                foreach (var item in prodList)
                {
                    if (item.IsActive)
                        Producers.Add(item);
                }
            }
        }

        public void SearchProducts(object obj)
        {
            using (var dbContext = new SupermarketDBContext())
            {
                var query = from product in dbContext.Products
                            join producer in dbContext.Producers on product.ProducerID equals producer.ProducerID
                            join category in dbContext.Categories on product.CategoryID equals category.CategoryID
                            join stock in dbContext.Stocks on product.ProductID equals stock.ProductID
                            where (string.IsNullOrEmpty(productName) || product.Name == productName)
                                  && (string.IsNullOrEmpty(barcode) || product.Barcode == barcode)
                                  && (!expirationDate.HasValue || stock.ExpirationDate == expirationDate.Value)
                                  && (string.IsNullOrEmpty(producerName) || producer.Name == producerName)
                                  && (string.IsNullOrEmpty(categoryName) || category.Name == categoryName)
                            orderby product.Name
                            select new SearchProductResult
                            {
                                ProductName = product.Name,
                                Barcode = product.Barcode,
                                ExpirationDate = stock.ExpirationDate,
                                ProducerName = producer.Name,
                                CategoryName = category.Name
                            };

                var products = query.ToList();
                ProductsList.Clear();
                products.ForEach(p => ProductsList.Add(p));
            }
        }
    }

    public class SearchProductResult
    {
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string ProducerName { get; set; }
        public string CategoryName { get; set; }
    }
}
