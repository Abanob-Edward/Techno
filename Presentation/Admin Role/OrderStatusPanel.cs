using Appliaction.Services;
using Autofac;
using Context;
using Infrastructure.Repositores;
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

namespace Presentation
{
    public partial class OrderStatusPanel : Form
    {
        private readonly IOrderService orderService;
        OrderStatus OrderStatus = new OrderStatus();

        int ID = 0;
        public OrderStatusPanel()
        {
           
            InitializeComponent();
            var inject = AutoFact.Inject();
            orderService= inject.Resolve<IOrderService>();
            loadData();

        }

        public void loadData()
        {
            try
            {
                var LsitOfOrder = orderService.GetAllOrders().Select(x => new
                {
                    ID = x.Id,
                    OrderDate = x.OrderDate,
                    OrderStatu = x.OrderStatus.ToString(),
                    Total_Price = x.totalprice,

                    Products_In_This_Order = x.ProductInOrders.Count(),
                });
                AllOrdersDGV.DataSource = LsitOfOrder.ToList();
               // AllOrdersDGV.DataSource = orderService.GetAllOrders().ToList();
            }
            catch (Exception)
            {


            }
        }
        private void AllOrdersDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IDMessage.Text = AllOrdersDGV.CurrentRow.Cells[0].Value.ToString();
            ID = int.Parse( AllOrdersDGV.CurrentRow.Cells[0].Value.ToString());
            IDMessage.ForeColor = Color.Green;
           var orderStatusResult = orderService.GetOrderStatus(ID);
            if(orderStatusResult == OrderStatus.processing)
            {
                processingradio.Checked = true;
                shippedradio.Checked = false;
                deliveredradio.Checked = false;
            }
            else if (orderStatusResult == OrderStatus.shipped)
            {
                shippedradio.Checked = true;
                processingradio.Checked = false;
                deliveredradio.Checked = false;
            }
            else if (orderStatusResult == OrderStatus.delivered)
            {
                deliveredradio.Checked = true;
                processingradio.Checked = false;
                shippedradio.Checked = false;
            }


          
        }

        private void processingradio_CheckedChanged(object sender, EventArgs e)
        {

            if (ID != 0)
                {
                    orderService.UpdateOrderStatus(ID, OrderStatus.processing);
                    loadData();

                }else
                    IDMessage.Size = new System.Drawing.Size(800, 40);
                    IDMessage.Width = 600;

        }

        private void shippedradio_CheckedChanged(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                orderService.UpdateOrderStatus(ID, OrderStatus.shipped);
                 loadData();

            }
            IDMessage.Focus();

        }

        private void deliveredradio_CheckedChanged(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                orderService.UpdateOrderStatus(ID, OrderStatus.delivered);
                  loadData();
            }
            IDMessage.Focus();
        }
    }
}
