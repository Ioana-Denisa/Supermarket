using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models    
{   
    public class Offer
    {
        [Key]
        public int OfferID {  get; set; }
        [Required]
        public string Reason {  get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        [Required]
        public decimal DiscountPercentage {  get; set; }
        [Required]
        public DateTime ValidFrom { get; set; }
        [Required]
        public DateTime ValidUntil { get; set; }

        public Offer()
        {
            Reason = "";
            DiscountPercentage = 10;

        }
    }
}
