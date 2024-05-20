using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models.BusinessLogicLayer
{
    public class CategoryBLL
    {
        private SupermarketDBContext _context = new SupermarketDBContext();
        public ObservableCollection<Category> CategoryList { get; set; }

        public CategoryBLL(SupermarketDBContext context)
        {
            _context = context;

        }

        public string ErrorMessage { get; set; }
        public void Add(object obj)
        {
            Category category = obj as Category;
            if (_context.Categories.FirstOrDefault(u => u.Name == category.Name ) != null)
                ErrorMessage = "Datele acestea deja exista, alegeti altele!";
            else if (category != null)
            {
                if (string.IsNullOrEmpty(category.Name))
                {
                    ErrorMessage = "Numele categoriei trebuie precizat!";
                }
                else
                {
                    _context.Categories.Add(category);
                    _context.SaveChanges();
                    category.CategoryID = _context.Categories.Max(item => item.CategoryID);
                    CategoryList.Add(category);
                    ErrorMessage = "";
                }
            }
        }

        public Category GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public ObservableCollection<Category> GetAll()
        {
            List<Category> category = _context.Categories.FromSqlRaw("GetAllCategories").ToList();
            ObservableCollection<Category> result = new ObservableCollection<Category>();
            foreach (Category cat in category)
            {
                result.Add(cat);
            }
            if (result.Count == 0)
                return null;
            return result;
        }

        public void Update(object obj)
        {
            Category category = obj as Category;
            if (category == null)
                ErrorMessage = "Selecteaza o categorie!";
            else if (string.IsNullOrEmpty(category.Name))
                ErrorMessage = "Numele categoriei trebuie precizata!";
            else
            {
                _context.Entry(category).State = EntityState.Modified;
                _context.SaveChanges();
            }

        }

        public void Delete(object obj)
        {
            Category category = obj as Category;
            if (category == null)
            {
                ErrorMessage = "Selecteaza o categorie";
            }
            else
            {
                Category p = _context.Categories.Where(i => i.CategoryID == category.CategoryID).FirstOrDefault();

                _context.Remove(p);
                _context.SaveChanges();
                CategoryList.Remove(category);
                ErrorMessage = "";
            }
        }


    }

}

