using Microsoft.EntityFrameworkCore;
using SupermarketProject.Models;
using SupermarketProject.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.ViewModels
{
    public class CashierViewReceiptsVM:BasePropertyChanged
    {
        private ObservableCollection<Receipt> _receipts;

        public CashierViewReceiptsVM()
        {
            SearchReceipt();
        }

        public ObservableCollection<Receipt> Receipts
        {
            get => _receipts;
            set
            {
                _receipts = value;
                NotifyPropertyChanged("Receipts");
            }
        }

        public void SearchReceipt()
        {
            using(var _context=new SupermarketDBContext())
            {
                var receipts=_context.Receipts.Include(r=>r.ReceiptItems).ToList();
                Receipts = new ObservableCollection<Receipt>(receipts);
            }
        }
    }
}
