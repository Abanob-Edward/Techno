using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Contract
{
    public interface IProudectRepository : IG_Repo<Product, int>
    {
        public IQueryable<Product> SearchByName(string Name);

    }
}