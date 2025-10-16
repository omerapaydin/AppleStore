using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppleStore.Entity
{
    public class FavoriteItem
    {
         public int FavoriteItemId { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public int FavoriteId { get; set; }
        public Favorite Favorite { get; set; } = null!;
    }
}