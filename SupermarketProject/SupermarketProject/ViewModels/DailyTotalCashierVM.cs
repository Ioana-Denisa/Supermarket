using Microsoft.EntityFrameworkCore;
using SupermarketProject.Models;
using SupermarketProject.Models.EntityLayer;
using SupermarketProject.ViewModels.Commands;
using SupermarketProject.Views.Cashier;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SupermarketProject.ViewModels
{
    public class DailyTotalCashierVM : BasePropertyChanged
    {
        private SupermarketDBContext _context = new SupermarketDBContext();
        public ObservableCollection<User> Cashiers { get; set; }
        private ObservableCollection<DateTime> date;
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
                if (_selectedUser != value)
                {
                    _selectedUser = value;
                    NotifyPropertyChanged("SelectedUser");
                    DailyTotalPrice();
                }
            }
        }

        public ObservableCollection<DateTime> Date
        {
            get => date;
            set
            {
                date = value;
                NotifyPropertyChanged("Date");
            }
        }

        public void InitializeDatesForCurrentYear()
        {
            date = new ObservableCollection<DateTime>();

            DateTime currentDate = DateTime.Today;
            DateTime startDate = new DateTime(currentDate.Year, 1, 1);
            DateTime endDate = startDate.AddYears(1);

            for (DateTime date = startDate; date < endDate; date = date.AddDays(1))
            {
                this.date.Add(date);
            }
        }


        public DailyTotalCashierVM()
        {
            Cashiers = new ObservableCollection<User>(_context.Users.Where(u => u.Type == "Cashier").ToList());
            InitializeDatesForCurrentYear();
            InitializeMonthsAndYears();
            DailyTotals = new ObservableCollection<DailyTotal>();
        }

        private void InitializeMonthsAndYears()
        {
            date = new ObservableCollection<DateTime>();

            for (int month = 1; month <= 12; month++)
            {
                DateTime currentMonth = new DateTime(DateTime.Now.Year, month, 1);
                date.Add(currentMonth);
            }
        }

        public void DailyTotalPrice()
        {
            //if(_selectedMonth==null ||_selectedUser==null )     return;

            //var list = _context.Receipts.FromSqlRaw("DailyTotalCashier @p0,@p1", parameters: new object[] { SelectedUser.UserID, SelectedMonth }).ToList();
            //DailyTotals.Clear();
            //foreach(var item in list)
            //{
            //    DailyTotal total = new DailyTotal();
            //    total.Total = item.Total;
            //    total.Day = item.ReleseDate;
            //    DailyTotals.Add(total);
            //}

            using (var context = new SupermarketDBContext())
            {
                DateTime startDate = new DateTime(SelectedMonth.Year, SelectedMonth.Month, 1);
                DateTime endDate = startDate.AddMonths(1);

                var dailyTotals = context.Receipts
                    .Where(r => r.UserID == SelectedUser.UserID && r.ReleseDate >= startDate && r.ReleseDate < endDate)
                    .GroupBy(r => r.ReleseDate.Date)
                    .Select(g => new DailyTotal
                    {
                        Day = g.Key,
                        Total = g.Sum(r => r.Total)
                    })
                    .OrderBy(g => g.Day)
                    .ToList();

                dailyTotals.ForEach(d=>DailyTotals.Add(d));
            }
        }
    }
    public class DailyTotal
    {
        public DateTime Day { get; set; }
        public float Total {  get; set; }
    }
}
