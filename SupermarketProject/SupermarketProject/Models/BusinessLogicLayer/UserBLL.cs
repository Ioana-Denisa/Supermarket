using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models.BusinessLogicLayer
{
    public class UserBLL
    {
        private SupermarketDBContext _context = new SupermarketDBContext();
        public ObservableCollection<User> UsersList { get; set; }

        public UserBLL(SupermarketDBContext context)
        {
            _context = context;
        }

        public string ErrorMessage { get; set; }
        public void Add(object obj)
        {
            User user = obj as User;
            if (_context.Users.FirstOrDefault(u => u.Name == user.Name && u.Password == user.Password && u.Type==user.Type)!=null)
                ErrorMessage = "Datele acestea deja exista, alegeti altele!";
            else if (user != null)
            {
                if (string.IsNullOrEmpty(user.Name))
                {
                    ErrorMessage = "Numele trebuie precizat!";
                }
                else if (string.IsNullOrEmpty(user.Password))
                {
                    ErrorMessage = "Parola trebuie precizata!";
                }
                else
                {
                    user.IsActive = true;
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    user.UserID = _context.Users.Max(item => item.UserID);
                    UsersList.Add(user);
                    ErrorMessage = "";
                }
            }
        }

        public User GetById(int id)
        {
            var u= _context.Users.Find(id);
            if (u != null && u.IsActive)
                return u;else return null;
        }

        public ObservableCollection<User> GetAll()
        {
            List<User> users = _context.Users.FromSqlRaw("GetAllUsers").ToList();
            ObservableCollection<User> result = new ObservableCollection<User>();
            foreach (User user in users)
            {
                if (user.IsActive)
                    result.Add(user);
            }
            if (result.Count == 0)
                return null;
            return result;
        }

        public void Update(object obj)
        {
            User user = obj as User;
            if (user == null)
                ErrorMessage = "Selecteaza un user!";
            else if (string.IsNullOrEmpty(user.Name))
                ErrorMessage = "Numele trebuie precizat!";
            else if (string.IsNullOrEmpty(user.Password))
                ErrorMessage = "Parola trebuie precizata!";
            else
            {
                _context.Entry(user).State = EntityState.Modified;
                _context.SaveChanges();
            }

        }

        public void Delete(object obj)
        {
            User user = obj as User;
            if (user == null)
            {
                ErrorMessage = "Selecteaza un user";
            }
            else
            {
                User p = _context.Users.Where(i => i.UserID == user.UserID).FirstOrDefault();
                p.IsActive=false;
                _context.SaveChanges();
                User inList = UsersList.FirstOrDefault(i => i.UserID == p.UserID);
                if (inList != null)
                {
                    inList.IsActive = false;
                }
                ErrorMessage = "";
            }
        }

        public User Authenticate(string username, string password)
        {
            return _context.Users.FirstOrDefault(u => u.Name == username && u.Password == password);
        }
    }


}
