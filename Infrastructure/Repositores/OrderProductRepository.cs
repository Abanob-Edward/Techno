using Appliaction.Contract;
using Context;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositores
{
    public class OrderProductRepository: Repository<ProductInOrder, int> , IOrderProductRepository
    {
        private readonly _Context context;
        public OrderProductRepository(_Context _context) : base(_context)
        {
            this.context = _context;

        }
        //public List<ProductInOrder> GetProductsByOrderID(int orderID)////up
        //{
        //    return context.ProductInOrders.Where(p => p.ID == orderID).ToList();
        //}

        

        //public List<ProductInOrder> GetProductsInOrder(Order order)
        //{
        //    return context.ProductInOrders.Where(p => p.order.Id == order.Id).ToList();
        //}

        public List<Product> GetProductsByOrderID(int orderID)
        {
            // Assuming ProductInOrder has a reference to Product
            return context.ProductInOrders
                .Where(p => p.order.Id == orderID)
                .Select(p => p.Product) // Assuming Product is the reference to products in ProductInOrder
                .ToList();
        }

        public List<ProductInOrder> GetProductsInOrder(Order order)
        {
            return context.ProductInOrders.Where(p => p.order.Id == order.Id).ToList();
        }
    }
}
