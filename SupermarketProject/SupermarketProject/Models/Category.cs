using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models
{
    public class Category
    {

        [Key]
        public int CategoryID { get; set; }

        [MaxLength(50), Required] 
        public string Name;

        public Category() {
            Name = "";
        }
      
    }
}
