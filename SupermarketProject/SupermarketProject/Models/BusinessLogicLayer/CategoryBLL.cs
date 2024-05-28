using Microsoft.EntityFrameworkCore;
using SupermarketProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketProject.Models.BusinessLogicLayer
{
    public class CategoryBLL
    {
        private SupermarketDBContext _context = new SupermarketDBContext();
        public ObservableCollection<Category> CategoryList { get; set; }

        public CategoryBLL(SupermarketDBContext context)
        {
            _context = context;
            CategoryList = new ObservableCollection<Category>();
        }

        public string ErrorMessage { get; set; }
        public void Add(object obj)
        {
            Category category = obj as Category;
            if (_context.Categories.FirstOrDefault(u => u.Name == category.Name) != null)
                ErrorMessage = "Datele acestea deja exista, alegeti altele!";
            else if (category != null)
            {
                if (string.IsNullOrEmpty(category.Name))
                {
                    ErrorMessage = "Numele categoriei trebuie precizat!";
                }
                else
                {
                    _context.Database.ExecuteSqlRaw("CreateCategories @p0", parameters: new object[] { category.Name });
                    category.CategoryID = _context.Categories.Max(item => item.CategoryID);
                    CategoryList.Add(category);
                    ErrorMessage = "";
                }
            }
        }

        public Category GetById(int id)
        {
            Category cat = _context.Categories.Find(id);
            if (cat != null && cat.IsActive == true)
                return cat;
            return null;
        }

        public ObservableCollection<Category> GetAll()
        {
            List<Category> category = _context.Categories.FromSqlRaw("GetAllCategories").ToList();
            ObservableCollection<Category> result = new ObservableCollection<Category>();
            foreach (Category cat in category)
            {
                if (cat.IsActive == true)
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
                _context.Database.ExecuteSqlRaw("UpdateCategory @p0,@p1", parameters: new object[] { category.Name, category.CategoryID });
            }

        }

        public void Delete(object obj)
        {
            Category category = obj as Category;
            if (category == null)
            {
                ErrorMessage = "Selecteaza o categorie";
            }
            else if (_context.Stocks
        .Any(s => s.Product.CategoryID == category.CategoryID))
            {
                ErrorMessage = "Exista produse in stoc care fac parte din aceasta categorie!";
            }
            else
            {
                _context.Database.ExecuteSqlRaw("DeleteCategory @p0", parameters: new object[] { category.CategoryID });
                Category categoryInList = CategoryList.FirstOrDefault(i => i.CategoryID == category.CategoryID);
                if (categoryInList != null)
                {
                    categoryInList.IsActive = false;
                }
                ErrorMessage = "";
            }
        }


    }

}

