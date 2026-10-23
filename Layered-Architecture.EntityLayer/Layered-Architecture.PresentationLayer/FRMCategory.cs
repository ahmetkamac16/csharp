using Layered_Architecture.BusinessLayer.Abstract;
using Layered_Architecture.BusinessLayer.Concreate;
using Layered_Architecture.DataAccessLayer.EntityFramework;
using Layered_Architecture.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Layered_Architecture.PresentationLayer
{
    public partial class FRMCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FRMCategory()
        {
            _categoryService = new CategoryManager(new EFCategoryDal());
            InitializeComponent();
        }

        private void btnList_Click(object sender, System.EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            category.CategoryStatus = rdbActive.Checked;
            _categoryService.TInsert(category);
            MessageBox.Show("Succesfully!");
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var deletedValues = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Succesfully!");
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            int updatedId = int.Parse(txtCategoryId.Text);
            var updatedValue = _categoryService.TGetById(updatedId);
            updatedValue.CategoryName = txtCategoryName.Text;
            updatedValue.CategoryStatus = rdbActive.Checked;
            _categoryService.TUpdate(updatedValue);
            MessageBox.Show("Succesfully!");
        }

        private void btnGetById_Click(object sender, System.EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var value = _categoryService.TGetById(id);
            dataGridView1.DataSource = new List<Category> { value };
        }
    }
}
