using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeStores.Business.Abstract;
using BikeStores.Business.Concrete;
using BikeStores.Business.DependencyResolvers.Ninject;
using BikeStores.DataAccess.Concrete.EntityFramework;
using BikeStores.Entities.Concrete;

namespace BikeStores.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IProductService _productService = InstanceFactory.GetInstance<IProductService>();
        ICategoryService _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        IBrandService _brandService = new BrandManager(new EfBrandDal());
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxSelect.DataSource = _categoryService.GetAll();
            cbxSelect.DisplayMember = "category_name";
            cbxSelect.ValueMember = "category_id";
            
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "category_name";
            cbxCategory.ValueMember = "category_id";

            cbxCategoryUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryUpdate.DisplayMember = "category_name";
            cbxCategoryUpdate.ValueMember = "category_id";

            cbxBrand.DataSource = _brandService.GetAll();
            cbxBrand.DisplayMember = "brand_name";
            cbxBrand.ValueMember = "brand_id";

            cbxBrandUpdate.DataSource = _brandService.GetAll();
            cbxBrandUpdate.DisplayMember = "brand_name";
            cbxBrandUpdate.ValueMember = "brand_id";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductByCategory(Convert.ToInt32(cbxSelect.SelectedValue));
            }
            catch
            {

            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tbxSearch.Text))
            {
                dgwProduct.DataSource = _productService.GetProductByName(tbxSearch.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    product_name = tbxName.Text,
                    brand_id = Convert.ToInt32(cbxBrand.SelectedValue),
                    category_id = Convert.ToInt32(cbxCategory.SelectedValue),
                    model_year = Convert.ToInt16(tbxModelYear.Text),
                    list_price = Convert.ToDecimal(tbxPrice.Text)
                });
                MessageBox.Show("Product Added!");
                LoadProducts();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                product_id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                product_name = tbxProductNameUpdate.Text,
                brand_id = Convert.ToInt32(cbxBrandUpdate.SelectedValue),
                category_id = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                model_year = Convert.ToInt16(tbxModelYearUpdate.Text),
                list_price = Convert.ToDecimal(tbxPriceUpdate.Text)
            });
            MessageBox.Show("Product Updated!");
            LoadProducts();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        product_id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Product Deleted!");
                    LoadProducts();
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            
        }
        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbxProductNameUpdate.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
                cbxBrandUpdate.SelectedValue = Convert.ToInt32(dgwProduct.CurrentRow.Cells[2].Value);
                cbxCategoryUpdate.SelectedValue = Convert.ToInt32(dgwProduct.CurrentRow.Cells[3].Value);
                tbxModelYearUpdate.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
                tbxPriceUpdate.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
            }catch { }
        }
    }
}
