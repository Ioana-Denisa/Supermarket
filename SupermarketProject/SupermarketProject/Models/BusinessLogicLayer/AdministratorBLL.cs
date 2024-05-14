using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models.BusinessLogicLayer
{
    public class AdministratorBLL
    {
        private SupermarketDBContext _context = new SupermarketDBContext();

        public AdministratorBLL(SupermarketDBContext context)
        {
            _context = context;
        }
        
        #region User commands
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User GetUserById(int id)
        {
            return _context.Users.Find(id);
        }

        public IEnumerable<User> GetAllUser()
        {
            return _context.Users.ToList();
        }

        public void UpdateUser(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.SaveChanges();
            }
        }
        #endregion

        #region Category commands

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            _context.Entry(category).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
            {
                _context.SaveChanges();
            }
        }
        #endregion

        #region Producer commands

        public void AddProducer(Producer producer)
        {
            _context.Producers.Add(producer);
            _context.SaveChanges();
        }

        public Producer GetProducerById(int id)
        {
            return _context.Producers.Find(id);
        }

        public IEnumerable<Producer> GetAllProducers()
        {
            return _context.Producers.ToList();
        }

        public void UpdateProducer(Producer p)
        {
            _context.Entry(p).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteProducer(int id)
        {
            var p = _context.Producers.Find(id);
            if (p != null)
            {
                _context.SaveChanges();
            }
        }
        #endregion

        #region Product commands

        public void AddProduct(Product p)
        {
            _context.Products.Add(p);
            _context.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public void UpdateProduct(Product p)
        {
            _context.Entry(p).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var p = _context.Products.Find(id);
            if (p != null)
            {
                _context.SaveChanges();
            }
        }
        #endregion

        #region Ticket commands

        public void AddTicket(TicketProducts t)
        {
            _context.TicketProducts.Add(t);
            _context.SaveChanges();
        }

        public TicketProducts GetTicketById(int id)
        {
            return _context.TicketProducts.Find(id);
        }

        public IEnumerable<TicketProducts> GetAllTickets()
        {
            return _context.TicketProducts.ToList();
        }

        public void UpdateTicket(TicketProducts t)
        {
            _context.Entry(t).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteTicket(int id)
        {
            var t = _context.TicketProducts.Find(id);
            if (t != null)
            {
                _context.SaveChanges();
            }
        }
        #endregion

        #region Stock commands

        public void AddStock(Stock s)
        {
            _context.Stocks.Add(s);
            _context.SaveChanges();
        }

        public Stock GetStockById(int id)
        {
            return _context.Stocks.Find(id);
        }

        public IEnumerable<Stock> GetAllStock()
        {
            return _context.Stocks.ToList();
        }

        public void UpdateStock(Stock t)
        {
            _context.Entry(t).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteStock(int id)
        {
            var s = _context.Stocks.Find(id);
            if (s != null)
            {
                _context.SaveChanges();
            }
        }
        #endregion
    }
}
