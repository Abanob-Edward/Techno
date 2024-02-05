using Appliaction.Contract;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Services
{
    public class ProductInOrderService : IProductInOrderService
    {
        private readonly IProductInOrderRepository ProductInOrderRepository;


        public ProductInOrderService(IProductInOrderRepository _IProductInOrderRepository)
        {

            ProductInOrderRepository = _IProductInOrderRepository;

        }
       
        public  IQueryable<ProductInOrder> GetAll() 
        {
         return ProductInOrderRepository.getAll();
        }

        

        
    }
}
