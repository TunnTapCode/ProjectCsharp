using System;
using System.Collections.Generic;

namespace Project_PRN21.Models
{
    public partial class PublisherSale
    {
        public int SaleId { get; set; }
        public int PublisherId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public DateTime SaleDate { get; set; }

        public virtual Book Book { get; set; } = null!;
        public virtual Publisher Publisher { get; set; } = null!;
    }
}
