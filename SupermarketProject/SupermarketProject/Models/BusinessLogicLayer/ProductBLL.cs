using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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
            if (_context.Products.FirstOrDefault(p => p.Name == product.Name && p.Barcode == product.Barcode && p.CategoryID==product.CategoryID && p.ProducerID==product.ProducerID && p.IsActive==product.IsActive ) != null)
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
                else if (product.CategoryID==null)
                {
                    ErrorMessage = "ID-ul categoriei trebuie precizat!";
                }
                else if (product.ProducerID==null)
                {
                    ErrorMessage = "ID-ul producatorului trebuie precizat!";
                }
                else
                {
                    product.IsActive = true;
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
            Product prod= _context.Products.Find(id);
            if (prod != null && prod.IsActive == true)
                return prod;
            return null;
        }

        public ObservableCollection<Product> GetAll()
        {
            List<Product> product = _context.Products.ToList();
            ObservableCollection<Product> result = new ObservableCollection<Product>();
            foreach (Product prod in product)
            {
                if(prod.IsActive == true)
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
                ErrorMessage = "ID-ul producatorul trebuie precizat!";
            else if (string.IsNullOrEmpty(product.Producer.Name))
                ErrorMessage = "ID-ul categoriei trebuie precizat!";
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
                p.IsActive = false;
                _context.SaveChanges();
                Product prodInList = ProductsList.FirstOrDefault(i => i.ProductID == p.ProductID);
                if (prodInList != null)
                {
                    prodInList.IsActive = p.IsActive;
                }
                ErrorMessage = "";
            }
        }
    }
}
