using Microsoft.EntityFrameworkCore;
using SupermarketProject.Models;
using SupermarketProject.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.ViewModels
{
    public class CategoryTotalPriceVM:BasePropertyChanged
    {
        private ObservableCollection<CategoryTotalPrice> categoryTotalPrices;
        private ObservableCollection<Category> categories;

        public CategoryTotalPriceVM()
        {
            CategoryTotalPrices = new ObservableCollection<CategoryTotalPrice>();
            categories = new ObservableCollection<Category>();
            InitializeCategory();
            InitializeCategoryTotal();
        }


        public ObservableCollection<CategoryTotalPrice> CategoryTotalPrices
        {
            get => categoryTotalPrices;
            set
            {
                categoryTotalPrices = value;
                NotifyPropertyChanged("CategoryTotalPrices");
            }
        }


        public float CalculateCategoryTotalPrice(string categoryName)
        {
            using (var dbContext = new SupermarketDBContext())
            {
                var total = (from product in dbContext.Products
                             join stock in dbContext.Stocks on product.ProductID equals stock.ProductID
                             join category in dbContext.Categories on product.CategoryID equals category.CategoryID
                             where category.Name == categoryName && stock.SellingPrice != null && product.IsActive
                             select stock.SellingPrice * stock.Quantity).Sum();

                return total;
            }
        }

        public void InitializeCategory()
        {
            using(var dbContext = new SupermarketDBContext())
            {
                var list= dbContext.Categories.ToList();
                foreach(var category in list)
                {
                    if(category.IsActive)
                        categories.Add(category);
                }
            }
        }

        public void InitializeCategoryTotal()
        {
            foreach(var category in categories)
            {
                CategoryTotalPrices.Add(new CategoryTotalPrice( category.Name, CalculateCategoryTotalPrice(category.Name)));
            }
        }
    }
}
