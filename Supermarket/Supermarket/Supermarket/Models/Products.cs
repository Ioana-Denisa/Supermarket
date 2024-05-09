using System;
using System.Collections.Generic;

namespace Supermarket.Models
{
    public partial class Products
    {
        public Products()
        {
            Stocks = new HashSet<Stocks>();
            TicketProducts = new HashSet<TicketProducts>();
        }

        public int IdProduct { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public int IdCategory { get; set; }
        public int IdProducer { get; set; }

        public virtual Categories IdCategoryNavigation { get; set; }
        public virtual Producers IdProducerNavigation { get; set; }
        public virtual ICollection<Stocks> Stocks { get; set; }
        public virtual ICollection<TicketProducts> TicketProducts { get; set; }
    }
}
