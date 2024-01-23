using Northwind.Bussiness.Abstract;
using Northwind.Bussiness.Concrete;
using Northwind.Bussiness.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }
        private IProductService _productService; 
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            dgwProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
            cbxCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            cbxCategory2.DataSource = _categoryService.GetAll();
            cbxCategory2.DisplayMember = "CategoryName";
            cbxCategory2.ValueMember = "CategoryId";
            cbxCategory2.DropDownStyle = ComboBoxStyle.DropDownList;

            cbxUpdateCategoryID.DataSource = _categoryService.GetAll();
            cbxUpdateCategoryID.DisplayMember = "CategoryName";
            cbxUpdateCategoryID.ValueMember = "CategoryId";
            cbxUpdateCategoryID.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch 
            {

              
            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))//textboxa arama yapmak için yazdıklarımızı sildiğimizde datagridin boş kalmasını engellemek için bunu yapıyoruz. 
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }else LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                CategoryID = Convert.ToInt32(cbxCategory2.SelectedValue),
                ProductName = tbxProductName2.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                QuantityPerUnit = tbxQuantityPerUnit.Text,
                UnitsInStock = Convert.ToInt16(tbxStock.Text)
            });
            MessageBox.Show("Ürün Eklendi!");
            LoadProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxUpdateProductName.Text,
                CategoryID = Convert.ToInt32(cbxUpdateCategoryID.SelectedValue),
                UnitsInStock = Convert.ToInt16(tbxStockUpdate.Text),
                QuantityPerUnit = tbxQuantitiyPerUnitUpd.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text)
            });
            MessageBox.Show("Ürün Güncellendi!");
            LoadProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxUpdateProductName.Text = row.Cells[1].Value.ToString();
            cbxUpdateCategoryID.SelectedValue = row.Cells[2].Value;
            tbxUnitPriceUpdate.Text = row.Cells[3].Value.ToString();
            tbxQuantitiyPerUnitUpd.Text = row.Cells[4].Value.ToString();
            tbxStockUpdate.Text = row.Cells[5].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwProduct.CurrentRow != null)
                {
                    _productService.Delete(new Product { ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value) });
                    MessageBox.Show("Ürün Silindi!");
                    LoadProducts();
                }
                else MessageBox.Show("Lütfen ürün seçiniz.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: " + ex.Message);
            }

        }
    }
}
