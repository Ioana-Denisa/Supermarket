using Supermarket.Helpers;
using Supermarket.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Supermarket.ViewModels
{
    public class MainWindowVM
    {
        private ICommand openWindowCommand;

        public ICommand OpenWindowCommand
        {
            get
            {
                if(openWindowCommand == null)
                {
                    openWindowCommand = new RelayCommand(OpenWindow);
                }
                return openWindowCommand;
            }
        }

        public void OpenWindow(object obj)
        {
            Login login=new Login();
            login.Show();
        }
    }
}
