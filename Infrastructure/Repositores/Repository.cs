using Appliaction.Contract;
using Context;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Model.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositores
{
    public class Repository<T,TID> : IG_Repo<T,TID>    where T : class
    {

        private readonly _Context context;
        public Repository(_Context _context)
        {
            context = _context;
        }
        public IQueryable<T> getAll()
        {
            return context.Set<T>().Select(c=>c);
        }
        public T? getByID(TID id)
        {
            if (id != null)
            {
                return context.Set<T>().Find(id);
            }
            return null;
        }



        public T add(T entity) {
            var result = context.Add(entity).Entity;
            context.SaveChanges();
            return result;
           
               
        }

        public T update(T entity)
        {
            var result = context.Update(entity).Entity;
            context.SaveChanges();
            return result;
        }

        public void delete(TID id)
        {
            var entityToDelete = context.Find<T>(id);

            if (entityToDelete != null)
            {
                context.Remove(entityToDelete);
                context.SaveChanges();
            }
        }

       


     
    }
}
