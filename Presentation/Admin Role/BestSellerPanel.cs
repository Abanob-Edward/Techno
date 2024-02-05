using Appliaction.Services;
using Context;
using Infrastructure.Repositores;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Presentation
{
    public partial class BestSellerPanel : Form
    {
        IProductInOrderService ProductInOrderService;
        IProductService ProductService;

        public BestSellerPanel()
        {
            InitializeComponent();
            ProductInOrderService = new ProductInOrderService(new ProductInOrderRepository(new _Context()));
            ProductService = new ProductService(new ProudectRepository(new _Context()));
        }

        public void BestSellerPanel_Load_1(object sender, EventArgs e)
        {
            var topProducts = ProductInOrderService
                .GetAll()
                .GroupBy(g => g.product_Id)
                .OrderByDescending(g => g.Count())
                .Take(5)
                .Select(g => new
                {
                    ProductID = g.Key,
                    RepetitionCount = g.Count(),
                    ProductName = ProductService.GettechById(g.Key).Name,
                     ProductService.GettechById(g.Key).Price,
                    ProductService.GettechById(g.Key).Description
                });

            dataGridView1.DataSource = topProducts.ToList();
        }
    }
}
