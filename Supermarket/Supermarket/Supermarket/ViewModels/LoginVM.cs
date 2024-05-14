using Supermarket.Helpers;
using Supermarket.Views.Admin;
using Supermarket.Views.Cashier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Supermarket.ViewModels
{
    public class LoginVM
    {
        private ICommand openWindowCommandLogin;

        public ICommand OpenWindowCommandLogin
        {
            get
            {
                if (openWindowCommandLogin == null)
                {
                    openWindowCommandLogin = new RelayCommand(OpenWindow);
                }
                return openWindowCommandLogin;
            }
        }

        public void OpenWindow(object obj)
        {
            string nr = obj as string;
            switch (nr)
            {
                case "1":
                   Administrator administrator = new Administrator();
                    administrator.Show();
                    break;
                case "2":
                   Cashier cashier = new Cashier();
                    cashier.Show();
                    break;
            }
        }
    }
}
