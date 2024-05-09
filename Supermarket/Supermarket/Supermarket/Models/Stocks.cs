using System;
using System.Collections.Generic;

namespace Supermarket.Models
{
    public partial class Stocks
    {
        public int IdStock { get; set; }
        public int IdProduct { get; set; }
        public int? Quantity { get; set; }
        public string Unit { get; set; }
        public DateTime? SupplyDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? SellingPrice { get; set; }

        public virtual Products IdProductNavigation { get; set; }
    }
}
