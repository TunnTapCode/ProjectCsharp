using System;
using System.Collections.Generic;

namespace Project_PRN21.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            PublisherSales = new HashSet<PublisherSale>();
        }

        public int PublisherId { get; set; }
        public string PublisherName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;

        public virtual ICollection<PublisherSale> PublisherSales { get; set; }
    }
}
