namespace Presentation.User_Role
{
    partial class UserPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            panel1 = new Panel();
            UserName = new Label();
            BtnSideBar = new PictureBox();
            label1 = new Label();
            SideBarTransition = new System.Windows.Forms.Timer(components);
            sideBar = new FlowLayoutPanel();
            panel4 = new Panel();
            HomeBTN = new Button();
            panel6 = new Panel();
            ProfileBTN = new Button();
            panel2 = new Panel();
            CartItemsBTN = new Button();
            panel5 = new Panel();
            OrdersBtn = new Button();
            panel3 = new Panel();
            LogoutBTN = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSideBar).BeginInit();
            sideBar.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(189, 172, 148);
            panel1.Controls.Add(UserName);
            panel1.Controls.Add(BtnSideBar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1677, 60);
            panel1.TabIndex = 1;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Stencil", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            UserName.ForeColor = Color.Navy;
            UserName.Location = new Point(1002, 9);
            UserName.Name = "UserName";
            UserName.Size = new Size(0, 40);
            UserName.TabIndex = 2;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(33, 42, 81);
            label1.Location = new Point(81, 16);
            label1.Name = "label1";
            label1.Size = new Size(232, 37);
            label1.TabIndex = 1;
            label1.Text = "TECHNO SHOP";
            // 
            // SideBarTransition
            // 
            SideBarTransition.Interval = 10;
            SideBarTransition.Tick += SideBarTransition_Tick_1;
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.FromArgb(33, 42, 81);
            sideBar.Controls.Add(panel4);
            sideBar.Controls.Add(panel6);
            sideBar.Controls.Add(panel2);
            sideBar.Controls.Add(panel5);
            sideBar.Controls.Add(panel3);
            sideBar.Dock = DockStyle.Left;
            sideBar.FlowDirection = FlowDirection.TopDown;
            sideBar.Location = new Point(0, 60);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(280, 777);
            sideBar.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Controls.Add(HomeBTN);
            panel4.Location = new Point(3, 20);
            panel4.Margin = new Padding(3, 20, 3, 20);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 25, 0, 0);
            panel4.Size = new Size(277, 70);
            panel4.TabIndex = 5;
            // 
            // HomeBTN
            // 
            HomeBTN.BackColor = Color.FromArgb(33, 42, 81);
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
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Controls.Add(ProfileBTN);
            panel6.Location = new Point(3, 113);
            panel6.Margin = new Padding(3, 3, 3, 20);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 25, 0, 0);
            panel6.Size = new Size(277, 67);
            panel6.TabIndex = 6;
            // 
            // ProfileBTN
            // 
            ProfileBTN.BackColor = Color.FromArgb(33, 42, 81);
            ProfileBTN.Font = new Font("Snap ITC", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ProfileBTN.ForeColor = SystemColors.ControlLightLight;
            ProfileBTN.Image = (Image)resources.GetObject("ProfileBTN.Image");
            ProfileBTN.ImageAlign = ContentAlignment.MiddleLeft;
            ProfileBTN.Location = new Point(-11, -18);
            ProfileBTN.Name = "ProfileBTN";
            ProfileBTN.Padding = new Padding(10, 0, 0, 0);
            ProfileBTN.Size = new Size(321, 100);
            ProfileBTN.TabIndex = 2;
            ProfileBTN.Text = "        Profile";
            ProfileBTN.TextAlign = ContentAlignment.MiddleLeft;
            ProfileBTN.UseVisualStyleBackColor = false;
            ProfileBTN.Click += ProfileBTN_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(CartItemsBTN);
            panel2.Location = new Point(3, 203);
            panel2.Margin = new Padding(3, 3, 3, 20);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 25, 0, 0);
            panel2.Size = new Size(277, 67);
            panel2.TabIndex = 6;
            // 
            // CartItemsBTN
            // 
            CartItemsBTN.BackColor = Color.FromArgb(33, 42, 81);
            CartItemsBTN.Font = new Font("Snap ITC", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CartItemsBTN.ForeColor = SystemColors.ControlLightLight;
            CartItemsBTN.Image = (Image)resources.GetObject("CartItemsBTN.Image");
            CartItemsBTN.ImageAlign = ContentAlignment.MiddleLeft;
            CartItemsBTN.Location = new Point(-5, -16);
            CartItemsBTN.Name = "CartItemsBTN";
            CartItemsBTN.Padding = new Padding(10, 0, 0, 0);
            CartItemsBTN.Size = new Size(321, 100);
            CartItemsBTN.TabIndex = 8;
            CartItemsBTN.Text = "       Cart Items";
            CartItemsBTN.TextAlign = ContentAlignment.MiddleLeft;
            CartItemsBTN.UseVisualStyleBackColor = false;
            CartItemsBTN.Click += CartItemsBTN_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Controls.Add(OrdersBtn);
            panel5.Location = new Point(3, 293);
            panel5.Margin = new Padding(3, 3, 3, 20);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 25, 0, 0);
            panel5.Size = new Size(277, 67);
            panel5.TabIndex = 7;
            // 
            // OrdersBtn
            // 
            OrdersBtn.BackColor = Color.FromArgb(33, 42, 81);
            OrdersBtn.Font = new Font("Snap ITC", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            OrdersBtn.ForeColor = SystemColors.ControlLightLight;
            OrdersBtn.Image = (Image)resources.GetObject("OrdersBtn.Image");
            OrdersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            OrdersBtn.Location = new Point(-8, -16);
            OrdersBtn.Name = "OrdersBtn";
            OrdersBtn.Padding = new Padding(10, 0, 0, 0);
            OrdersBtn.Size = new Size(321, 100);
            OrdersBtn.TabIndex = 8;
            OrdersBtn.Text = "       Order";
            OrdersBtn.TextAlign = ContentAlignment.MiddleLeft;
            OrdersBtn.UseVisualStyleBackColor = false;
            OrdersBtn.Click += OrdersBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(LogoutBTN);
            panel3.Location = new Point(3, 383);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 25, 0, 0);
            panel3.Size = new Size(277, 67);
            panel3.TabIndex = 6;
            // 
            // LogoutBTN
            // 
            LogoutBTN.BackColor = Color.FromArgb(33, 42, 81);
            LogoutBTN.Font = new Font("Snap ITC", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LogoutBTN.ForeColor = SystemColors.ControlLightLight;
            LogoutBTN.Image = (Image)resources.GetObject("LogoutBTN.Image");
            LogoutBTN.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutBTN.Location = new Point(-8, -13);
            LogoutBTN.Name = "LogoutBTN";
            LogoutBTN.Padding = new Padding(10, 0, 0, 0);
            LogoutBTN.Size = new Size(321, 100);
            LogoutBTN.TabIndex = 2;
            LogoutBTN.Text = "        Logout";
            LogoutBTN.TextAlign = ContentAlignment.MiddleLeft;
            LogoutBTN.UseVisualStyleBackColor = false;
            LogoutBTN.Click += LogoutBTN_Click;
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1677, 837);
            Controls.Add(sideBar);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "UserPanel";
            Text = "Customer";
            Load += UserPanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSideBar).EndInit();
            sideBar.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label UserName;
        private Label label1;
        private PictureBox BtnSideBar;
        private System.Windows.Forms.Timer SideBarTransition;
        private FlowLayoutPanel sideBar;
        private Panel panel4;
        private Button HomeBTN;
        private Panel panel2;
        private Button CartItemsBTN;
        private Panel panel6;
        private Button ProfileBTN;
        private Panel panel3;
        private Button LogoutBTN;
        private Panel panel5;
        private Button OrdersBtn;
    }
}