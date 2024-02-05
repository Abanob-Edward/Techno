using Appliaction.Services;
using Autofac;
using Context;
using Context.Migrations;
using DTOs.Orders;
using Infrastructure.Repositores;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.User_Role
{



    public partial class CartItemPanel : Form
    {
        public int UserCurrenID;
        IProductService ProductService;
        ICartService cartService;
        IOrderService orderService;
        // CartproudectRepository cartproudectRepository;

        private int currentPage = 1;
        private const int PageSize = 10;
        double totalPrice = 0;
        public CartItemPanel(int userid = 0)
        {
            UserCurrenID = userid;
            InitializeComponent();
            var inject = AutoFact.Inject();
            ProductService = inject.Resolve<IProductService>();


            cartService = inject.Resolve<ICartService>();
            orderService = inject.Resolve<IOrderService>();
            // cartproudectRepository = new CartproudectRepository(new _Context());

            
        }
        // get product list fot spcific User id 

        // CartItemDGV.DataSource = cartproudectRepository.getAll().ToList();
        // get product list fot spcific User id 
        // get product list fot spcific User id 
        //Get product list for a specific User ID 
        //var cartiteampro = cartproudectRepository.getAll()

    
        DataGridViewCheckBoxColumn OrderListcheckBox = new DataGridViewCheckBoxColumn();
        DataGridViewButtonColumn DeleteFromCart = new DataGridViewButtonColumn();
        private void CartItemPanel_Load(object sender, EventArgs e)
        {
           
          
           /// int skipCount = (currentPage - 1) * PageSize;
          //  int takeCount = PageSize;

            // get the current cartid for current user 

            var cartID = cartService.GetCartByUserID(UserCurrenID).Id;
            // Get product list for a specific User ID 
            var listOfproduct = cartService.GetAllProductInCartItems(cartID);

            CartItemDGV.ColumnCount = 7;
            CartItemDGV.Columns[0].Name = "ID";
            CartItemDGV.Columns[1].Name = "Image";
            CartItemDGV.Columns[2].Name = "Price";
            CartItemDGV.Columns[3].Name = "Title";
            CartItemDGV.Columns[4].Name = "Code";
            CartItemDGV.Columns[5].Name = "Quantity";
            CartItemDGV.Columns[6].Name = "Total Price";
           
          
            CartItemDGV.Columns[0].Width = 60;

            ArrayList list;
            foreach (var item in listOfproduct)
            {
                list = new ArrayList();
                list.Add(item.Product.Id);
                list.Add(item.Product.Image);
                list.Add(item.Product.Price);
                list.Add(item.Product.Title);
                list.Add(item.Product.Code);
                list.Add(item.Quantity);
                list.Add((item.Quantity) * (item.Product.Price));
              


                CartItemDGV.Rows.Add(list.ToArray());
            }


            OrderListcheckBox.HeaderText = " Order list";
            OrderListcheckBox.Name = " Orderlist";
            CartItemDGV.Columns.Add(OrderListcheckBox);


            DeleteFromCart.Text = "Delete";
            DeleteFromCart.Name = "ProductDeleteBtn";
            DeleteFromCart.HeaderText = "Delete Details";
            DeleteFromCart.UseColumnTextForButtonValue = true;
            CartItemDGV.Columns.Add(DeleteFromCart);
        

        }
        List<orderProductDTO> ProductIdWithQuantitylist = new List<orderProductDTO>();
        private void CartItemDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            var ProductID = int.Parse(CartItemDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            var total = double.Parse(CartItemDGV.Rows[e.RowIndex].Cells[6].Value.ToString());
            var Quantaty = int.Parse(CartItemDGV.Rows[e.RowIndex].Cells[5].Value.ToString());

            //check box
            if (e.ColumnIndex == 7)
            {

                CartItemDGV.EndEdit();

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn &&
                    e.RowIndex >= 0)
                {

                    bool isChecked = (bool)CartItemDGV[e.ColumnIndex, e.RowIndex].EditedFormattedValue;
                    if (isChecked)
                    {
                        // ProductIDlist.Add(ProductID);

                        ProductIdWithQuantitylist.Add(new orderProductDTO() { product_Id = ProductID, Quantity = Quantaty });
                        totalPrice += total;

                    }
                    else
                    {

                        // ProductIDlist.Remove(ProductID);
                        var item = ProductIdWithQuantitylist.FirstOrDefault(c => c.product_Id == ProductID && c.Quantity == Quantaty);
                        ProductIdWithQuantitylist.Remove(item);
                        totalPrice -= total;

                    }
                    OrderTotalprice.Text = totalPrice.ToString();
                  
                }

            }
            //Delete btn
            if (e.ColumnIndex == 8)
            {
                try
                {
                    cartService.DeleteOneProductFromCart(ProductID);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadTable();


            }



        }

        private void LoadTable()
        {
            CartItemDGV.Rows.Clear();
            ArrayList list;
            int skipCount = (currentPage - 1) * PageSize;
            int takeCount = PageSize;

            // get the current cartid for current user 

            var cartID = cartService.GetCartByUserID(UserCurrenID).Id;
            // Get product list for a specific User ID 
            var listOfproduct = cartService.GetAllProductInCartItemsPaging(skipCount,takeCount,cartID).ToList();

  

            foreach (var item in listOfproduct)
            {
                list = new ArrayList();
                list.Add(item.Product.Id);
                list.Add(item.Product.Image);
                list.Add(item.Product.Price);
                list.Add(item.Product.Title);
                list.Add(item.Product.Code);
                list.Add(item.Quantity);
                list.Add((item.Quantity) * (item.Product.Price));



                CartItemDGV.Rows.Add(list.ToArray());
            }
            // List<Product> listOfproduct = ProductService.GetAllPagination(skipCount, takeCount);



        }
      
        private void button1_Click(object sender, EventArgs e) // next 
        {
            try
            {
                int nextPage = currentPage + 1;

                if (HasDataOnPage(nextPage))
                {
                    currentPage = nextPage;
                    LoadTable(); // Reload the table for the next page
                }
                else
                {
                    MessageBox.Show("No more data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e) // previous 
        {
            try
            {
                int previousPage = currentPage - 1;

                if (previousPage >= 1)
                {
                    if (HasDataOnPage(previousPage))
                    {
                        currentPage = previousPage;
                        LoadTable(); // Reload the table for the previous page
                    }
                    else
                    {
                        MessageBox.Show("No more data available on the previous page.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You are already on the first page.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool HasDataOnPage(int page)
        {
            int skipCount = (page - 1) * PageSize;
            int takeCount = PageSize;

            List<Product> products = ProductService.GetAllPagination(skipCount, takeCount, "");

            return products.Any(); // Check if there is any data on the specified page
        }




        private void OrderAll_Click(object sender, EventArgs e)
        {
            var Result = MessageBox.Show($"Are you sure From this order with Total price{totalPrice.ToString()} ", "Order Confirm", MessageBoxButtons.YesNo);

            if (Result == DialogResult.Yes)
            {
                try
                {
                    // add new order
                    Order newOrder = new Order()
                    {
                        OrderDate = DateTime.Now,
                        OrderStatus = OrderStatus.processing,
                        totalprice = (decimal)totalPrice,
                        User_ID = UserCurrenID,


                    };

                    var inctanceOrder = orderService.addOrder(newOrder);
                    // function to take list of product id's and add it list to order 
                    orderService.AddListOfProducts(ProductIdWithQuantitylist, inctanceOrder.Id);
                    // function to take list of product id's and Delete the products from product cart item
                    cartService.DeleteListOfProductFromCart(ProductIdWithQuantitylist.Select(c => c.product_Id).ToList());
                    LoadTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }

        private void Reload_Click(object sender, EventArgs e)
        {
            try
            {
                LoadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


