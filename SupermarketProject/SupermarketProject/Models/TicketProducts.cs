using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models
{
    public class TicketProducts
    {
       
        [ForeignKey("Ticket")]
        [Key]
        public int TicketID {  get; set; }
       
        [ForeignKey("Product")]
        [Key]
        public int ProductID {  get; set; }
      
        [Required]
        public int Quantity {  get; set; }
       
        [Required]
        public decimal Subtotal {  get; set; }


       
    }
}
