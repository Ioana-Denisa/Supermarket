using System;
using System.Collections.Generic;

namespace Supermarket.Models
{
    public partial class Producers
    {
        public Producers()
        {
            Products = new HashSet<Products>();
        }

        public int IdProducer { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
