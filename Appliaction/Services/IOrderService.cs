using DTOs.Orders;
using Model.Models;

namespace Appliaction.Services
{
    public interface IOrderService
    {
        IQueryable<Order> GetAllOrders();

        Order addOrder(Order order);
        public Order UpdateOrderStatus(int orderID, OrderStatus status);
        /// <summary>
        ///  this function need dtos  to  mapp data 
        /// </summary>
        /// <param name="productsID"></param>
        /// <param name="orderID"></param>
        /// <returns></returns>
        void AddListOfProducts(List<orderProductDTO> orderProductDTOs, int orderID);
        void addProductToOrderNow(ProductInOrder product, int orderID);
         OrderStatus GetOrderStatus(int orderID);
      //  List<ProductInOrder> GetProductsInOrder(Order order);


            List<Product> GetProductsInOrder(Order order);
      //  List<Product> GetProductsInOrder(int orderId);
    }
}