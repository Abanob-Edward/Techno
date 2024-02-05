namespace Presentation
{
    partial class ProductPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPanel));
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            ProductpictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductpictureBox).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(238, 238, 238);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 112);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(993, 266);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(214, 90, 49);
            label1.Location = new Point(13, 441);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 2;
            label1.Text = "Name ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(214, 90, 49);
            label2.Location = new Point(13, 541);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 3;
            label2.Text = "Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(214, 90, 49);
            label3.Location = new Point(377, 435);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 4;
            label3.Text = "Tilttel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(214, 90, 49);
            label4.Location = new Point(384, 541);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 28);
            label4.TabIndex = 5;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(214, 90, 49);
            label5.Location = new Point(681, 432);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 28);
            label5.TabIndex = 6;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(214, 90, 49);
            label6.Location = new Point(746, 547);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 28);
            label6.TabIndex = 7;
            label6.Text = "Image";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(238, 238, 238);
            textBox1.Location = new Point(122, 435);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 34);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(238, 238, 238);
            textBox2.Location = new Point(122, 541);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 34);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(238, 238, 238);
            textBox3.Location = new Point(474, 429);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 34);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(238, 238, 238);
            textBox4.Location = new Point(474, 535);
            textBox4.Margin = new Padding(4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 34);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(238, 238, 238);
            textBox5.Location = new Point(846, 426);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(148, 34);
            textBox5.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(214, 90, 49);
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.ForeColor = Color.FromArgb(238, 238, 238);
            button2.Location = new Point(538, 599);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(157, 77);
            button2.TabIndex = 14;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Add_Product;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(238, 238, 238);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(189, 623);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(284, 36);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(214, 90, 49);
            label7.Location = new Point(12, 623);
            label7.Name = "label7";
            label7.Size = new Size(167, 28);
            label7.TabIndex = 16;
            label7.Text = "Choese Category";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(76, 714);
            label8.Name = "label8";
            label8.Size = new Size(66, 28);
            label8.TabIndex = 17;
            label8.Text = "label8";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Thistle;
            textBox7.Location = new Point(204, 711);
            textBox7.Margin = new Padding(4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(917, 34);
            textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(238, 238, 238);
            textBox8.Location = new Point(409, 56);
            textBox8.Margin = new Padding(4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(531, 34);
            textBox8.TabIndex = 19;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(214, 90, 49);
            label9.Location = new Point(176, 56);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(206, 27);
            label9.TabIndex = 20;
            label9.Text = "Search in prouduct :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Wide Latin", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(214, 90, 49);
            label10.Location = new Point(538, 9);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(205, 24);
            label10.TabIndex = 21;
            label10.Text = " Prouducts";
            // 
            // ProductpictureBox
            // 
            ProductpictureBox.BackColor = Color.FromArgb(57, 62, 70);
            ProductpictureBox.BorderStyle = BorderStyle.FixedSingle;
            ProductpictureBox.Image = (Image)resources.GetObject("ProductpictureBox.Image");
            ProductpictureBox.Location = new Point(846, 518);
            ProductpictureBox.Name = "ProductpictureBox";
            ProductpictureBox.Size = new Size(180, 160);
            ProductpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductpictureBox.TabIndex = 22;
            ProductpictureBox.TabStop = false;
            ProductpictureBox.Click += ProductpictureBox_Click;
            // 
            // ProductPanel
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(1102, 690);
            Controls.Add(ProductpictureBox);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ProductPanel";
            Text = "Product";
            Load += Product_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button2;
        private ComboBox comboBox1;
        private Label label7;
        private Label label8;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label9;
        private Label label10;
        private PictureBox ProductpictureBox;
    }
}