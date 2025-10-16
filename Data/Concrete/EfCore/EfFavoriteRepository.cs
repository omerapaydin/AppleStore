using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleStore.Data.Abstract;
using AppleStore.Entity;

namespace AppleStore.Data.Concrete.EfCore
{
    public class EfFavoriteRepository : IFavoriteRepository
    {

        private IdentityContext _context;
        public EfFavoriteRepository(IdentityContext context)
        {
            _context = context;
        }
        public IQueryable<Favorite> Favorites =>  _context.Favorites;

        public void AddOrder(Favorite favorite)
        {
            _context.Favorites.Add(favorite);
            _context.SaveChanges();
        }
        
         public void DeleteFavorite(Favorite favorite)
        {
            _context.Favorites.Remove(favorite);
            _context.SaveChanges();
        }
    }
}