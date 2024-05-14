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

        [ForeignKey("Category")]
        public int CategoryID {  get; set; }

        [ForeignKey("Producer")]

        public int ProducerID {  get; set; }


        [Required]
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
