using System;
using System.Collections.Generic;

namespace Project_PRN21.Models
{
    public partial class Account
    {
        public Account()
        {
            Customers = new HashSet<Customer>();
        }

        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
