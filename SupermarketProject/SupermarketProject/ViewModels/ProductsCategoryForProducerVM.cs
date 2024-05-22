using Microsoft.EntityFrameworkCore;
using SupermarketProject.Models;
using SupermarketProject.Models.BusinessLogicLayer;
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
    public class ProductsCategoryForProducerVM : BasePropertyChanged
    {
        private ObservableCollection<Producer> producers;
        private ObservableCollection<Category> categories;
        private ObservableCollection<Product> products;
        private Producer selectedProducer;
        private Category selectedCategory;
        private string errorMessage;

        private ICommand productsCategoryForProducer;


        public ProductsCategoryForProducerVM()
        {
            Categories= new ObservableCollection<Category>();
            Producers = new ObservableCollection<Producer>();
            Products = new ObservableCollection<Product>();
            
            using(var dbContext=new SupermarketDBContext())
            {
                var producerList = dbContext.Producers.ToList();
                foreach (var item in producerList)
                {
                    Producers.Add(item);
                }

                var categoryList=dbContext.Categories.ToList();
                foreach(var item in categoryList)
                    Categories.Add(item);
            }
        }


        public string ErrorMessage
        {
            get => errorMessage;
            set
            {
                errorMessage = value;
                NotifyPropertyChanged("ErrorMessage");
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

        public ObservableCollection<Product> Products
        {
            get => products;
            set
            {
                products = value;
                NotifyPropertyChanged("Products");
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

        public Producer SelectedProducer
        {
            get=>selectedProducer;
            set
            {
                selectedProducer = value;
                NotifyPropertyChanged("SelectedProducer");
                SearchProducts();
            }
        }

        public Category SelectedCategory
        {
            get => selectedCategory;
            set
            {
                selectedCategory = value;
                NotifyPropertyChanged("SelectedCategory");
                SearchProducts();
            }
        }



        public void SearchProducts()
        {
            products.Clear();
            using (var _context = new SupermarketDBContext())
            {
                if (selectedCategory != null && selectedProducer != null)
                {
                    if (selectedProducer.IsActive && selectedCategory.IsActive)
                    {

                        var lis = _context.Products.FromSqlRaw("SelectProducts @p0,@p1", parameters: new object[] { selectedProducer.ProducerID, selectedCategory.CategoryID }).ToList();

                        foreach (var l in lis)
                        {
                            l.Category = selectedCategory;
                            l.Producer = selectedProducer;
                            products.Add(l);
                        }
                    }
                    else if (!selectedCategory.IsActive)
                        ErrorMessage = "The category "+selectedCategory.Name+" is INACTIVE!";
                    else
                        ErrorMessage = "The producer "+selectedProducer.Name+" is INACTIVE!";

                }
            }
        }

    }
}
