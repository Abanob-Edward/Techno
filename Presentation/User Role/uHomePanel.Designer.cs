namespace Presentation.User_Role
{
    partial class uHomePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uHomePanel));
            label1 = new Label();
            ProductsDGV = new DataGridView();
            Success = new Label();
            NextBtn = new Button();
            previousBtn = new Button();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            searchBox = new TextBox();
            Search = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductsDGV).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 10, 42, 155);
            label1.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(33, 42, 81);
            label1.Location = new Point(60, 39);
            label1.Name = "label1";
            label1.Size = new Size(243, 31);
            label1.TabIndex = 0;
            label1.Text = "Customer Home page";
            // 
            // ProductsDGV
            // 
            ProductsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDGV.BackgroundColor = Color.Linen;
            ProductsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDGV.Location = new Point(29, 108);
            ProductsDGV.Name = "ProductsDGV";
            ProductsDGV.RowHeadersWidth = 51;
            ProductsDGV.RowTemplate.Height = 120;
            ProductsDGV.Size = new Size(1160, 548);
            ProductsDGV.TabIndex = 1;
            ProductsDGV.CellClick += ProductsDGV_CellClick;
            // 
            // Success
            // 
            Success.AutoSize = true;
            Success.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Success.Location = new Point(288, 70);
            Success.Name = "Success";
            Success.Size = new Size(0, 35);
            Success.TabIndex = 2;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.FromArgb(33, 42, 81);
            NextBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NextBtn.ForeColor = Color.White;
            NextBtn.Location = new Point(648, 662);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(160, 59);
            NextBtn.TabIndex = 3;
            NextBtn.Text = "Next";
            NextBtn.UseVisualStyleBackColor = false;
            NextBtn.Click += NextBtn_Click;
            // 
            // previousBtn
            // 
            previousBtn.BackColor = Color.FromArgb(33, 42, 81);
            previousBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            previousBtn.ForeColor = Color.White;
            previousBtn.Location = new Point(386, 662);
            previousBtn.Name = "previousBtn";
            previousBtn.Size = new Size(143, 62);
            previousBtn.TabIndex = 4;
            previousBtn.Text = "Previou";
            previousBtn.UseVisualStyleBackColor = false;
            previousBtn.Click += previousBtn_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox1);
            panel7.Controls.Add(searchBox);
            panel7.Controls.Add(Search);
            panel7.Location = new Point(334, 49);
            panel7.Name = "panel7";
            panel7.Size = new Size(788, 36);
            panel7.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(730, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(111, 5);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(613, 27);
            searchBox.TabIndex = 5;
            searchBox.TextChanged += textBox1_TextChanged;
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.BackColor = Color.Transparent;
            Search.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Search.ForeColor = Color.Navy;
            Search.Location = new Point(0, 0);
            Search.Name = "Search";
            Search.Size = new Size(105, 33);
            Search.TabIndex = 3;
            Search.Text = "Search :";
            // 
            // uHomePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(189, 172, 148);
            ClientSize = new Size(1201, 736);
            Controls.Add(panel7);
            Controls.Add(previousBtn);
            Controls.Add(NextBtn);
            Controls.Add(Success);
            Controls.Add(ProductsDGV);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "uHomePanel";
            Text = "uHomePanel";
            Load += uHomePanel_Load;
            ((System.ComponentModel.ISupportInitialize)ProductsDGV).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView ProductsDGV;
        private Label Success;
        private Button NextBtn;
        private Button previousBtn;
        private Panel panel7;
        private PictureBox pictureBox1;
        private TextBox searchBox;
        private Label Search;
    }
}