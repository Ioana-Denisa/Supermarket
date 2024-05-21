using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models
{
    public class ReceiptProducts
    {
        [Key]
        public int ReceiptProductsID {  get; set; }
        public int ReceiptID {  get; set; }
        public int ProductID {  get; set; }
      
        [Required]
        public int Quantity {  get; set; }
       
        [Required]
        public float Subtotal {  get; set; }
        public virtual Receipt Receipt {  get; set; }
        public virtual Product Product {  get; set; }
    }
}
