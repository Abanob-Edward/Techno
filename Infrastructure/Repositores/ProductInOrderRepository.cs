using Appliaction.Contract;
using Context;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositores
{
    public class ProductInOrderRepository : Repository<ProductInOrder, int>, IProductInOrderRepository
    {
        private readonly _Context context;

        public ProductInOrderRepository(_Context _context) : base(_context)
        {

            this.context = _context;
        }

    }
}
