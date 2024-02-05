using Appliaction.Contract;
using Context;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositores
{
    public class OrderRepository : Repository<Order, int>, IOrderRepository
    {
        private readonly _Context context;
        public OrderRepository(_Context _context) : base(_context)
        {
            this.context = _context;
        }

       public IQueryable<Order> getAllwithUser()
        {
            return context.Orders.Include(c => c.User);
        }
       
    }
}
