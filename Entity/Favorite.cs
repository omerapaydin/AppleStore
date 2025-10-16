using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppleStore.Entity
{
    public class Favorite
    {
        public int FavoriteId { get; set; }
        public DateTime PublishedOn { get; set; } = DateTime.Now;

        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;

        public List<FavoriteItem> FavoriteItems { get; set; } = new();
    }
}