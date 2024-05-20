using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models.BusinessLogicLayer
{
    public class ProductBLL
    {
        private SupermarketDBContext _context = new SupermarketDBContext();
        public ObservableCollection<Product> ProductsList { get; set; }

        public ProductBLL(SupermarketDBContext context)
        {
            _context = context;
        }

        public string ErrorMessage { get; set; }
        public void Add(object obj)
        {
            Product product = obj as Product;
            if (_context.Products.FirstOrDefault(p => p.Name == product.Name && p.Barcode == product.Barcode && p.Category==product.Category && p.Producer==product.Producer && p.Stocks==product.Stocks) != null)
                ErrorMessage = "Datele acestea deja exista, alegeti altele!";
            else if (product != null)
            {
                if (string.IsNullOrEmpty(product.Name))
                {
                    ErrorMessage = "Numele trebuie precizat!";
                }
                else if (string.IsNullOrEmpty(product.Barcode))
                {
                    ErrorMessage = "Codul de bare trebuie precizat!";
                }
                else if (string.IsNullOrEmpty(product.Category.Name))
                {
                    ErrorMessage = "Categoria trebuie precizata!";
                }
                else if (string.IsNullOrEmpty(product.Producer.Name))
                {
                    ErrorMessage = "Numele producatorului trebuie precizat!";
                }
                else if (string.IsNullOrEmpty(product.Stocks.ToString()))
                {
                    ErrorMessage = "Stocul trebuie precizat!";
                }
                else
                {
                    _context.Products.Add(product);
                    _context.SaveChanges();
                    product.ProductID = _context.Products.Max(item => item.ProductID);
                    ProductsList.Add(product);
                    ErrorMessage = "";
                }
            }
        }

        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public ObservableCollection<Product> GetAll()
        {
            List<Product> product = _context.Products.ToList();
            ObservableCollection<Product> result = new ObservableCollection<Product>();
            foreach (Product prod in product)
            {
                result.Add(prod);
            }
            if (result.Count == 0)
                return null;
            return result;
        }

        public void Update(object obj)
        {
            Product product = obj as Product;
            if (product == null)
                ErrorMessage = "Selecteaza un produs!";
            else if (string.IsNullOrEmpty(product.Name))
                ErrorMessage = "Numele trebuie precizat!";
            else if (string.IsNullOrEmpty(product.Barcode))
                ErrorMessage = "Codul de bare trebuie precizat!";
            else if (string.IsNullOrEmpty(product.Producer.Name))
                ErrorMessage = "Producatorul trebuie precizat!";
            else if (string.IsNullOrEmpty(product.Producer.Name))
                ErrorMessage = "Categoria trebuie precizata!";
            else if (string.IsNullOrEmpty(product.Stocks.ToString()))
                ErrorMessage = "Stocul trebuie precizat!";
            else
            {
                _context.Entry(product).State = EntityState.Modified;
                _context.SaveChanges();
            }

        }

        public void Delete(object obj)
        {
            Product product = obj as Product;
            if (product == null)
            {
                ErrorMessage = "Selecteaza un produs";
            }
            else
            {
                Product p = _context.Products.Where(i => i.ProductID== product.ProductID).FirstOrDefault();

                _context.Remove(p);
                _context.SaveChanges();
                ProductsList.Remove(product);
                ErrorMessage = "";
            }
        }
    }
}
