using SupermarketProject.Models;
using SupermarketProject.Models.BusinessLogicLayer;
using SupermarketProject.Models.EntityLayer;
using SupermarketProject.ViewModels.Commands;
using SupermarketProject.Views.Admin;
using SupermarketProject.Views.Cashier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SupermarketProject.ViewModels
{
    public class LoginVM : BasePropertyChanged
    {
        private string _username;
        private string _password;
        private string _type;
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                NotifyPropertyChanged(nameof(Username));
            }

        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                NotifyPropertyChanged(nameof(Password));
            }
        }

        public string Type
        {
            get => _type;
            set
            {
                _type = value;
                NotifyPropertyChanged(nameof(Type));
            }
        }

        public ICommand LoginCommand { get; }
        private UserBLL userBLL;

        public LoginVM()
        {
            userBLL = new UserBLL(new SupermarketDBContext());
            LoginCommand = new NonGenericCommand(Login);
        }

        private void Login(object parameter)
        {
            var user = userBLL.Authenticate(Username, Password);

            if (user != null)
            {
                if (user.IsActive == false)
                    MessageBox.Show("This user is INACTIV!");
                else if (user.Type == "Administrator" && Type.Contains("Administrator"))
                {
                    var admin = new Administrator();
                    admin.ShowDialog();
                }
                else if (user.Type == "Cashier" && Type.Contains("Cashier"))
                {
                    var cashier = new Cashier();
                    cashier.ShowDialog();
                }
                else
                {
                    MessageBox.Show("The ROLE is incorrect! ");
                }
            }
            else
            {
                MessageBox.Show("The USERNAME or PASSWORD is incorrect!");
            }

        }
    }
}
