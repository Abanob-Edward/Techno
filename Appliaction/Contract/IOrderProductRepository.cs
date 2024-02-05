using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Contract
{
    public interface IOrderProductRepository : IG_Repo<ProductInOrder, int>
    {
        List<ProductInOrder> GetProductsInOrder(Order order);
        List<Product> GetProductsByOrderID(int orderID);
        //up
        //public interface IOrderProductRepository
        //{
        //    List<ProductInOrder> GetProductsByOrderID(int orderID);
        //    List<ProductInOrder> GetProductsInOrder(Order order);
        //}

        public interface IOrderProductRepository
        {
            List<ProductInOrder> GetProductsInOrder(Order order);
            List<Product> GetProductsByOrderID(int orderID);
        }


    }
}
