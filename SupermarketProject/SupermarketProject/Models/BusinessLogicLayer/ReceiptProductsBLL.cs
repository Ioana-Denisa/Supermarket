using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models.BusinessLogicLayer
{
    public class ReceiptProductsBLL
    {
        private SupermarketDBContext _context = new SupermarketDBContext();
        public ObservableCollection<ReceiptProducts> ReceiptProductsList { get; set; }

        public ReceiptProductsBLL(SupermarketDBContext context)
        {
            _context = context;
        }

        public string ErrorMessage { get; set; }
        public void Add(object obj)
        {
            ReceiptProducts r = obj as ReceiptProducts;

            if (_context.ReceiptProducts.FirstOrDefault(u => u.ReceiptProductsID == r.ReceiptProductsID && u.ReceiptID == r.ReceiptID && u.ProductID == r.ProductID && u.Quantity == r.Quantity && u.Subtotal == r.Subtotal) != null)
            {
                ErrorMessage = "Datele acestea deja există, alegeți altele!";
            }
            else
            {
                if (r.ReceiptID == null)
                {
                    ErrorMessage = "ID-ul bonului trebuie specificat!";
                }
                else if (r.ProductID == null)
                {
                    ErrorMessage = "ID-ul produsului trebuie specificat!";
                }
                else if (r.Quantity == null)
                {
                    ErrorMessage = "Cantitatea trebuie specificată!";
                }
                else
                {
                    r.Subtotal = GetSubtotal(r);
                    _context.ReceiptProducts.Add(r);
                    _context.SaveChanges();
                    r.ReceiptProductsID = _context.ReceiptProducts.Max(item => item.ReceiptProductsID);
                    ReceiptProductsList.Add(r);
                    ErrorMessage = "";
                }
            }
        }

        public float GetSubtotal(ReceiptProducts r)
        {
            Stock stock = _context.Stocks.Where(p => p.ProductID == r.ProductID).FirstOrDefault();
            float subTotal = r.Quantity * stock.SellingPrice;
            return subTotal;
        }
        public ReceiptProducts GetById(int id)
        {
            ReceiptProducts s = _context.ReceiptProducts.Find(id);
            return s;
        }

        public ObservableCollection<ReceiptProducts> GetAll()
        {
            List<ReceiptProducts> receipt = _context.ReceiptProducts.ToList();
            ObservableCollection<ReceiptProducts> result = new ObservableCollection<ReceiptProducts>();
            foreach (ReceiptProducts s in receipt)
            {
                result.Add(s);
            }
            if (result.Count == 0)
                return null;
            return result;
        }


        public void Sell(object obj)
        {
            ReceiptProducts s = obj as ReceiptProducts;
            if (s == null)
            {
                ErrorMessage = "Selecteaza un bon";
            }
            else
            {
                ReceiptProducts p = _context.ReceiptProducts.Where(i => i.ReceiptProductsID == s.ReceiptProductsID).FirstOrDefault();
                Stock st = _context.Stocks.Where(x => x.ProductID == s.ProductID).FirstOrDefault();
                if (p != null && st != null && p.ProductID == s.ProductID)
                    st.Quantity -= s.Quantity;
                if (st.Quantity == 0)
                    st.IsActiv = false;
                _context.SaveChanges();

                ErrorMessage = "";
            }
        }
    }
}

