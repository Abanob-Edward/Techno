using System;
using System.Windows.Forms;

namespace Presentation.Admin_Role
{
    public partial class Home_Admin : Form
    {
        private CategoryPanel CategoryPanel;
        private ProductPanel ProductPanel;
        private EditProductPanel EditProductPanel;
        private BestSellerPanel BestSellerPanel;
        private OrderStatusPanel OrderStatusPanel;
        private AllOrdersPanal AllOrdersPanal;
        private LoginAndRegister loginAndRegister;

        private AdminPanal adminPanal;
        public Home_Admin(AdminPanal adminPanal)
        {
            InitializeComponent();
            this.adminPanal = adminPanal;
        }
        public Home_Admin()
        {
            InitializeComponent();

        }

       
        private void Home_Admin_Load(object sender, EventArgs e)
        {
           
        }

        private void but_Category_Ad_Click(object sender, EventArgs e)
        {
            
            if (CategoryPanel == null)
            {
                CategoryPanel = new CategoryPanel();
                CategoryPanel.FormClosed += CategoryClosed;
                CategoryPanel.MdiParent = adminPanal;
                CategoryPanel.Dock = DockStyle.Fill;
                CategoryPanel.Show();
            }
            else
            {
                CategoryPanel.Activate();
            }



        }

        private void CategoryClosed(object? sender, FormClosedEventArgs e)
        {
            CategoryPanel = null;
        }

        private void LogoutBTN_Ad_Click(object sender, EventArgs e)
        {
            loginAndRegister = new LoginAndRegister();
            adminPanal.Hide();
            adminPanal.Close();
            loginAndRegister.Show();
        }

        private void but_Best_Seller_Ad_Click(object sender, EventArgs e)
        {
          
            if (BestSellerPanel == null)
            {
                BestSellerPanel = new BestSellerPanel();
                BestSellerPanel.FormClosed += BestSellerClosed;
                BestSellerPanel.MdiParent = adminPanal;
                BestSellerPanel.Dock = DockStyle.Fill;
                BestSellerPanel.Show();
            }
            else
            {
                BestSellerPanel.Activate();
            }
        }

        private void BestSellerClosed(object? sender, FormClosedEventArgs e)
        {
            BestSellerPanel = null;
        }

        private void but_edit_or_delete_Prod_Ad_Click(object sender, EventArgs e)
        {
           
            if (EditProductPanel == null)
            {
                EditProductPanel = new EditProductPanel();
                EditProductPanel.FormClosed += EditProductClosed;
                EditProductPanel.MdiParent = adminPanal;
                EditProductPanel.Dock = DockStyle.Fill;
                EditProductPanel.Show();
            }
            else
            {
                EditProductPanel.Activate();
            }
        }

        private void EditProductClosed(object? sender, FormClosedEventArgs e)
        {
            EditProductPanel = null;
        }

        private void but_Show_all_products_Click(object sender, EventArgs e)
        {
            
                 if (ProductPanel == null)
                {
                    ProductPanel = new ProductPanel();
                    ProductPanel.FormClosed += ProductClosed;
                    ProductPanel.MdiParent = adminPanal;
                    ProductPanel.Dock = DockStyle.Fill;
                    ProductPanel.Show();
                }
                else
                {
                    ProductPanel.Activate();
                }


        }

        private void ProductClosed(object? sender, FormClosedEventArgs e)
        {
            ProductPanel = null;
        }

        private void but_All_orders_Click(object sender, EventArgs e)
        {
            
            if (AllOrdersPanal == null)
            {
                AllOrdersPanal = new AllOrdersPanal();
                AllOrdersPanal.FormClosed += AllOrdersClosed;
                AllOrdersPanal.MdiParent = adminPanal;
                AllOrdersPanal.Dock = DockStyle.Fill;
                AllOrdersPanal.Show();
            }
            else
            {
                AllOrdersPanal.Activate();
            }
        }

        private void AllOrdersClosed(object? sender, FormClosedEventArgs e)
        {
            AllOrdersPanal = null;
        }

        private void Butt_Order_Status_Ad_Click(object sender, EventArgs e)
        {
            
            if (OrderStatusPanel == null)
            {
                OrderStatusPanel = new OrderStatusPanel();
                OrderStatusPanel.FormClosed += OrderStatusClosed;
                OrderStatusPanel.MdiParent = adminPanal;
                OrderStatusPanel.Dock = DockStyle.Fill;
                OrderStatusPanel.Show();
            }
            else
            {
                OrderStatusPanel.Activate();
            }

        }

        private void OrderStatusClosed(object? sender, FormClosedEventArgs e)
        {
            OrderStatusPanel = null;
        }
    }
}
