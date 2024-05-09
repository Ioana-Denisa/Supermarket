using System;
using System.Collections.Generic;

namespace Supermarket.Models
{
    public partial class TicketProducts
    {
        public int IdTicket { get; set; }
        public int IdProduct { get; set; }
        public int? Quantity { get; set; }
        public decimal? Subtotal { get; set; }

        public virtual Products IdProductNavigation { get; set; }
        public virtual Tickets IdTicketNavigation { get; set; }
    }
}
