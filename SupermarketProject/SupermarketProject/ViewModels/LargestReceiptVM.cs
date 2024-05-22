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
    public class LargestReceiptVM:BasePropertyChanged
    {
        private SupermarketDBContext _context=new SupermarketDBContext();
        private DateTime selectedDate;
        private string receiptDetails;

        public string ReceiptDetails
        {
            get=>receiptDetails;
            set
            {
                if(receiptDetails != value)
                {
                    receiptDetails= value;
                    NotifyPropertyChanged("ReceiptDetails");

                }
            }
        }

        public DateTime SelectedDate
        {
            get=> selectedDate;
            set
            {
                if(selectedDate != value)
                {
                    selectedDate= value;
                    NotifyPropertyChanged("SelectedDate");
                }
            }
        }

        private void LargestReceipt()
        {
            var date = SelectedDate.Date;
                
        }
    }
}
