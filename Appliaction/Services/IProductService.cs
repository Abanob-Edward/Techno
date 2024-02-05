using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Services
{
    public interface IProductService//<T, TID>
    {
        
   
        IQueryable<Product> GetAlltech();
        Product? GettechById(int id);
        void Addtech(Product entity);
        public void Deletetech(int id);
        public Product Updatetech(Product entity);
        ///newwwwwwwwwwwwwwwwww
        IQueryable<Product> GetByName(string? Name);
        List<Product> GetAllPagination(int skipCount, int pageSize ,string ? searchtxt);
    }
}


