using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppleStore.Entity
{
    public class OrderItem
    {
         public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
        public int PostId { get; set; }
        public Product product { get; set; } = null!;
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}