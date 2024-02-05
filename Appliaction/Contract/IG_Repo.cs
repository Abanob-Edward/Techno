using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Contract
{
    // CRUD
    public interface IG_Repo<T, TID>
    {
        IQueryable<T> getAll();
        T getByID(TID? id);
        T add(T entity);
        void delete(TID id);
         
        T update(T entity);
    }
}
