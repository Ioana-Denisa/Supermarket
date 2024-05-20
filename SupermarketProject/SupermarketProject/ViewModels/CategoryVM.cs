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
    public class CategoryVM:BasePropertyChanged
    {
        private CategoryBLL categoryBLL;
        private string errorMessage;

        public CategoryVM()
        {
            categoryBLL=new CategoryBLL(new SupermarketDBContext());
            CategoryList = categoryBLL.GetAll();
        }

        public ObservableCollection<Category> CategoryList
        {
            get=>categoryBLL.CategoryList;
            set => categoryBLL.CategoryList = value;
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
                    addCommand = new NonGenericCommand(CreateCategory);
                }
                return addCommand;
            }
        }

        private void CreateCategory(object parameter)
        {
            categoryBLL.Add(parameter);
            ErrorMessage = categoryBLL.ErrorMessage;
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
            categoryBLL.Update(obj);
            ErrorMessage = categoryBLL.ErrorMessage;
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
            categoryBLL.Delete(obj);
            ErrorMessage = categoryBLL.ErrorMessage;
        }
    }
}
