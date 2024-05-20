using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models.BusinessLogicLayer
{
    public class ReceiptBLL
    {
        private SupermarketDBContext _context = new SupermarketDBContext();

        public ObservableCollection<Receipt> ReceiptList { get; set; }

        public ReceiptBLL(SupermarketDBContext context)
        {
            _context = context;
        }

        public string ErrorMessage { get; set; }
        //public void Add(object obj)
        //{
        //    Receipt receipt = obj as Receipt;
        //    if (_context.Receipts.FirstOrDefault(u => u.ReceiptProducts == receipt.ReceiptProducts && u.Total== receipt.Total&& u.ReleseDate == receipt.ReleseDate && u.Cashier==receipt.Cashier) != null)
        //        ErrorMessage = "Datele acestea deja exista, alegeti altele!";
        //    else if (receipt != null)
        //    {
        //        if (string.IsNullOrEmpty(receipt.Cashier.Name))
        //        {
        //            ErrorMessage = "Numele trebuie precizat!";
        //        }
        //        else if (receipt.ReceiptProducts==null))
        //        {
        //            ErrorMessage = "Data trebuie precizata!";
        //        }
        //        else if (string.IsNullOrEmpty(receipt.Total.ToString)
        //        {
        //            ErrorMessage = "Data trebuie precizata!";
        //        }
        //        else
        //        {
        //            _context.Users.Add(receipt);
        //            _context.SaveChanges();
        //            receipt.UserID = _context.Users.Max(item => item.UserID);
        //            ReceiptList.Add(receipt);
        //            ErrorMessage = "";
        //        }
        //    }
        //}

        //public User GetById(int id)
        //{
        //    return _context.Users.Find(id);
        //}

        //public ObservableCollection<User> GetAll()
        //{
        //    List<User> users = _context.Users.FromSqlRaw("GetAllUsers").ToList();
        //    ObservableCollection<User> result = new ObservableCollection<User>();
        //    foreach (User user in users)
        //    {
        //        result.Add(user);
        //    }
        //    if (result.Count == 0)
        //        return null;
        //    return result;
        //}

        //public void Update(object obj)
        //{
        //    User user = obj as User;
        //    if (user == null)
        //        ErrorMessage = "Selecteaza un user!";
        //    else if (string.IsNullOrEmpty(user.Name))
        //        ErrorMessage = "Numele trebuie precizat!";
        //    else if (string.IsNullOrEmpty(user.Password))
        //        ErrorMessage = "Parola trebuie precizata!";
        //    else
        //    {
        //        _context.Entry(user).State = EntityState.Modified;
        //        _context.SaveChanges();
        //    }

        //}

        //public void Delete(object obj)
        //{
        //    User user = obj as User;
        //    if (user == null)
        //    {
        //        ErrorMessage = "Selecteaza un user";
        //    }
        //    else
        //    {
        //        User p = _context.Users.Where(i => i.UserID == user.UserID).FirstOrDefault();

        //        _context.Remove(p);
        //        _context.SaveChanges();
        //        ReceiptList.Remove(user);
        //        ErrorMessage = "";
        //    }
        //}
    }
}
