using Microsoft.EntityFrameworkCore;
using SupermarketProject.Models;
using SupermarketProject.Models.EntityLayer;
using SupermarketProject.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SupermarketProject.ViewModels
{
    public class LargestReceiptVM : BasePropertyChanged
    {
        private SupermarketDBContext _context = new SupermarketDBContext();
        private DateTime selectedDate;
        private Receipt largestReceipt;
        private string error;
        private List<ReceiptProducts> receiptProducts;


        public LargestReceiptVM()
        {
            largestReceipt = new Receipt();
            receiptProducts = new List<ReceiptProducts>();
        }
        public DateTime SelectedDate
        {
            get => selectedDate;
            set
            {
                if (selectedDate != value)
                {
                    selectedDate = value;
                    NotifyPropertyChanged("SelectedDate");
                }
            }
        }

        public List<ReceiptProducts> ReceiptProducts
        {
            get => receiptProducts;
            set
            {
                if (receiptProducts != value)
                {
                    receiptProducts = value;
                    NotifyPropertyChanged("ReceiptProducts");
                }
            }
        }

        public Receipt LargestReceipt
        {
            get => largestReceipt;
            set
            {
                largestReceipt = value;
                NotifyPropertyChanged("LargestReceipt");
            }
        }

        public string ErrorMessage
        {
            get => error;
            set
            {
                error = value;
                NotifyPropertyChanged("ErrorMessage");
            }
        }
        private ICommand search;
        public ICommand Search
        {
            get
            {
                if (search == null)
                {
                    search = new NonGenericCommand(SetLargestReceipt);
                }
                return search;
            }
        }


        private void SetLargestReceipt(object obj)
        {
            if (SelectedDate != null)
            {
                DateTime normalizedSelectedDate = SelectedDate.Date;

                var largestReceipt = _context.Receipts
                    .Include(r => r.Cashier)
                    .Include(r => r.ReceiptItems)
                    .Where(r => r.ReleseDate.Date == normalizedSelectedDate)
                    .OrderByDescending(r => r.Total)
                    .FirstOrDefault();

                if (largestReceipt != null)
                {
                    LargestReceipt = largestReceipt;
                    foreach(var r in largestReceipt.ReceiptItems)
                    {
                        var p = _context.Products.Where(i => i.ProductID == r.ProductID).FirstOrDefault();
                        r.Product = p;
                    }
                    ReceiptProducts = largestReceipt.ReceiptItems;
             
                    ErrorMessage = null;
                }
                else
                {
                    ErrorMessage = "Bonul este null";
                }
            }
            else
            {
                ErrorMessage = "SelectedDate este null";
            }
        }
    }

}
