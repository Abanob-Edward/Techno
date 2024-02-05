//using Appliaction.Services;
//using Autofac;
//using Model.Models;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Presentation.User_Role
//{
//    public partial class OrderPanel : Form
//    {
//        productsInOrder productsInOrder;
//        IProductService ProductService;
//        ICartService cartService;
//        IOrderService orderService;

//        public OrderPanel()
//        {

//            var inject = AutoFact.Inject();
//            ProductService = inject.Resolve<IProductService>();
//            cartService = inject.Resolve<ICartService>();
//            orderService = inject.Resolve<IOrderService>();
//            InitializeComponent();
//            if (OrderDGV != null)
//            {
//                OrderDGV.CellContentClick += OrderDGV_CellContentClick;
//                loadTable();
//            }

//        }

//        public void loadTable()
//        {
//            var userOrders = orderService.GetAllOrders();

//            var orderDetails = userOrders.Select(order => new
//            {
//                order.OrderDate,
//                order.OrderStatus,
//                order.totalprice,
//                order.Id,

//            }).ToList();

//            OrderDGV.DataSource = orderDetails;

//            // Add a button column
//            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
//            btnColumn.HeaderText = "Products In order";
//            btnColumn.Text = "View";
//            btnColumn.UseColumnTextForButtonValue = true;
//            OrderDGV.Columns.Add(btnColumn);
//        }

//        private void OrderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {

//            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
//            {


//                var orderDate = (DateTime)OrderDGV.Rows[e.RowIndex].Cells["OrderDate"].Value;
//                var orderStatus = (OrderStatus)OrderDGV.Rows[e.RowIndex].Cells["OrderStatus"].Value;
//                var totalPrice = (decimal)OrderDGV.Rows[e.RowIndex].Cells["TotalPrice"].Value;
//                /////////////

//                // var order = (Order)OrderDGV.Rows[e.RowIndex].DataBoundItem;


//                /////  list
//                //Order order = new Order
//                //{
//                //    OrderDate = orderDate,
//                //    OrderStatus = orderStatus,
//                //    totalprice = totalPrice
//                //};
//                //var productsInOrder = orderService.GetProductsInOrder(order); // list
//                //var ProductsInOrder = new productsInOrder(productsInOrder);
//                //ProductsInOrder.Dock = DockStyle.Fill;
//                //ProductsInOrder.ShowDialog();



//                //send order


//                Order order = new Order
//                {
//                    OrderDate = orderDate,
//                    OrderStatus = orderStatus,
//                    totalprice = totalPrice
//                };


//                productsInOrder = new productsInOrder(order);
//                productsInOrder.Dock = DockStyle.Fill;
//                productsInOrder.ShowDialog();

//            }
//            loadTable();
//        }



//    }
//}

using Appliaction.Services;
using Autofac;
using Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.User_Role
{
    public partial class OrderPanel : Form
    {
        IProductService ProductService;
        ICartService cartService;
        IOrderService orderService;

        public OrderPanel()
        {
            var inject = AutoFact.Inject();
            ProductService = inject.Resolve<IProductService>();
            cartService = inject.Resolve<ICartService>();
            orderService = inject.Resolve<IOrderService>();
            InitializeComponent();
            if (OrderDGV != null)
            {
               // OrderDGV.CellContentClick += OrderDGV_CellContentClick;
                loadTable();
            }
        }

        public void loadTable()
        {
            var userOrders = orderService.GetAllOrders();

            var orderDetails = userOrders.Select(order => new
            {
                order.OrderDate,
                order.OrderStatus,
                order.totalprice,
                order.Id,
            }).ToList();

            OrderDGV.DataSource = orderDetails;

            // Add a button column
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Products In order";
            btnColumn.Text = "View";
            btnColumn.UseColumnTextForButtonValue = true;
            OrderDGV.Columns.Add(btnColumn);
        }

        private void OrderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                var orderDate = (DateTime)OrderDGV.Rows[e.RowIndex].Cells["OrderDate"].Value;
                var orderStatus = (OrderStatus)OrderDGV.Rows[e.RowIndex].Cells["OrderStatus"].Value;
                var totalPrice = (decimal)OrderDGV.Rows[e.RowIndex].Cells["TotalPrice"].Value;
                var orderId = (int)OrderDGV.Rows[e.RowIndex].Cells["Id"].Value;

                           // list of products for the selected order
                var productsInOrder = orderService.GetProductsInOrder(new Order { Id = orderId });

                       
                var productsInOrderForm = new productsInOrder(productsInOrder);
              //  productsInOrderForm.Dock = DockStyle.Fill;
               productsInOrderForm.ShowDialog();
             
            }
        }
    }
}

