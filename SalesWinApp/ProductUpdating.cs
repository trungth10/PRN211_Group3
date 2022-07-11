using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Models;
namespace SalesWinApp
{
    public partial class ProductUpdating : Form
    {
        ProductObject product = new ProductObject();
        private int productId, categoryId, unitInStock;
        private decimal price;
        private string productName, weight;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool result = product.UpdateProduct(new DataAccess.Models.TblProduct(Convert.ToInt32(txtProductID.Text), Convert.ToInt32(txtCategoryId.Text), txtProductName.Text, txtWeight.Text, decimal.Parse(txtPrice.Text), Convert.ToInt32(txtQuantity.Text)));
            if (result == true)
            {
                this.Close();
                MessageBox.Show("Update Successfully");
            }
            else
            {
                MessageBox.Show("Update Fail");
            }
        }

        private void ProductUpdating_Load(object sender, EventArgs e)
        {
            txtProductID.Text = productId.ToString();
            txtProductName.Text = productName;
            txtCategoryId.Text = categoryId.ToString();
            txtPrice.Text = price.ToString();
            txtWeight.Text = weight.ToString();
            txtQuantity.Text = unitInStock.ToString();
        }

        public ProductUpdating()
        {
            InitializeComponent();
        }
        public ProductUpdating(int productId, string productName, int categoryId, int unitInStock, decimal price, string weight)
        {
            InitializeComponent();
            this.productId = productId;
            this.productName = productName;
            this.categoryId = categoryId;
            this.unitInStock = unitInStock;
            this.price = price;
            this.weight = weight;
        }

    }
}
