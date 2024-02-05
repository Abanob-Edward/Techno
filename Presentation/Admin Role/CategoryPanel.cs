using Appliaction.Contract;
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
    public partial class CategoryPanel : Form
    {
        ICategoryService categoryService;


        public CategoryPanel()
        {
            InitializeComponent();

            categoryService = new CategoryService(new CatgoryRepositry(new _Context()));
            // loadtabel();

        }

        //public void loadtabel()
        //{
        //    //var count = categoryService.GetProductCountByCategoryId(2);
        //    var categories = categoryService.GetCategory()
        //        .Include(p => p.Products);
        //    //CategoryDGV.DataSource = categories.Select(p => new
        //    //{
        //    //    p.Name,
        //    //    p.Type,
        //    //    ProducatCount = p.Products.Count()
        //    //}).ToList();
        //    CategoryDGV.DataSource = null;

        //    CategoryDGV.DataSource = categories;
        //}
        public void loadtabel()
        {
            var categories = categoryService.GetCategory()?.Include(p => p.Products).ToList();

            if (categories != null)
            {
                var categoryData = new List<object>();

                foreach (var category in categories)
                {
                    var count = category.Products.Count();

                    categoryData.Add(new
                    {
                        category.ID,
                        category.Name,
                        category.Type,
                        ProductCount = count,
                    });
                }

                CategoryDGV.DataSource = null;
                CategoryDGV.DataSource = categoryData;
            }
            else
            {
                Console.WriteLine("Categories is null");
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
            string categoryName = CatNameTxt1.Text;
            string categoryType = CatTybetxt1.Text;
            //  int catgoryId = int.Parse(textBox3.Text);

            var obj = categoryService.GetCategorybyID(1);

            obj.Name = categoryName;
            obj.Type = categoryType;

            categoryService.UpdateCategory(obj);
            loadtabel();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //    var categories = categoryService.GetCategory().ToList();

            //    CategoryDGV.DataSource = categories;
            //    loadtabel();

        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            var list = categoryService.GetByName(textBox4.Text).ToList();
            CategoryDGV.DataSource = list;

        }

        private void ProdactDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            CatTybetxt2.Text = CategoryDGV.CurrentRow.Cells[0].Value.ToString();
            CatNameTxt2.Text = CategoryDGV.CurrentRow.Cells[CategoryDGV.ColumnCount - 1].Value.ToString();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            if (CategoryDGV.SelectedRows.Count > 0)
            {

                int Id = int.Parse(CategoryDGV.CurrentRow.Cells[0].Value.ToString());
                var obj = categoryService.GetCategorybyID(Id);

                var Result = MessageBox.Show("Are you shure  to delete ", "Delete Confirem", MessageBoxButtons.YesNo);
               
                if (Result == DialogResult.Yes)
                {
                    categoryService.DeleteCategory(Id);
                    loadtabel();
                }




            }
            else
            {
                ErrorMessage.Text = "Please Select Row to delete";
            }


        }
        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            if (CatNameTxt2.Text != null && CatNameTxt2.Text != "")
            {
                int Id = int.Parse(CategoryDGV.CurrentRow.Cells[0].Value.ToString());
                var obj = categoryService.GetCategorybyID(Id);

                obj.Name = CatNameTxt2.Text;
                obj.Type = CatTybetxt2.Text;

                categoryService.UpdateCategory(obj);
                loadtabel();

            }
            else
            {
                ErrorMessage.Text = "Please Select Row to Update";
            }


        }


        private void AddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = CatNameTxt1.Text;
            string categoryType = CatTybetxt1.Text;

            categoryService.AddCategory(new Model.Models.Category { Name = categoryName, Type = categoryType });
            CatNameTxt1.Clear();
            CatTybetxt1.Clear();

            loadtabel();
        }

      

        private void CategoryPanel_Load(object sender, EventArgs e)
        {
            loadtabel();
            this.ControlBox = false;

        }

        private void CategoryDGV_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            CatNameTxt2.Text = CategoryDGV.CurrentRow.Cells[1].Value.ToString();
            CatTybetxt2.Text = CategoryDGV.CurrentRow.Cells[2].Value.ToString();
            ErrorMessage.Text = "";
        }
    }
}
