using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models
{
    public class CategoryTotalPrice
    {
        [Key]
        public string CategoryName { get; set; }
        public float Total { get; set; }
        public CategoryTotalPrice(string categoryName, float total)
        {
            CategoryName = categoryName;
            Total = total;
        }   
    }
}
