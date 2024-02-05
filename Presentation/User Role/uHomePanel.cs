using Appliaction.Services;
using Autofac;
using Context;
using Infrastructure.Contract;
using Infrastructure.Repositores;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation.User_Role
{
    public partial class uHomePanel : Form
    {
        ProductDetails productDetails;
        UserPanel UserPanel;
        private int currentPage = 1;
        private const int PageSize = 10;

        int CurrentUserID;
        IProductService ProductService;
        ICartService cartService;
        CartproudectRepository cartproudectRepository;

        public uHomePanel(int currentUserID = 0)
        {

            InitializeComponent();
            var inject = AutoFact.Inject();
            ProductService = inject.Resolve<IProductService>();
            cartService = inject.Resolve<ICartService>();
            cartproudectRepository = new CartproudectRepository(new _Context());
            CurrentUserID = currentUserID;
        }
        string searchtxt = "";

        public uHomePanel(UserPanel userPanel, int currentUserID = 0)
        {

            InitializeComponent();
            var inject = AutoFact.Inject();
            ProductService = inject.Resolve<IProductService>();
            cartService = inject.Resolve<ICartService>();
            cartproudectRepository = new CartproudectRepository(new _Context());
            CurrentUserID = currentUserID;
            UserPanel = userPanel;
        }
        DataGridViewButtonColumn addToCart = new DataGridViewButtonColumn();
        DataGridViewButtonColumn ProductDetails = new DataGridViewButtonColumn();
        DataGridViewImageColumn ProductImage = new DataGridViewImageColumn();

        private void uHomePanel_Load(object sender, EventArgs e)
        {

           
            var listOfproduct = ProductService.GetAlltech();
            // ID  -  Name   - price    - image --   add to cart 

 


            ProductsDGV.ColumnCount = 3;
            ProductsDGV.Columns[0].Name = "ID";
            ProductsDGV.Columns[1].Name = "Name";
            ProductsDGV.Columns[2].Name = "Price";
            // ProductsDGV.Columns[3].Name = "Image ";
            ProductsDGV.Columns[0].Width = 60;



            ArrayList list;
            

            foreach (var item in listOfproduct)
            {
                list = new ArrayList();
                list.Add(item.Id);
              
                list.Add(item.Name);
                list.Add(item.Price);

                ProductsDGV.Rows.Add(list.ToArray());
            }
            ProductImage.Name = "ProPic";

            ProductImage.HeaderText = "Image";
            ProductImage.ImageLayout = DataGridViewImageCellLayout.Stretch;

            ProductsDGV.Columns.Add(ProductImage);


            int row = 0;
            foreach (var item in listOfproduct)
            {
                try
                {

                    Bitmap bmp = new Bitmap(@"D:\ITI Intake24 3 months\Visual C#\lap\onion architecture Day12\Presentation\images\" + item.Image);
                    ((DataGridViewImageCell)ProductsDGV.Rows[row].Cells[3]).Value = bmp;
                    row++;
                }
                catch (Exception)
                {

                    Bitmap bmp = new Bitmap(@"D:\ITI Intake24 3 months\Visual C#\lap\onion architecture Day12\Presentation\images\" + "Defult.jpeg");
                    ((DataGridViewImageCell)ProductsDGV.Rows[row].Cells[3]).Value = bmp;
                    row++;
                }

              
            }


            addToCart.Text = "Add to Cart";
            addToCart.Name = "addToCartBtn";
            addToCart.HeaderText = "Cart Item";
            addToCart.UseColumnTextForButtonValue = true;
            ProductsDGV.Columns.Add( addToCart);
           

            ProductDetails.Text = "Details";
            ProductDetails.Name = "ProductDetailsBtn";
            ProductDetails.HeaderText = "Product Details";
            ProductDetails.UseColumnTextForButtonValue = true;
            ProductsDGV.Columns.Add(ProductDetails);

        }
        /*    private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here

                    ProductsDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            }*/
        private void ProductsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                var ProductID = int.Parse(ProductsDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                // ProductsDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
                int cartID = cartService.GetCartByUserID(CurrentUserID).Id;
                cartService.addproductToCart(ProductID, cartID);
                ProductsDGV.CurrentCell.Style.BackColor = Color.Green;
                Success.Text = "Success ADD to cart item " + ProductID.ToString();
                //MessageBox.Show(yarab);
            }

            if (e.ColumnIndex == 5 && e.RowIndex != -1)
            {
                // Details
                var ProductID = int.Parse(ProductsDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                productDetails = new ProductDetails(ProductID, CurrentUserID);
                productDetails.FormClosed += productDetailslClosed;
                productDetails.MdiParent = UserPanel;
                productDetails.Dock = DockStyle.Fill;
                productDetails.Show();



            }
        }
        private void LoadTable(string search = "")
        {
            ProductsDGV.Rows.Clear(); // Clear existing rows
            ArrayList list;
            int skipCount = (currentPage - 1) * PageSize;
            int takeCount = PageSize;

            List<Product> listOfproduct = ProductService.GetAllPagination(skipCount, takeCount, search);


            foreach (var item in listOfproduct)
            {
                list = new ArrayList();
                list.Add(item.Id);

                list.Add(item.Name);
                list.Add(item.Price);

                ProductsDGV.Rows.Add(list.ToArray());
            }


            int row = 0;
            foreach (var item in listOfproduct)
            {
                try
                {

                    Bitmap bmp = new Bitmap(@"D:\ITI Intake24 3 months\Visual C#\lap\onion architecture Day12\Presentation\images\" + item.Image);
                    ((DataGridViewImageCell)ProductsDGV.Rows[row].Cells[3]).Value = bmp;
                    row++;
                }
                catch (Exception)
                {

                    Bitmap bmp = new Bitmap(@"D:\ITI Intake24 3 months\Visual C#\lap\onion architecture Day12\Presentation\images\" + "Defult.jpeg");
                    ((DataGridViewImageCell)ProductsDGV.Rows[row].Cells[3]).Value = bmp;
                    row++;
                }


            }
        }


        private void productDetailslClosed(object? sender, FormClosedEventArgs e)
        {
            // productDetails.Close();

        }

        private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int nextPage = currentPage + 1;

                if (HasDataOnPage(nextPage))
                {
                    currentPage = nextPage;
                    LoadTable(searchtxt); // Reload the table for the next page
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

        private void previousBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int previousPage = currentPage - 1;

                if (previousPage >= 1)
                {
                    if (HasDataOnPage(previousPage))
                    {
                        currentPage = previousPage;
                        LoadTable(searchtxt); // Reload the table for the previous page
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchtxt = searchBox.Text.ToString();

            LoadTable(searchtxt);


        }

    
    }
}
