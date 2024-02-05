using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Contract
{
    public interface IOrderRepository : IG_Repo<Order, int>
    {

        public IQueryable<Order> getAllwithUser();
    }

}
