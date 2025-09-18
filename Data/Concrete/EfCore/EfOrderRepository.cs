using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleStore.Data.Abstract;
using AppleStore.Data.Concrete.EfCore;
using AppleStore.Entity;

namespace AppleStore.Data.Concrete
{
    public class EfOrderRepository : IOrderRepository
    {
        private IdentityContext _context;

        public EfOrderRepository(IdentityContext context)
        {
            _context = context;
        }
        public IQueryable<Order> Orders => _context.Orders;

        public void AddOrder(Order order)
        {
           _context.Orders.Add(order);
            _context.SaveChanges();
        
        }
    }
}