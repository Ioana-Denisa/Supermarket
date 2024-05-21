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
    public class ProductVM :BasePropertyChanged
    {
        private ProductBLL productBLL;
        private string errorMessage;
        public ProductVM()
        {
            productBLL = new ProductBLL(new SupermarketDBContext());
            ProductList = productBLL.GetAll();
        }


        public ObservableCollection<Product> ProductList
        {
            get => productBLL.ProductsList;
            set => productBLL.ProductsList = value;
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

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new NonGenericCommand(Create);
                }
                return addCommand;
            }
        }

        private void Create(object parameter)
        {
            productBLL.Add(parameter);
            ErrorMessage = productBLL.ErrorMessage;
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
            productBLL.Update(obj);
            ErrorMessage = productBLL.ErrorMessage;
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
            productBLL.Delete(obj);
            ErrorMessage = productBLL.ErrorMessage;
        }
    }
}

