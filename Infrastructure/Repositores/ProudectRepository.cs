using Appliaction.Contract;
using Context;
using Appliaction.Contract;
using AutoMapper;
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
    public class ProudectRepository : Repository<Product, int>, IProudectRepository
    {
        private readonly _Context context;

        public ProudectRepository(_Context _context) : base(_context)
        {

            this.context = _context;
        }

    

     

        public IQueryable<Product> SearchByName(string Name)
        {
           //newwwwwwwwww
           // return context.Products.Where(p => p.Name.Contains(Name)).AsQueryable();
            return context.Products.Where(x => x.Name.Contains(Name));
        }

        public int GetProductCountByCategoryId(int categoryId)
        {
            // Assuming you have a 'Products' table with a 'CategoryId' column
            return context.Products.Count(p => p.Id == categoryId);
        }

  

    }
}
