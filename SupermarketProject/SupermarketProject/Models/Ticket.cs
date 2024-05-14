using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models
{
    public class Ticket
    {
        [Key]
        public int TicketID {  get; set; }
        
        [Required]
        public DateTime ReleseDate {  get; set; }
        
        [ForeignKey("Cashier")]
        public int CashierID {  get; set; }
       
        [Required]
        public decimal Total {  get; set; }
        public Ticket()
        {
            Total = 0;
        }
       
    }
}
