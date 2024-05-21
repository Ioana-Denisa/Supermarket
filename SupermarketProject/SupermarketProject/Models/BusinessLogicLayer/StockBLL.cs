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
        public ObservableCollection<Stock> StockList { get; set; }
        private const float adaosComercial = 0.25f;

        public StockBLL(SupermarketDBContext context)
        {
            _context = context;
        }

        public string ErrorMessage { get; set; }

        public float GetSellingPrice(Stock stock)
        {
            float adaos = stock.PurchasePrice * adaosComercial;
            return adaos + stock.PurchasePrice;
        }
        public void Add(object obj)
        {
            Stock stock = obj as Stock;

            if (stock == null)
            {
                ErrorMessage = "Obiectul adăugat este nul.";
                return;
            }

            if (_context.Stocks.Any(u => u.ExpirationDate == stock.ExpirationDate && u.SupplyDate == stock.SupplyDate && u.PurchasePrice == stock.PurchasePrice && u.Unit == stock.Unit && u.Quantity == stock.Quantity && u.ProductID == stock.ProductID))
            {
                ErrorMessage = "Datele acestea deja există, alegeți altele!";
            }
            else
            {
                if (string.IsNullOrEmpty(stock.Unit))
                {
                    ErrorMessage = "Unitatea de măsură trebuie specificată!";
                }
                else if (stock.ExpirationDate == null)
                {
                    ErrorMessage = "Data de expirare trebuie specificată!";
                }
                else if (stock.SupplyDate == null)
                {
                    ErrorMessage = "Data de achiziție trebuie specificată!";
                }
                else if (stock.PurchasePrice == null)
                {
                    ErrorMessage = "Prețul de achiziție trebuie specificat!";
                }
                else
                {
                    stock.SellingPrice = GetSellingPrice(stock);
                    stock.IsActiv = true;
                    _context.Stocks.Add(stock);
                    _context.SaveChanges();
                    stock.StockID = _context.Stocks.Max(item => item.StockID);
                    StockList.Add(stock);
                    ErrorMessage = "";
                }
            }
        }

        public Stock GetById(int id)
        {
            Stock s = _context.Stocks.Find(id);
            if (s != null && s.IsActiv == true)
                return s;
            return null;
        }

        public ObservableCollection<Stock> GetAll()
        {
            List<Stock> stock = _context.Stocks.ToList();
            ObservableCollection<Stock> result = new ObservableCollection<Stock>();
            foreach (Stock s in stock)
            {
                if(s.IsActiv)
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
                p.IsActiv = false;
                _context.SaveChanges();
                Stock inList = StockList.FirstOrDefault(i => i.StockID == p.StockID);
                if (inList != null)
                {
                    inList.IsActiv = false;
                }
                ErrorMessage = "";
            }
        }
    }
}
