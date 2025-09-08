using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleStore.Entity;

namespace AppleStore.Data.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
        void AddProduct(Product product);
    }
}