using System;
using System.Collections.Generic;

namespace Supermarket.Models
{
    public partial class Tickets
    {
        public Tickets()
        {
            TicketProducts = new HashSet<TicketProducts>();
        }

        public int IdTicket { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int IdCashier { get; set; }
        public decimal? Total { get; set; }

        public virtual Users IdCashierNavigation { get; set; }
        public virtual ICollection<TicketProducts> TicketProducts { get; set; }
    }
}
