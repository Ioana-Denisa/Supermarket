using SupermarketProject.Models.EntityLayer;
using SupermarketProject.ViewModels.Commands;
using SupermarketProject.Views.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SupermarketProject.ViewModels
{
    public class AdministratorVM:BasePropertyChanged
    {
        private ICommand userCommand;
        private ICommand categoryCommand;
        private ICommand producerCommand;
        private ICommand productCommand;
        private ICommand stockCommand;
        private ICommand ticketCommand;


        public ICommand UserCommand
        {
            get
            {
                if (userCommand == null)
                {
                    userCommand = new NonGenericCommand(UserWindow);
                }
                return userCommand;
            }
        }
        private void UserWindow(object parameter)
        {
            var user = new UserAdmin();
            user.Show();

        }

        public ICommand CategoryCommand
        {
            get
            {
                if(categoryCommand==null)
                {
                    categoryCommand = new NonGenericCommand(CategoryWindow); 
                }
                return categoryCommand;
            }
        }

        private void CategoryWindow(object obj)
        {
            var category=new CategoryAdmin();
            category.Show();
        }
    }
}
