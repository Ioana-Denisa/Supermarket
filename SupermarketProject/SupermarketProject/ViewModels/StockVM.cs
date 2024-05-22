using SupermarketProject.Models.BusinessLogicLayer;
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
    public class StockVM:BasePropertyChanged
    {
        private StockBLL stockBLL;
        private string errorMessage;
        private string selectedUnit;
        public StockVM()
        {
            stockBLL = new StockBLL(new SupermarketDBContext());
            StockList = stockBLL.GetAll();
            ProductsList=stockBLL.GetAllProducts();
        }


        public ObservableCollection<Stock> StockList
        {
            get => stockBLL.StockList;
            set => stockBLL.StockList = value;
        }

        public ObservableCollection<Product> ProductsList
        {
            get => stockBLL.ProductsList;
            set => stockBLL.ProductsList = value;
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

        public string SelectedUnit
        {
            get => selectedUnit;
            set
            { 
                selectedUnit = value;
                NotifyPropertyChanged("SelectedUnit");
            }
        }

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new NonGenericCommand(CreateStock);
                }
                return addCommand;
            }
        }

        private void CreateStock(object parameter)
        {
            stockBLL.Add(parameter);
            ErrorMessage = stockBLL.ErrorMessage;
        }

        private ICommand updateCommand;
        public ICommand UpdateCommand
        {
            get
            {
                if (updateCommand == null)
                {
                    updateCommand = new NonGenericCommand(UpdateMethod);
                }
                return updateCommand;
            }
        }

        public void UpdateMethod(object obj)
        {
            stockBLL.Update(obj);
            ErrorMessage = stockBLL.ErrorMessage;
        }

        private ICommand deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                {
                    deleteCommand = new NonGenericCommand(DeleteMethod);
                }
                return deleteCommand;
            }
        }
        public void DeleteMethod(object obj)
        {
            stockBLL.Delete(obj);
            ErrorMessage = stockBLL.ErrorMessage;
        }
    }
}
