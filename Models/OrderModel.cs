using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppleStore.Models
{
    public class OrderModel
    {
         public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string Name { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Phone { get; set; } = null!;
        [EmailAddress]
        public string Email { get; set; } = null!;
        public string AddressLine { get; set; } = null!;
    }
}