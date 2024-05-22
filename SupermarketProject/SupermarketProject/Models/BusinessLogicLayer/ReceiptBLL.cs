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
        public void Add(object obj)
        {
            Receipt r = obj as Receipt;

            if (_context.Receipts.FirstOrDefault(u => u.ReceipID == r.ReceipID && u.UserID == r.UserID && u.ReleseDate == r.ReleseDate && u.Total == r.Total)!=null)
            {
                ErrorMessage = "Datele acestea deja există, alegeți altele!";
            }
            else
            {
                if (r.ReceipID == null)
                {
                    ErrorMessage = "ID-ul bonului trebuie specificat!";
                }
                else if (r.UserID == null)
                {
                    ErrorMessage = "ID-ul user-ului trebuie specificat!";
                }
                else if (r.ReleseDate == null)
                {
                    ErrorMessage = "Data trebuie specificată!";
                }
                else
                {
                    r.Total = GetSubtotal(r);
                    _context.Receipts.Add(r);
                    _context.SaveChanges();
                    r.ReceipID = _context.Receipts.Max(item => item.ReceipID);
                    ReceiptList.Add(r);
                    ErrorMessage = "";
                }
            }
        }

        public float GetSubtotal(Receipt r)
        {
            float total = 0;
            List<ReceiptProducts> recept =r.ReceiptItems.ToList();
            foreach(var re in recept)
            {
                total += re.Subtotal;
            }
            return total;
        }
        public Receipt GetById(int id)
        {
            Receipt s = _context.Receipts.Find(id);
            return s;
        }

        public ObservableCollection<Receipt> GetAll()
        {
            List<Receipt> receipt = _context.Receipts.ToList();
            ObservableCollection<Receipt> result = new ObservableCollection<Receipt>();
            foreach (Receipt s in receipt)
            {
                result.Add(s);
            }
            if (result.Count == 0)
                return null;
            return result;
        }

        //public void Update(object obj)
        //{
        //    ReceiptProducts s = obj as ReceiptProducts;
        //    if (s == null)
        //        ErrorMessage = "Selecteaza un bon!";
        //    else if (s.ReceiptID==null)
        //        ErrorMessage = "ID-ul bonului trebuie precizat!";
        //    else if (s.ProductID == null)
        //    {
        //        ErrorMessage = "ID-ul produsului trebuie precizat!";
        //    }
        //    else if (s.Quantity == null)
        //    {
        //        ErrorMessage = "Cantitatea trebuie precizata!";
        //    }
        //    else
        //    {
        //        _context.Entry(s).State = EntityState.Modified;
        //        _context.SaveChanges();
        //    }

        //}

        public void Sell(object obj)
        {
            Receipt s = obj as Receipt;
            if (s == null)
            {
                ErrorMessage = "Selecteaza un bon";
            }
            else
            {
                Receipt p = _context.Receipts.Where(i => i.ReceipID == s.ReceipID).FirstOrDefault();
                _context.SaveChanges();

                ErrorMessage = "";
            }
        }
    }
}
