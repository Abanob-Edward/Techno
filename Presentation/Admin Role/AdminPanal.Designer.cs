namespace Presentation
{
    partial class AdminPanal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanal));
            panel1 = new Panel();
            AdminName = new Label();
            label1 = new Label();
            BtnSideBar = new PictureBox();
            sideBar = new FlowLayoutPanel();
            panel4 = new Panel();
            HomeBTN = new Button();
            panel2 = new Panel();
            CategoryBTN = new Button();
            CategoryMenu = new FlowLayoutPanel();
            panel5 = new Panel();
            ProMenuBtn = new Button();
            panel7 = new Panel();
            ShowALLProduct = new Button();
            panel8 = new Panel();
            EditProduct = new Button();
            OrderMenu = new FlowLayoutPanel();
            panel9 = new Panel();
            OrderBTN = new Button();
            panel10 = new Panel();
            OrderStatusBTN = new Button();
            panel11 = new Panel();
            AllOrders = new Button();
            panel6 = new Panel();
            BestSeller = new Button();
            panel3 = new Panel();
            LogoutBTN = new Button();
            CategoryTransition = new System.Windows.Forms.Timer(components);
            SideBarTransition = new System.Windows.Forms.Timer(components);
            OrderTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSideBar).BeginInit();
            sideBar.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            CategoryMenu.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            OrderMenu.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(AdminName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnSideBar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1531, 60);
            panel1.TabIndex = 0;
            // 
            // AdminName
            // 
            AdminName.AutoSize = true;
            AdminName.BackColor = Color.White;
            AdminName.Font = new Font("Stencil", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            AdminName.ForeColor = Color.Navy;
            AdminName.Location = new Point(1002, 9);
            AdminName.Name = "AdminName";
            AdminName.Size = new Size(0, 40);
            AdminName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(86, 3);
            label1.Name = "label1";
            label1.Size = new Size(329, 54);
            label1.TabIndex = 1;
            label1.Text = "TECHNO SHOP";
            // 
            // BtnSideBar
            // 
            BtnSideBar.Image = (Image)resources.GetObject("BtnSideBar.Image");
            BtnSideBar.Location = new Point(5, 9);
            BtnSideBar.Name = "BtnSideBar";
            BtnSideBar.Size = new Size(54, 44);
            BtnSideBar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnSideBar.TabIndex = 1;
            BtnSideBar.TabStop = false;
            BtnSideBar.Click += BtnSideBar_Click;
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.FromArgb(34, 40, 49);
            sideBar.Controls.Add(panel4);
            sideBar.Controls.Add(panel2);
            sideBar.Controls.Add(CategoryMenu);
            sideBar.Controls.Add(OrderMenu);
            sideBar.Controls.Add(panel6);
            sideBar.Controls.Add(panel3);
            sideBar.Dock = DockStyle.Left;
            sideBar.FlowDirection = FlowDirection.TopDown;
            sideBar.Location = new Point(0, 60);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(280, 683);
            sideBar.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Controls.Add(HomeBTN);
            panel4.Location = new Point(3, 20);
            panel4.Margin = new Padding(3, 20, 3, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 25, 0, 0);
            panel4.Size = new Size(277, 70);
            panel4.TabIndex = 5;
            // 
            // HomeBTN
            // 
            HomeBTN.BackColor = Color.FromArgb(34, 40, 49);
            HomeBTN.Font = new Font("Snap ITC", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            HomeBTN.ForeColor = SystemColors.ControlLightLight;
            HomeBTN.Image = (Image)resources.GetObject("HomeBTN.Image");
            HomeBTN.ImageAlign = ContentAlignment.MiddleLeft;
            HomeBTN.Location = new Point(-9, -11);
            HomeBTN.Name = "HomeBTN";
            HomeBTN.Padding = new Padding(10, 0, 0, 0);
            HomeBTN.Size = new Size(321, 100);
            HomeBTN.TabIndex = 2;
            HomeBTN.Text = "        Home";
            HomeBTN.TextAlign = ContentAlignment.MiddleLeft;
            HomeBTN.UseVisualStyleBackColor = false;
            HomeBTN.Click += HomeBTN_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(CategoryBTN);
            panel2.Location = new Point(3, 96);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 25, 0, 0);
            panel2.Size = new Size(277, 67);
            panel2.TabIndex = 6;
            // 
            // CategoryBTN
            // 
            CategoryBTN.BackColor = Color.FromArgb(34, 40, 49);
            CategoryBTN.Font = new Font("Snap ITC", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CategoryBTN.ForeColor = SystemColors.ControlLightLight;
            CategoryBTN.Image = (Image)resources.GetObject("CategoryBTN.Image");
            CategoryBTN.ImageAlign = ContentAlignment.MiddleLeft;
            CategoryBTN.Location = new Point(-5, -16);
            CategoryBTN.Name = "CategoryBTN";
            CategoryBTN.Padding = new Padding(10, 0, 0, 0);
            CategoryBTN.Size = new Size(321, 100);
            CategoryBTN.TabIndex = 8;
            CategoryBTN.Text = "       Category";
            CategoryBTN.TextAlign = ContentAlignment.MiddleLeft;
            CategoryBTN.UseVisualStyleBackColor = false;
            CategoryBTN.Click += CategoryBTN1_Click;
            // 
            // CategoryMenu
            // 
            CategoryMenu.BackColor = SystemColors.ActiveCaptionText;
            CategoryMenu.Controls.Add(panel5);
            CategoryMenu.Controls.Add(panel7);
            CategoryMenu.Controls.Add(panel8);
            CategoryMenu.Location = new Point(3, 169);
            CategoryMenu.Name = "CategoryMenu";
            CategoryMenu.Size = new Size(277, 72);
            CategoryMenu.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Controls.Add(ProMenuBtn);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 25, 0, 0);
            panel5.Size = new Size(280, 70);
            panel5.TabIndex = 6;
            // 
            // ProMenuBtn
            // 
            ProMenuBtn.BackColor = Color.FromArgb(34, 40, 49);
            ProMenuBtn.Font = new Font("Snap ITC", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ProMenuBtn.ForeColor = SystemColors.ControlLightLight;
            ProMenuBtn.Image = (Image)resources.GetObject("ProMenuBtn.Image");
            ProMenuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ProMenuBtn.Location = new Point(-17, -17);
            ProMenuBtn.Name = "ProMenuBtn";
            ProMenuBtn.Padding = new Padding(10, 0, 0, 0);
            ProMenuBtn.Size = new Size(326, 100);
            ProMenuBtn.TabIndex = 2;
            ProMenuBtn.Text = "        Product";
            ProMenuBtn.TextAlign = ContentAlignment.MiddleLeft;
            ProMenuBtn.UseVisualStyleBackColor = false;
            ProMenuBtn.Click += CatMenuBtn_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(64, 64, 64);
            panel7.Controls.Add(ShowALLProduct);
            panel7.Location = new Point(3, 79);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(0, 25, 0, 0);
            panel7.Size = new Size(280, 55);
            panel7.TabIndex = 8;
            // 
            // ShowALLProduct
            // 
            ShowALLProduct.BackColor = Color.FromArgb(64, 64, 64);
            ShowALLProduct.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowALLProduct.ForeColor = SystemColors.ControlLightLight;
            ShowALLProduct.ImageAlign = ContentAlignment.MiddleLeft;
            ShowALLProduct.Location = new Point(-8, -18);
            ShowALLProduct.Name = "ShowALLProduct";
            ShowALLProduct.Padding = new Padding(10, 0, 0, 0);
            ShowALLProduct.Size = new Size(321, 100);
            ShowALLProduct.TabIndex = 2;
            ShowALLProduct.Text = " Show All Products";
            ShowALLProduct.TextAlign = ContentAlignment.MiddleLeft;
            ShowALLProduct.UseVisualStyleBackColor = false;
            ShowALLProduct.Click += ShowALLProduct_Click;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaptionText;
            panel8.Controls.Add(EditProduct);
            panel8.Location = new Point(3, 140);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(0, 25, 0, 0);
            panel8.Size = new Size(280, 55);
            panel8.TabIndex = 9;
            // 
            // EditProduct
            // 
            EditProduct.BackColor = Color.FromArgb(64, 64, 64);
            EditProduct.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            EditProduct.ForeColor = SystemColors.ControlLightLight;
            EditProduct.ImageAlign = ContentAlignment.MiddleLeft;
            EditProduct.Location = new Point(-8, -18);
            EditProduct.Name = "EditProduct";
            EditProduct.Padding = new Padding(10, 0, 0, 0);
            EditProduct.Size = new Size(321, 100);
            EditProduct.TabIndex = 2;
            EditProduct.Text = "Edit | Delete Product";
            EditProduct.TextAlign = ContentAlignment.MiddleLeft;
            EditProduct.UseVisualStyleBackColor = false;
            EditProduct.Click += ProOutOfStock_Click;
            // 
            // OrderMenu
            // 
            OrderMenu.BackColor = SystemColors.ActiveCaptionText;
            OrderMenu.Controls.Add(panel9);
            OrderMenu.Controls.Add(panel10);
            OrderMenu.Controls.Add(panel11);
            OrderMenu.Location = new Point(3, 247);
            OrderMenu.Name = "OrderMenu";
            OrderMenu.Size = new Size(277, 68);
            OrderMenu.TabIndex = 8;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ActiveCaptionText;
            panel9.Controls.Add(OrderBTN);
            panel9.Location = new Point(3, 3);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(0, 25, 0, 0);
            panel9.Size = new Size(280, 70);
            panel9.TabIndex = 6;
            // 
            // OrderBTN
            // 
            OrderBTN.BackColor = Color.FromArgb(34, 40, 49);
            OrderBTN.Font = new Font("Snap ITC", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            OrderBTN.ForeColor = SystemColors.ControlLightLight;
            OrderBTN.Image = (Image)resources.GetObject("OrderBTN.Image");
            OrderBTN.ImageAlign = ContentAlignment.MiddleLeft;
            OrderBTN.Location = new Point(-11, -19);
            OrderBTN.Name = "OrderBTN";
            OrderBTN.Padding = new Padding(10, 0, 0, 0);
            OrderBTN.Size = new Size(328, 100);
            OrderBTN.TabIndex = 2;
            OrderBTN.Text = "        Orders";
            OrderBTN.TextAlign = ContentAlignment.MiddleLeft;
            OrderBTN.UseVisualStyleBackColor = false;
            OrderBTN.Click += OrderBTN_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(64, 64, 64);
            panel10.Controls.Add(OrderStatusBTN);
            panel10.Location = new Point(3, 79);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(0, 25, 0, 0);
            panel10.Size = new Size(280, 55);
            panel10.TabIndex = 8;
            // 
            // OrderStatusBTN
            // 
            OrderStatusBTN.BackColor = Color.FromArgb(64, 64, 64);
            OrderStatusBTN.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderStatusBTN.ForeColor = SystemColors.ControlLightLight;
            OrderStatusBTN.ImageAlign = ContentAlignment.MiddleLeft;
            OrderStatusBTN.Location = new Point(-8, -18);
            OrderStatusBTN.Name = "OrderStatusBTN";
            OrderStatusBTN.Padding = new Padding(10, 0, 0, 0);
            OrderStatusBTN.Size = new Size(321, 100);
            OrderStatusBTN.TabIndex = 2;
            OrderStatusBTN.Text = "Order status";
            OrderStatusBTN.TextAlign = ContentAlignment.MiddleLeft;
            OrderStatusBTN.UseVisualStyleBackColor = false;
            OrderStatusBTN.Click += OrderStatusBTN_Click;
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.ActiveCaptionText;
            panel11.Controls.Add(AllOrders);
            panel11.Location = new Point(3, 140);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(0, 25, 0, 0);
            panel11.Size = new Size(280, 55);
            panel11.TabIndex = 9;
            // 
            // AllOrders
            // 
            AllOrders.BackColor = Color.FromArgb(64, 64, 64);
            AllOrders.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            AllOrders.ForeColor = SystemColors.ControlLightLight;
            AllOrders.ImageAlign = ContentAlignment.MiddleLeft;
            AllOrders.Location = new Point(-8, -18);
            AllOrders.Name = "AllOrders";
            AllOrders.Padding = new Padding(10, 0, 0, 0);
            AllOrders.Size = new Size(321, 100);
            AllOrders.TabIndex = 2;
            AllOrders.Text = "All Orders";
            AllOrders.TextAlign = ContentAlignment.MiddleLeft;
            AllOrders.UseVisualStyleBackColor = false;
            AllOrders.Click += AllOrders_Click;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Controls.Add(BestSeller);
            panel6.Location = new Point(3, 321);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 25, 0, 0);
            panel6.Size = new Size(277, 67);
            panel6.TabIndex = 6;
            // 
            // BestSeller
            // 
            BestSeller.BackColor = Color.FromArgb(34, 40, 49);
            BestSeller.Font = new Font("Snap ITC", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BestSeller.ForeColor = SystemColors.ControlLightLight;
            BestSeller.Image = (Image)resources.GetObject("BestSeller.Image");
            BestSeller.ImageAlign = ContentAlignment.MiddleLeft;
            BestSeller.Location = new Point(-11, -18);
            BestSeller.Name = "BestSeller";
            BestSeller.Padding = new Padding(10, 0, 0, 0);
            BestSeller.Size = new Size(321, 100);
            BestSeller.TabIndex = 2;
            BestSeller.Text = "        Best Seller";
            BestSeller.TextAlign = ContentAlignment.MiddleLeft;
            BestSeller.UseVisualStyleBackColor = false;
            BestSeller.Click += BestSeller_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(LogoutBTN);
            panel3.Location = new Point(3, 394);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 25, 0, 0);
            panel3.Size = new Size(277, 67);
            panel3.TabIndex = 6;
            // 
            // LogoutBTN
            // 
            LogoutBTN.BackColor = Color.FromArgb(34, 40, 49);
            LogoutBTN.Font = new Font("Snap ITC", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LogoutBTN.ForeColor = SystemColors.ControlLightLight;
            LogoutBTN.Image = (Image)resources.GetObject("LogoutBTN.Image");
            LogoutBTN.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutBTN.Location = new Point(-8, -17);
            LogoutBTN.Name = "LogoutBTN";
            LogoutBTN.Padding = new Padding(10, 0, 0, 0);
            LogoutBTN.Size = new Size(321, 100);
            LogoutBTN.TabIndex = 2;
            LogoutBTN.Text = "        Logout";
            LogoutBTN.TextAlign = ContentAlignment.MiddleLeft;
            LogoutBTN.UseVisualStyleBackColor = false;
            LogoutBTN.Click += LogoutBTN_Click;
            // 
            // CategoryTransition
            // 
            CategoryTransition.Interval = 10;
            CategoryTransition.Tick += CategoryTransition_Tick;
            // 
            // SideBarTransition
            // 
            SideBarTransition.Interval = 10;
            SideBarTransition.Tick += SideBarTransition_Tick;
            // 
            // OrderTransition
            // 
            OrderTransition.Interval = 10;
            OrderTransition.Tick += OrderTransition_Tick;
            // 
            // AdminPanal
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(1531, 743);
            Controls.Add(sideBar);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "AdminPanal";
            Text = "Admin";
            Load += AdminPanal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSideBar).EndInit();
            sideBar.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            CategoryMenu.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            OrderMenu.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox BtnSideBar;
        private FlowLayoutPanel sideBar;
        private Panel panel4;
        private Button HomeBTN;
        private Panel panel2;
        private Button Category;
        private Panel panel3;
        private Button LogoutBTN;
        private Panel panel5;
        private Button ProMenuBtn;
        private FlowLayoutPanel CategoryMenu;
        private Panel panel7;
        private Button ShowALLProduct;
        private Panel panel8;
        private Button EditProduct;
        private System.Windows.Forms.Timer CategoryTransition;
        private System.Windows.Forms.Timer SideBarTransition;
        private Button CategoryBTN;
        private FlowLayoutPanel OrderMenu;
        private Panel panel9;
        private Button OrderBTN;
        private Panel panel10;
        private Button OrderStatusBTN;
        private Panel panel11;
        private Button AllOrders;
        private System.Windows.Forms.Timer OrderTransition;
        private Button BestSeller;
        private Panel panel6;
        private Label AdminName;
    }
}
