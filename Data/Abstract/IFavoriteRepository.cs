using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleStore.Entity;

namespace AppleStore.Data.Abstract
{
    public interface IFavoriteRepository
    {
        
        IQueryable<Favorite>  Favorites { get; }

        void AddOrder(Favorite favorite);
        void DeleteFavorite(Favorite favorite);
        Favorite? GetFavoriteById(int id);
        Favorite? GetFavoriteByUserId(string userId);
        void UpdateFavorite(Favorite favorite);
    }
}