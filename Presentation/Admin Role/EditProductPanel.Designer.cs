using Presentation.Properties;

namespace Presentation
{
    partial class EditProductPanel
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            Error = new Label();
            comboBox1 = new ComboBox();
            Cat = new Label();
            ProductpictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductpictureBox).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(238, 238, 238);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(990, 290);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowHeaderMouseClick += ProdactDGV_RowHeaderMouseClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(214, 90, 49);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(238, 238, 238);
            button1.Location = new Point(286, 614);
            button1.Name = "button1";
            button1.Size = new Size(123, 49);
            button1.TabIndex = 1;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Proudect_delet;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(214, 90, 49);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(238, 238, 238);
            button2.Location = new Point(552, 614);
            button2.Name = "button2";
            button2.Size = new Size(128, 49);
            button2.TabIndex = 2;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += proudect_Edite;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 388);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 27);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(214, 90, 49);
            label2.Location = new Point(22, 404);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 6;
            label2.Text = "Name:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(460, 388);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(208, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(472, 477);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(208, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(832, 387);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(192, 27);
            textBox5.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(214, 90, 49);
            label3.Location = new Point(376, 387);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 11;
            label3.Text = "Code :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(214, 90, 49);
            label4.Location = new Point(376, 479);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 12;
            label4.Text = "Title :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(214, 90, 49);
            label5.Location = new Point(711, 384);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 13;
            label5.Text = "Price :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(214, 90, 49);
            label6.Location = new Point(711, 476);
            label6.Name = "label6";
            label6.Size = new Size(79, 28);
            label6.TabIndex = 14;
            label6.Text = "image :";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(171, 548);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(619, 27);
            textBox7.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(214, 90, 49);
            label7.Location = new Point(12, 550);
            label7.Name = "label7";
            label7.Size = new Size(116, 25);
            label7.TabIndex = 16;
            label7.Text = "Descraption:";
            // 
            // Error
            // 
            Error.AutoSize = true;
            Error.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Error.ForeColor = Color.FromArgb(192, 0, 0);
            Error.Location = new Point(432, 318);
            Error.Name = "Error";
            Error.Size = new Size(25, 38);
            Error.TabIndex = 17;
            Error.Text = " ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(171, 479);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 28);
            comboBox1.TabIndex = 18;
            // 
            // Cat
            // 
            Cat.AutoSize = true;
            Cat.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            Cat.ForeColor = Color.FromArgb(214, 90, 49);
            Cat.Location = new Point(12, 479);
            Cat.Name = "Cat";
            Cat.Size = new Size(153, 25);
            Cat.TabIndex = 19;
            Cat.Text = "Choese Category";
            // 
            // ProductpictureBox
            // 
            ProductpictureBox.BackColor = Color.FromArgb(57, 62, 70);
            ProductpictureBox.BorderStyle = BorderStyle.FixedSingle;
            ProductpictureBox.Image = Resources._4211763;
            ProductpictureBox.Location = new Point(844, 454);
            ProductpictureBox.Name = "ProductpictureBox";
            ProductpictureBox.Size = new Size(180, 160);
            ProductpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductpictureBox.TabIndex = 22;
            ProductpictureBox.TabStop = false;
            ProductpictureBox.Click += ProductpictureBox_Click_2;
            // 
            // EditProductPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(1102, 690);
            Controls.Add(ProductpictureBox);
            Controls.Add(Cat);
            Controls.Add(comboBox1);
            Controls.Add(Error);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProductPanel";
            Text = "ProductOutOfStocK";
            Load += Product_load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private Label Error;
        private ComboBox comboBox1;
        private Label Cat;
        private PictureBox ProductpictureBox_Click;
        private PictureBox ProductpictureBox;
    }
}