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
        public Category Category {  get; set; }
        public Producer Producer {  get; set; }
        public ICollection<Stock> Stocks {  get; set; }

        [Required]

        public bool IsActive {  get; set; }
        public Product()
        {
            Name = "";
            Barcode = "";
            Stocks= new HashSet<Stock>();
            IsActive = true;
        }

    }
}
