using System;
using System.Collections.Generic;

namespace Project_PRN21.Models
{
    public partial class Book
    {
        public Book()
        {
            OrderDetails = new HashSet<OrderDetail>();
            PublisherSales = new HashSet<PublisherSale>();
        }

        public int Id { get; set; }
        public string BName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public DateTime Nsx { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int? CategoryId { get; set; }
        public decimal? PriceBuying { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<PublisherSale> PublisherSales { get; set; }
    }
}
