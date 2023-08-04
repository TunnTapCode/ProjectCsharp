using System;
using System.Collections.Generic;

namespace Project_PRN21.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? Username { get; set; }

        public virtual Account? UsernameNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
