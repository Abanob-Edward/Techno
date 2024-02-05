using Appliaction.Services;
using Context;
using Infrastructure.Repositores;
using Microsoft.EntityFrameworkCore;
using Model.Models;  // Make sure to include the namespace for your models
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation
{
    public partial class EditProductPanel : Form
    {
        IProductService ProductService;
        ICategoryService categoryService;
        string selectedProduct = " ";
        string ProductImageSelction = "";

        public EditProductPanel()
        {
            InitializeComponent();
            ProductService = new ProductService(new ProudectRepository(new _Context()));
            categoryService = new CategoryService(new CatgoryRepositry(new _Context()));
            loadtabel();
        }
        private bool isRowSelected = false;


        private void Product_load(object sender, EventArgs e)
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
        public void loadtabel()
        {
            var products = ProductService.GetAlltech().ToList();
            dataGridView1.DataSource = null;
            // dataGridView1.DataSource = products;
            dataGridView1.DataSource = products.Select(p => new
            {
                p.Id,
                p.Name,
                p.Description,
                p.Price,
                p.Title,
                p.Code,
                p.Image,
                CategoryName = p.category != null ? p.category.Name : "No Category",
                AdmineName = p.User != null ? p.User.FirstName : "No Admin"

            }).ToList();
        }
      

        private void ProdactDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();//
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();//
            textBox7.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();//

            comboBox1.SelectedItem = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            isRowSelected =true;
        }




        private void Proudect_delet(object sender, EventArgs e)
        {
            if (isRowSelected)
            {
                Error.Text = " ";
                int Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var obj = ProductService.GettechById(Id);

                var result = MessageBox.Show("Are you sure to delete?", "Delete Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    ProductService.Deletetech(Id);
                    loadtabel();
                }
            }
            else
            {
                Error.Text = "Please Select a Row to delete";


            }
        }
        string newImageName = "";
        private void proudect_Edite(object sender, EventArgs e)
        {
            if (isRowSelected)
            {
                Error.Text = " ";
                if (textBox7.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0
                && textBox4.Text.Length > 0 && textBox5.Text.Length > 0)
                {
                    int Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    var obj = ProductService.GettechById(Id);

                    string productName = textBox2.Text;
                    Decimal productPrice = Decimal.Parse(textBox5.Text);
                    int productcode = int.Parse(textBox3.Text);
                    string prouductTitle = textBox4.Text;
                    string prouductDescraption = textBox7.Text;

                    //int selectedCategory = categoryService.GetCategory().FirstOrDefault(c => c.Name.ToLower() == selectedProduct.ToLower()).ID;
                    var result = MessageBox.Show("Are you sure to update?", "update Confirm", MessageBoxButtons.YesNo);
                    try
                    {
                        newImageName = Guid.NewGuid() + Path.GetFileName(ProductImageSelction);


                        File.Copy(ProductImageSelction, Path.Combine(@"D:\ITI Intake24 3 months\Visual C#\lap\onion architecture Day12\Presentation\images",
                            Path.GetFileName(ProductImageSelction)), true);
                        obj.Image = newImageName;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Can't Upload Image", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                    obj.Name = productName;
                    obj.Code = productcode;
                    obj.Title = prouductTitle;
                    obj.Description = prouductDescraption;

                    obj.Price = productPrice;
                    //obj.CatID = selectedCategory;

                    ProductService.Updatetech(obj);
                    loadtabel();


                }

            }
            else
            {
                Error.Text = "Please Select a Row to delete";
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = comboBox1.SelectedValue.ToString();

        }



        private void ProductpictureBox_Click_2(object sender, EventArgs e)
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

        //private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{

        //}



    }
}

