using Appliaction.Services;
using Autofac;
using Context;
using Infrastructure.Contract;
using Infrastructure.Repositores;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation.User_Role
{
    public partial class ProductDetails : Form
    {
        // ICartService CartService;
        IUserService UserService;
        IProductService ProductService;
        ICartService cartService;
        IOrderService orderService;
        int currentUserId;
        string ProductImageSelction = "";
        string newImageName = "";
        string Idlabel;
        public ProductDetails(int? proID, int _currentUserId)
        {
            InitializeComponent();

            Idlabel = proID.ToString();

            var inject = AutoFact.Inject();
            ProductService = inject.Resolve<IProductService>();
            cartService = inject.Resolve<ICartService>();
            orderService = inject.Resolve<IOrderService>();
            UserService = inject.Resolve<IUserService>();
            ///new


            currentUserId = _currentUserId;

        }



        Product product;

        private void ProductDetails_Load_1(object sender, EventArgs e)
        {


            // // string imagePath = @"C:\Users\ALAWAEL\OneDrive\Desktop\Asmaa\new\Techno_Shope\Presentation\images\images.jPEG";
            //string imagePath = @"C:\Users\ALAWAEL\OneDrive\Desktop\Asmaa\new\Techno_Shope\Presentation\images";


            //if (!string.IsNullOrEmpty(imagePath))
            //{
            //    try
            //    {
            //        pictureBox1.Image = Image.FromFile(imagePath);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error loading image: {ex.Message}");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No image found for this product.");
            //}



            int proID;
     

            if (int.TryParse(Idlabel, out proID))
            {
                 product = ProductService.GettechById(proID);

                if (product != null)
                {
                    label7.Text = product.Name;
                    label8.Text = product.Description;
                    label9.Text = product.Price.ToString();



                    try
                    {
                        Bitmap bmp = new Bitmap(@"D:\ITI Intake24 3 months\Visual C#\lap\onion architecture Day12\Presentation\images\" + product.Image);


                        pictureBox1.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        Bitmap bmp = new Bitmap(@"D:\ITI Intake24 3 months\Visual C#\lap\onion architecture Day12\Presentation\images\" + "Defult.jpeg");

                        MessageBox.Show($"Error loading image: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid product ID.");
            }



        }

        private void addtocartBTN_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Idlabel, out int productID))
            {

                int cartID = cartService.GetCartByUserID(currentUserId).Id;
                // int cartID = cartID1.Id;

                ProductCartItem addedProduct = cartService.addproductToCart(productID, cartID);

                if (addedProduct != null)
                {
                  
                    SuccessLapel.Text = "Product added to cart successfully ";

                }
                else
                {
                    SuccessLapel.ForeColor = Color.Red;
                    SuccessLapel.Text = "Failed to add product to cart.!";
                   
                }
            }
            else
            {
                MessageBox.Show("Invalid product ID.");
            }
        }

        private void OrderNowBTN_Click(object sender, EventArgs e)
        {
            var Result = MessageBox.Show($"Are you sure From this order with Total price{product.Price.ToString()} ", "Order Confirm", MessageBoxButtons.YesNo);

            if (Result == DialogResult.Yes)
            {
                try
                {
                    // add new order
                    Order newOrder = new Order()
                    {
                        OrderDate = DateTime.Now,
                        OrderStatus = OrderStatus.processing,
                        totalprice = (decimal)product.Price,
                        User_ID = currentUserId,


                    };

                    var inctanceOrder = orderService.addOrder(newOrder);
                    ProductInOrder inctanceProduct = new ProductInOrder()
                    {
                        OrderNumber = inctanceOrder.Id,
                        Quantity = 1,
                        product_Id = product.Id,

                    };
                    // function to take  product and add it  to order 
                    orderService.addProductToOrderNow(inctanceProduct, inctanceOrder.Id);
                    //  orderService.AddListOfProducts(ProductIdWithQuantitylist, inctanceOrder.Id);
                    SuccessLapel.Text = "Successful Order ";


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }
    }
}

