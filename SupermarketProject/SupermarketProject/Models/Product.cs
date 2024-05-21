using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models
{
    public class Product
    {
        [Key]
        public int ProductID {  get; set; }
        [Required]
        public string Name {  get; set; }
        [Required]
        public string Barcode {  get; set; }
        public int CategoryID {  get; set; }
        public int ProducerID { get; set; } 
        [Required]
        public bool IsActive {  get; set; }
        public virtual Category Category {  get; set; }
        public virtual Producer Producer {  get; set; }

    }
}
