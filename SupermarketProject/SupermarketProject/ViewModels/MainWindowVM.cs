using SupermarketProject.ViewModels.Commands;
using SupermarketProject.Views;
using SupermarketProject.Views.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SupermarketProject.ViewModels
{
    public class MainWindowVM
    {
        private ICommand openWindowCommand;

        public ICommand OpenWindowCommand
        {
            get
            {
                if (openWindowCommand == null)
                {
                    openWindowCommand = new NonGenericCommand(OpenWindow);
                }
                return openWindowCommand;
            }
        }

        public void OpenWindow(object obj)
        {
            Administrator login = new Administrator();
            login.Show();
        }
    }
}
