using System;
using System.Collections.Generic;

namespace Supermarket.Models
{
    public partial class Users
    {
        public Users()
        {
            Tickets = new HashSet<Tickets>();
        }

        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
