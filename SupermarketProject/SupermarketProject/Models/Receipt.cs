using SupermarketProject.Views.Cashier;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models
{
    public class Receipt
    {
        [Key]
        public int ReceipID {  get; set; }
        public ICollection<ReceiptProducts> ReceiptProducts { get; set; }
        [Required]
        public DateTime ReleseDate {  get; set; }
        public User Cashier {  get; set; }
        [Required]
        public float Total {  get; set; }
       
    }
}
