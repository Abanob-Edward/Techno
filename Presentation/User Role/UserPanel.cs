using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Presentation.User_Role
{
    public partial class UserPanel : Form
    {
        public int currentUserId;
        uHomePanel? uHomePanel;
        OrderPanel? orderPanel;
        CartItemPanel? cartItemPanel;
        userProfielPanel? userProfielPanel;

        public UserPanel(string? username = " Costomer", int USerid = 1)
        {

            InitializeComponent();
            UserName.Text = "Welcome " + username;
            currentUserId= USerid;
            // LoadHome(USerid);
        }

        private void BtnSideBar_Click(object sender, EventArgs e)
        {
            SideBarTransition.Start();
        }

        private void uHomePanelClosed(object? sender, FormClosedEventArgs e)
        {
            uHomePanel = null;
        }

        private void orderPanellClosed(object? sender, FormClosedEventArgs e)
        {
            orderPanel = null;

        }
        private void cartItemPanellClosed(object? sender, FormClosedEventArgs e)
        {
            cartItemPanel = null;
        }
        private void userProfielPanellClosed(object? sender, FormClosedEventArgs e)
        {
            userProfielPanel = null;
        }


        bool SideBarExpand = true;


        private void SideBarTransition_Tick_1(object sender, EventArgs e)
        {
            if (SideBarExpand)
            {
                sideBar.Width -= 12;
                if (sideBar.Width <= 66)
                {
                    SideBarExpand = false;
                    SideBarTransition.Stop();
                }
            }
            else
            {
                sideBar.Width += 12;
                if (sideBar.Width >= 280)
                {
                    SideBarExpand = true;
                    SideBarTransition.Stop();

                }
            }
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            if (uHomePanel == null)
            {
                uHomePanel = new uHomePanel(this, currentUserId);
                uHomePanel.FormClosed += uHomePanelClosed;
                uHomePanel.MdiParent = this;
                uHomePanel.Dock = DockStyle.Fill;
                uHomePanel.Show();
            }
            else
            {
                uHomePanel.Activate();
            }
        }


        private void LoadHome(int userID)
        {
            if (uHomePanel == null)
            {
                uHomePanel = new uHomePanel(this,userID);
                uHomePanel.FormClosed += uHomePanelClosed;
                uHomePanel.MdiParent = this;
                uHomePanel.Dock = DockStyle.Fill;
                uHomePanel.Show();
            }
            else
            {
                uHomePanel.Activate();
            }
        }

        private void CartItemsBTN_Click(object sender, EventArgs e)
        {

            if (cartItemPanel == null)
            {
                cartItemPanel = new CartItemPanel(currentUserId);
                cartItemPanel.FormClosed += cartItemPanellClosed;
                cartItemPanel.MdiParent = this;
                cartItemPanel.Dock = DockStyle.Fill;
                cartItemPanel.Show();
            }
            else
            {
                cartItemPanel.Activate();
            }
        }


        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            if (orderPanel == null)
            {
                orderPanel = new OrderPanel();
                orderPanel.FormClosed += orderPanellClosed;
                orderPanel.MdiParent = this;
                orderPanel.Dock = DockStyle.Fill;
                orderPanel.Show();
            }
            else
            {
                orderPanel.Activate();
            }
        }

        private void LogoutBTN_Click(object sender, EventArgs e)
        {

            LoginAndRegister loginAndRegister = new LoginAndRegister();
            this.Hide();
            loginAndRegister.Show();
            //  this.Close();
        }

        private void ProfileBTN_Click(object sender, EventArgs e)
        {
            if (userProfielPanel == null)
            {
                userProfielPanel = new userProfielPanel(currentUserId);
                userProfielPanel.FormClosed += userProfielPanellClosed;
                userProfielPanel.MdiParent = this;
                userProfielPanel.Dock = DockStyle.Fill;
                userProfielPanel.Show();
            }
            else
            {
                userProfielPanel.Activate();
            }
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            LoadHome(currentUserId);
        }
    }
}
