using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Contract
{
    public interface ICategoryRepository:IG_Repo<Category, int>
    {
        int GetProductCountByCategoryId(int categoryId);
        public IQueryable<Category> SearchByName(string Name);

    }
}
