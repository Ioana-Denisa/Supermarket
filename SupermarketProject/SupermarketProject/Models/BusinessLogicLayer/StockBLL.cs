using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models.BusinessLogicLayer
{
    public class StockBLL
    {
        private SupermarketDBContext _context = new SupermarketDBContext();
        public ObservableCollection<Stock> StocksList { get; set; }

        public StockBLL(SupermarketDBContext context)
        {
            _context = context;
        }

        public string ErrorMessage { get; set; }
        public void Add(object obj)
        {
            Stock stock = obj as Stock;
            if (_context.Stocks.FirstOrDefault(u => u.ExpirationDate == stock.ExpirationDate && u.SupplyDate== stock.SupplyDate && u.PurchasePrice== stock.PurchasePrice && u.SellingPrice==stock.SellingPrice && u.Unit==stock.Unit && u.Quantity==stock.Quantity && u.Product==stock.Product) != null)
                ErrorMessage = "Datele acestea deja exista, alegeti altele!";
            else
            {
                if (stock.Product==null)
                {
                    ErrorMessage = "Alege un produs!";
                }
                else if (string.IsNullOrEmpty(stock.Unit))
                {
                    ErrorMessage = "Unitatea de masura trebuie precizata!";
                }
                else if (stock.ExpirationDate==null)
                {
                    ErrorMessage = "Data de expirare trebuie precizata!";
                }
                else if (stock.SupplyDate == null)
                {
                    ErrorMessage = "Data de achizitie trebuie precizata!";
                }
                else
                {
                    _context.Stocks.Add(stock);
                    _context.SaveChanges();
                    stock.StockID = _context.Stocks.Max(item => item.StockID);
                    StocksList.Add(stock);
                    ErrorMessage = "";
                }
            }
        }

        public Stock GetById(int id)
        {
            return _context.Stocks.Find(id);
        }

        public ObservableCollection<Stock> GetAll()
        {
            List<Stock> stock = _context.Stocks.ToList();
            ObservableCollection<Stock> result = new ObservableCollection<Stock>();
            foreach (Stock s in stock)
            {
                result.Add(s);
            }
            if (result.Count == 0)
                return null;
            return result;
        }

        public void Update(object obj)
        {
            Stock s = obj as Stock;
            if (s == null)
                ErrorMessage = "Selecteaza un stock!";
            else if (string.IsNullOrEmpty(s.Unit))
                ErrorMessage = "Unitatea de masura trebuie precizata!";
            else if (s.ExpirationDate == null)
            {
                ErrorMessage = "Data de expirare trebuie precizata!";
            }
            else if (s.SupplyDate == null)
            {
                ErrorMessage = "Data de achizitie trebuie precizata!";
            }
            else
            {
                _context.Entry(s).State = EntityState.Modified;
                _context.SaveChanges();
            }

        }

        public void Delete(object obj)
        {
            Stock s = obj as Stock;
            if (s == null)
            {
                ErrorMessage = "Selecteaza un stock";
            }
            else
            {
                Stock p = _context.Stocks.Where(i => i.StockID == s.StockID).FirstOrDefault();

                _context.Remove(p);
                _context.SaveChanges();
                StocksList.Remove(s);
                ErrorMessage = "";
            }
        }
    }
}
