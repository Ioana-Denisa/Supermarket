using SupermarketProject.Models;
using SupermarketProject.Models.BusinessLogicLayer;
using SupermarketProject.Models.EntityLayer;
using SupermarketProject.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SupermarketProject.ViewModels
{
    public class UserVM :BasePropertyChanged
    {
        private UserBLL userBLL;
        private string errorMessage;
        public UserVM()
        {
            userBLL = new UserBLL(new SupermarketDBContext());
            UsersList = userBLL.GetAll();
        }


        public ObservableCollection<User> UsersList
        {
            get => userBLL.UsersList;
            set=>userBLL.UsersList = value;
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
                    addCommand = new NonGenericCommand(CreateUser);
                }
                return addCommand;
            }
        }

        private void CreateUser(object parameter)
        {
            userBLL.Add(parameter);
            ErrorMessage=userBLL.ErrorMessage;
        }

        private ICommand updateCommand;
        public ICommand UpdateCommand
        {
            get
            {
                if(updateCommand == null)
                {
                    updateCommand=new NonGenericCommand(UpdateMethod);
                }
                return updateCommand;
            }
        }

        public void UpdateMethod(object obj)
        {
            userBLL.Update(obj);
            ErrorMessage=userBLL.ErrorMessage;
        }

        private ICommand deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                if(deleteCommand == null)
                {
                    deleteCommand=new NonGenericCommand(DeleteMethod);
                }
                return deleteCommand;
            }
        }
        public void DeleteMethod(object obj)
        {
            userBLL.Delete(obj);
            ErrorMessage=userBLL.ErrorMessage;
        }
    }
}
