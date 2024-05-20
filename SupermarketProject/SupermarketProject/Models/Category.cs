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
        [Required]
        public string Name { get; set; }

        public Category() {
            Name = "";
        }
      
    }
}
