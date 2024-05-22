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
        
        public ObservableCollection<Product> ProductsList { get; set; }

        public StockBLL(SupermarketDBContext context)
        {
            _context = context;
            StockList = GetAll();
            ProductsList = GetAllProducts();
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
            if (_context.Stocks.FirstOrDefault(u => u.ExpirationDate == stock.ExpirationDate && u.SupplyDate == stock.SupplyDate && u.PurchasePrice == stock.PurchasePrice && u.Unit == stock.Unit && u.Quantity == stock.Quantity && u.ProductID == stock.ProductID) !=null)
                 ErrorMessage = "Datele acestea deja există, alegeți altele!";
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
                    Product p = _context.Products.Where(o => stock.ProductID == o.ProductID).FirstOrDefault();
                    if (p != null)
                        stock.Product = p;
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
                {
                    Product p = _context.Products.Where(o => s.ProductID == o.ProductID).FirstOrDefault();
                    if (p != null)
                        s.Product = p;
                    result.Add(s);
                }
            }
            if (result.Count == 0)
                return null;
            return result;
        }

        public ObservableCollection<Product> GetAllProducts()
        {
            List<Product> prod = _context.Products.ToList();
            ObservableCollection<Product> result = new ObservableCollection<Product>();
            foreach (Product p in prod)
            {
                if (p.IsActive)
                {
                    result.Add(p);
                }
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
            else if (s.SellingPrice == null)
            {
                ErrorMessage = "Precizati noul pret de vanzare!";
            }
            else
            {
                if (s.SellingPrice <= s.PurchasePrice)
                    ErrorMessage = "Pretul de vanzare trebuie sa fie mai mare decat pretul de cumparare!";
                else
                {
                    _context.Entry(s).State = EntityState.Modified;
                    _context.SaveChanges();
                }
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
