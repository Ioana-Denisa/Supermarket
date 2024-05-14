using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models
{
    public class StatusProduct
    {
        [Key]
        public int StatusID {  get; set; }
        
        [Required]
        public string Name {  get; set; }
        public StatusProduct()
        {
            Name = "";
        }
       
    }
}
