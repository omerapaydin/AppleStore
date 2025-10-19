using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleStore.Data.Abstract;
using AppleStore.Entity;
using Microsoft.EntityFrameworkCore;

namespace AppleStore.Data.Concrete.EfCore
{
    public class EfFavoriteRepository : IFavoriteRepository
    {

        private IdentityContext _context;
        public EfFavoriteRepository(IdentityContext context)
        {
            _context = context;
        }
         public IQueryable<Favorite> Favorites =>
            _context.Favorites
                .Include(f => f.FavoriteItems)
                .ThenInclude(fi => fi.Product);

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
        
         public Favorite? GetFavoriteById(int id)
        {
            return _context.Favorites
                .Include(f => f.FavoriteItems)
                .ThenInclude(fi => fi.Product)
                .FirstOrDefault(f => f.FavoriteId == id);
        }

        public Favorite? GetFavoriteByUserId(string userId)
        {
            return _context.Favorites
                .Include(f => f.FavoriteItems)
                .ThenInclude(fi => fi.Product)
                .FirstOrDefault(f => f.UserId == userId);
        }
        public void UpdateFavorite(Favorite favorite)
                    {
                        _context.Favorites.Update(favorite);
                        _context.SaveChanges();
                    }
    }
}