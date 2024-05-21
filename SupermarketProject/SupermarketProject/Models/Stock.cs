using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject.Models
{
    public class Stock
    {
        [Key]
        public int StockID { get; set; }
        public int ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string Unit { get; set; }

        [Required]
        public DateTime SupplyDate { get; set; }

        [Required]

        public DateTime ExpirationDate { get; set; }

        [Required]

        public float PurchasePrice { get; set; }

        [Required]

        public float SellingPrice { get; set; }
        public bool IsActiv {  get; set; }
        public virtual Product Product {  get; set; }
       

    }
}
