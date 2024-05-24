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
            w.ShowDialog();
        }

        private ICommand addReceipt;
        public ICommand AddReceipt
        {
            get
            {
                if (addReceipt == null)
                    addReceipt=new NonGenericCommand(AddReceiptWindow);
                return addReceipt;
            }

        }
        private void AddReceiptWindow(object obj)
        {
            var w = new CashierAddReceipt();
            w.ShowDialog();
        }

        private ICommand viewReceipts;
        public ICommand ViewReceipts
        {
            get
            {
                if (viewReceipts == null)
                    viewReceipts = new NonGenericCommand(ViewReceiptsWindow);
                return viewReceipts;
            }

        }
        private void ViewReceiptsWindow(object obj)
        {
            var w = new CashierViewReceipts();
            w.ShowDialog();
        }
    }
}
