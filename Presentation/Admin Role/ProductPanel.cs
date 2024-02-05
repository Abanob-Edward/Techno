using Appliaction.Services;
using Context;
using Infrastructure.Repositores;
using Microsoft.EntityFrameworkCore;
using Model.Models;
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

namespace Presentation
{
    public partial class ProductPanel : Form
    {
        //private string currentsearchname = " ";
        IProductService ProductService;
        ICategoryService categoryService;
        string selectedProduct = " ";
        string ProductImageSelction = "";
        int currentUserID = 0;
        public ProductPanel(int currentUserID =0)
        {
            InitializeComponent();
            ProductService = new ProductService(new ProudectRepository(new _Context()));
            categoryService = new CategoryService(new CatgoryRepositry(new _Context()));
            loadtabel();
            this.currentUserID = currentUserID;
        }

        public void loadtabel()
        {
            var products = ProductService.GetAlltech()
                .Include(p => p.User)       // Eager load the User navigation property
                .Include(p => p.category)   // Eager load the category navigation property
                .ToList();

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = products.Select(p => new
            {
                p.Id,
                p.Name,
                p.Description,
                p.Price,
                p.Title,
                p.Code,
                p.Image,
                // AdmineName = p.User != null ? p.User.FirstName : "No Admin",
                CategoryName = p.category != null ? p.category.Name : "No Category"
            }).ToList();

            LoadCategories();
        }

        private void LoadCategories()
        {
            List<string> categoryNames = categoryService.GetCategory().Select(c => c.Name).ToList();
            comboBox1.DataSource = categoryNames;
        }
        private void Product_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            loadtabel();
            ;

        }
        string newImageName = "";
        private void Add_Product(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 
                && textBox4.Text.Length > 0 && textBox5.Text.Length > 0)
            {
                string productName = textBox1.Text;
                int productcode = int.Parse(textBox2.Text);
                string prouductTitle = textBox3.Text;
                Decimal productPrice = Decimal.Parse(textBox4.Text);
                string prouductDescraption = textBox5.Text;

                //Category  selectedProduct= comboBox1.SelectedValue.ToString(); ;

                int selectedCategory = categoryService.GetCategory().FirstOrDefault(c => c.Name.ToLower() == selectedProduct.ToLower()).ID;

                // try to add image 
                try
                {
                    newImageName = Guid.NewGuid() + Path.GetFileName(ProductImageSelction);


                    File.Copy(ProductImageSelction, Path.Combine(@"D:\ITI Intake24 3 months\Visual C#\lap\onion architecture Day12\Presentation\images",
                       newImageName), true);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Can't Upload Image", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ProductService.Addtech(new Model.Models.Product
                {
                    Name = productName,
                    Price = productPrice,
                    Code = productcode,
                    Title = prouductTitle,
                    Description = prouductDescraption,
                    Image = newImageName,
                    CatID = selectedCategory,
                    AdminID = currentUserID

                });

                DataGridViewRow lastRow = dataGridView1.Rows[dataGridView1.Rows.Count - 1];


                //lastRow.Cells["CategoryName"].Value = selectedCategory != null ? selectedCategory.Name : "No Category";
                LoadCategories();
                loadtabel();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

                ProductpictureBox.Image = null;

            }
            else
            {
                MessageBox.Show(" please Add ALl data");
            }



        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            var list = ProductService.GetByName(textBox8.Text).ToList();
            dataGridView1.DataSource = list;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = comboBox1.SelectedValue.ToString();

        }

        private void ProductpictureBox_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files (*.jpg)| *.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ProductpictureBox.Image = new Bitmap(dialog.FileName);

                    ProductImageSelction = dialog.FileName;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Upload Image", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}


