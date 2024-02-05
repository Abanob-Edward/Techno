using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Services
{
    public interface IProductInOrderService
    {
        
      
        public IQueryable<ProductInOrder> GetAll();

    }
}
