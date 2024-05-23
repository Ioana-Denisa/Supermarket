using Microsoft.EntityFrameworkCore;
using SupermarketProject.Models;
using SupermarketProject.Models.EntityLayer;
using SupermarketProject.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SupermarketProject.ViewModels
{
    public class DailyTotalCashierVM:BasePropertyChanged
    {
        private SupermarketDBContext _context=new SupermarketDBContext();
       // private ICommand dailyCommand;
        public ObservableCollection<User> Cashiers {  get; set; }
        public ObservableCollection<DateTime> Date { get; set; }
        public ObservableCollection<DailyTotal> DailyTotals { get; set; }

        private DateTime _selectedMonth;
        public DateTime SelectedMonth
        {
            get => _selectedMonth;
            set
            {
                if (_selectedMonth != value)
                {
                    _selectedMonth = value;
                    NotifyPropertyChanged("SelectedMonth");
                    DailyTotalPrice();
                }
            }
        }


        private User _selectedUser;
        public User SelectedUser
        {
            get => _selectedUser;
            set
            {
                if( _selectedUser != value)
                {
                    _selectedUser = value;
                    NotifyPropertyChanged("SelectedUser");
                    DailyTotalPrice();
                }
            }
        }

        public DailyTotalCashierVM()
        {
            Cashiers = new ObservableCollection<User>(_context.Users.Where(u => u.Type == "Cashier").ToList());
            InitializeMonthsAndYears();
            DailyTotals = new ObservableCollection<DailyTotal>();
        }

        private void InitializeMonthsAndYears()
        {
            Date = new ObservableCollection<DateTime>();

            for (int month = 1; month <= 12; month++)
            {
                DateTime currentMonth = new DateTime(DateTime.Now.Year, month, 1);
                Date.Add(currentMonth);
            }
        }

        public void DailyTotalPrice()
        {
            if(_selectedMonth==null ||_selectedUser==null )     return;

            var list = _context.Receipts.FromSqlRaw("DailyTotalCashier @p0,@p1", parameters: new object[] { SelectedUser.UserID, SelectedMonth }).ToList();
            DailyTotals.Clear();
            foreach(var item in list)
            {
                DailyTotal total = new DailyTotal();
                total.Total = item.Total;
                total.Day = item.ReleseDate;
                DailyTotals.Add(total);
            }
        }

    }

    public class DailyTotal
    {
        public DateTime Day { get; set; }
        public float Total {  get; set; }
    }
}
