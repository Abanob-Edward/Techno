namespace Presentation
{
    partial class CategoryPanel
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
            label1 = new Label();
            CatNameTxt1 = new TextBox();
            CatTybetxt1 = new TextBox();
            AddCategory = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            CatTybetxt2 = new TextBox();
            CatNameTxt2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            UpdateBTN = new Button();
            DeleteBtn = new Button();
            ErrorMessage = new Label();
            label2 = new Label();
            CategoryDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CategoryDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(238, 238, 238);
            label1.Location = new Point(70, 467);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 0;
            label1.Text = "Catagory Name :";
            // 
            // CatNameTxt1
            // 
            CatNameTxt1.BackColor = Color.FromArgb(238, 238, 238);
            CatNameTxt1.Location = new Point(240, 468);
            CatNameTxt1.Margin = new Padding(3, 4, 3, 4);
            CatNameTxt1.Name = "CatNameTxt1";
            CatNameTxt1.Size = new Size(217, 27);
            CatNameTxt1.TabIndex = 3;
            // 
            // CatTybetxt1
            // 
            CatTybetxt1.BackColor = Color.FromArgb(238, 238, 238);
            CatTybetxt1.Location = new Point(638, 468);
            CatTybetxt1.Margin = new Padding(3, 4, 3, 4);
            CatTybetxt1.Name = "CatTybetxt1";
            CatTybetxt1.Size = new Size(249, 27);
            CatTybetxt1.TabIndex = 5;
            // 
            // AddCategory
            // 
            AddCategory.BackColor = Color.FromArgb(214, 90, 49);
            AddCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddCategory.ForeColor = Color.Transparent;
            AddCategory.Location = new Point(26, 401);
            AddCategory.Margin = new Padding(3, 4, 3, 4);
            AddCategory.Name = "AddCategory";
            AddCategory.Size = new Size(177, 49);
            AddCategory.TabIndex = 6;
            AddCategory.Text = "Add";
            AddCategory.UseVisualStyleBackColor = false;
            AddCategory.Click += AddCategory_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(214, 90, 49);
            label4.Location = new Point(469, 9);
            label4.Name = "label4";
            label4.Size = new Size(166, 38);
            label4.TabIndex = 15;
            label4.Text = "Categories ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(214, 90, 49);
            label5.Location = new Point(44, 59);
            label5.Name = "label5";
            label5.Size = new Size(208, 31);
            label5.TabIndex = 16;
            label5.Text = "Search BY Name :";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(238, 238, 238);
            textBox4.Location = new Point(273, 63);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(737, 27);
            textBox4.TabIndex = 17;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // CatTybetxt2
            // 
            CatTybetxt2.BackColor = Color.FromArgb(238, 238, 238);
            CatTybetxt2.Location = new Point(638, 576);
            CatTybetxt2.Margin = new Padding(3, 4, 3, 4);
            CatTybetxt2.Name = "CatTybetxt2";
            CatTybetxt2.Size = new Size(249, 27);
            CatTybetxt2.TabIndex = 21;
            // 
            // CatNameTxt2
            // 
            CatNameTxt2.BackColor = Color.FromArgb(238, 238, 238);
            CatNameTxt2.Location = new Point(240, 576);
            CatNameTxt2.Margin = new Padding(3, 4, 3, 4);
            CatNameTxt2.Name = "CatNameTxt2";
            CatNameTxt2.Size = new Size(217, 27);
            CatNameTxt2.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(238, 238, 238);
            label6.Location = new Point(463, 576);
            label6.Name = "label6";
            label6.Size = new Size(154, 28);
            label6.TabIndex = 19;
            label6.Text = "Category Type :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(238, 238, 238);
            label7.Location = new Point(70, 575);
            label7.Name = "label7";
            label7.Size = new Size(164, 28);
            label7.TabIndex = 18;
            label7.Text = "Catagory Name :";
            // 
            // UpdateBTN
            // 
            UpdateBTN.BackColor = Color.FromArgb(214, 90, 49);
            UpdateBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBTN.ForeColor = Color.Transparent;
            UpdateBTN.Location = new Point(26, 508);
            UpdateBTN.Margin = new Padding(3, 4, 3, 4);
            UpdateBTN.Name = "UpdateBTN";
            UpdateBTN.Size = new Size(177, 49);
            UpdateBTN.TabIndex = 22;
            UpdateBTN.Text = "Update";
            UpdateBTN.UseVisualStyleBackColor = false;
            UpdateBTN.Click += UpdateBTN_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(214, 90, 49);
            DeleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(26, 617);
            DeleteBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(177, 49);
            DeleteBtn.TabIndex = 23;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSize = true;
            ErrorMessage.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ErrorMessage.ForeColor = Color.Red;
            ErrorMessage.Location = new Point(365, 405);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(0, 41);
            ErrorMessage.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(238, 238, 238);
            label2.Location = new Point(463, 468);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 1;
            label2.Text = "Category Type :";
            // 
            // CategoryDGV
            // 
            CategoryDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CategoryDGV.BackgroundColor = Color.FromArgb(238, 238, 238);
            CategoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryDGV.Location = new Point(107, 104);
            CategoryDGV.Name = "CategoryDGV";
            CategoryDGV.RowHeadersWidth = 51;
            CategoryDGV.Size = new Size(903, 290);
            CategoryDGV.TabIndex = 25;
            CategoryDGV.RowHeaderMouseClick += CategoryDGV_RowHeaderMouseClick_1;
            // 
            // CategoryPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(1102, 690);
            Controls.Add(CategoryDGV);
            Controls.Add(ErrorMessage);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBTN);
            Controls.Add(CatTybetxt2);
            Controls.Add(CatNameTxt2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(AddCategory);
            Controls.Add(CatTybetxt1);
            Controls.Add(CatNameTxt1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CategoryPanel";
            Text = "Catgory";
            Load += CategoryPanel_Load;
            ((System.ComponentModel.ISupportInitialize)CategoryDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox CatNameTxt1;
        private TextBox CatTybetxt1;
        private Button AddCategory;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private TextBox CatTybetxt2;
        private TextBox CatNameTxt2;
        private Label label6;
        private Label label7;
        private Button UpdateBTN;
        private Button DeleteBtn;
        private Label ErrorMessage;
        private Label label2;
        private DataGridView CategoryDGV;
    }
}