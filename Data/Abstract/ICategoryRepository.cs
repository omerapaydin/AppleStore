using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleStore.Entity;

namespace AppleStore.Data.Abstract
{
    public interface ICategoryRepository
    {
          IQueryable<Category> Categories {get;}

        void AddCategory(Category category);
    }
}