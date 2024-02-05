using Appliaction.Contract;
using AutoMapper;
using DTOs.Orders;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Services
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository orderRepository;
        private readonly IOrderProductRepository orderProductRepository;


        public OrderService(IOrderRepository _orderRepository, IMapper mapper, IOrderProductRepository _orderProductRepository)
        {
            this.orderRepository = _orderRepository;
            orderProductRepository = _orderProductRepository;
            _mapper = mapper;

        }


        public IQueryable<Order> GetAllOrders()
        {

            return orderRepository.getAllwithUser().Include(c=>c.ProductInOrders);
        }

        public Order UpdateOrderStatus(int orderID, OrderStatus status)
        {
            Order order = orderRepository.getByID(orderID);
            order.OrderStatus = status;
            return orderRepository.update(order);
        }

        public Order addOrder(Order order)
        {
            return orderRepository.add(order);
        }

        public List<ProductInOrder> GetProductsInOrder(Order order)//up
        {
            return orderProductRepository.GetProductsInOrder(order);
        }

        public void AddListOfProducts(List<orderProductDTO> orderProductDTOs, int orderID)
        {
            var productInOrder = _mapper.Map<List<ProductInOrder>>(orderProductDTOs);


            foreach (var product in productInOrder)
            {
                product.OrderNumber = orderID;

                // add each product to productIn order
                orderProductRepository.add(product);

            }

        }

        public void addProductToOrderNow(ProductInOrder product, int orderID)
        {

            orderProductRepository.add(product);
        }

        public OrderStatus GetOrderStatus(int orderID)
        {
            return orderRepository.getByID(orderID).OrderStatus;
        }
        List<Product> IOrderService.GetProductsInOrder(Order order)
        {
            return orderProductRepository.GetProductsByOrderID(order.Id);
        }

       
    }
}
