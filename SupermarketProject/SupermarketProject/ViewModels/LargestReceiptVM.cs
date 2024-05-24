using Microsoft.EntityFrameworkCore;
using SupermarketProject.Models;
using SupermarketProject.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.ViewModels
{
    public class LargestReceiptVM : BasePropertyChanged
    {
        private SupermarketDBContext _context = new SupermarketDBContext();
        private DateTime selectedDate;
        private string receiptDetails;
        private Receipt largestReceipt;
        private string error;

        public LargestReceiptVM()
        {
            largestReceipt=new Receipt();
            SetLargestReceipt();
        }

        public string ReceiptDetails
        {
            get => receiptDetails;
            set
            {
                if (receiptDetails != value)
                {
                    receiptDetails = value;
                    NotifyPropertyChanged("ReceiptDetails");

                }
            }
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
                error=value;
                NotifyPropertyChanged("ErrorMessage");
            }
        }

        private void SetLargestReceipt()
        {
            if (SelectedDate != null)
            {
                var largestReceipt = _context.Receipts
                    .Where(r => EF.Functions.DateDiffDay(r.ReleseDate, SelectedDate) == 0)
                    .OrderByDescending(r => r.Total)
                    .FirstOrDefault();

                if (largestReceipt != null)
                {
                    LargestReceipt = largestReceipt;
                }
                else
                {
                    ErrorMessage = "Bonul este null";
                }
            }
        }
    }
}
