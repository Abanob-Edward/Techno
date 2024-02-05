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
    public partial class productsInOrder : Form 
    {
        IProductService ProductService;
        ICartService cartService;
        IOrderService orderService;
        private readonly Order order;
        private List<Product> products;
        
        public productsInOrder(List<Product> products)
        {
            var inject = AutoFact.Inject();
            ProductService = inject.Resolve<IProductService>();
            cartService = inject.Resolve<ICartService>();
            orderService = inject.Resolve<IOrderService>();
          
            InitializeComponent();
          
            this.products = products;
            
            

            loadtabel();
            


        }

        private void loadtabel()
        {
            if (ProudectInorderDGV != null)
            {
                
                ProudectInorderDGV.Columns.Add("ProductName", "Product Name");
                ProudectInorderDGV.Columns.Add("ProductPrice", "Product Price");
                ProudectInorderDGV.Columns.Add("ProductImage", "Product Image");
                ProudectInorderDGV.Columns.Add("ProductDescription", "Product Description");
                ProudectInorderDGV.Columns.Add("ProductTitle", "Product Title");
                ProudectInorderDGV.Rows.Clear();

                //foreach (var product in order.ProductInOrders)
                //{
                //    ProudectInorderDGV.Rows.Add(
                //        product.Product.Name,
                //        product.Product.Price,
                //        product.Product.Image,
                //        product.Product.Description,
                //        product.Product.Title

                //        );
                //}
                
                foreach (var product in products)
                {
                    ProudectInorderDGV.Rows.Add(
                         product.Name,
                         product.Price,
                         product.Image,
                         product.Description,
                         product.Title

                    );
                }


            }
        }

    }
}

