using SupermarketProject.Models.EntityLayer;
using SupermarketProject.ViewModels.Commands;
using SupermarketProject.Views.Cashier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SupermarketProject.ViewModels
{
    public class CashierVM:BasePropertyChanged
    {
        private ICommand searchCommand;
        public ICommand SearchCommand
        {
            get
            {
                if (searchCommand == null)
                    searchCommand = new NonGenericCommand(SearchWindow);
                return searchCommand;
            }
        }
         
        private void SearchWindow(object obj)
        {
            var w = new CashierSearch();
            w.Show();
        }
    }
}
