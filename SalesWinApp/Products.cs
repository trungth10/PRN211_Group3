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
using DataAccess;
using DataAccess.Models;
namespace SalesWinApp
{
    public partial class Products : Form
    {
        private const float discount = 10/100;
        ProductAdding productAdding = new ProductAdding();
        ProductObject product = new ProductObject();
        public Products()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            cmbSearchOption.SelectedIndex = 0;
            dgvProduct.DataSource = product.getProductsDTO();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cmbSearchOption.Text)
            {
                case "ProductId":
                    if (txtProductID.Text != null)
                    {
                        dgvProduct.DataSource = product.getProductsByProductID(Int32.Parse(txtProductID.Text));
                    }
                    else
                    {
                        MessageBox.Show("Format of searh value must be a number");
                    }
                    break;
                case "ProductName":
                    if (txtProductID.Text != null)
                    {
                        dgvProduct.DataSource = product.getProductsByProductName(txtProductID.Text);
                    }
                    else
                    {
                        MessageBox.Show("Format of searh value must be a string");
                    }
                    break;
                case "UnitPrice":
                    decimal tmp = decimal.Parse(txtProductID.Text);
                    if (tmp > 0)
                    {
                        dgvProduct.DataSource = product.getProductsByUnitPrice(tmp);
                    }
                    else
                    {
                        MessageBox.Show("Format of searh value must be a number");
                    }
                    break;
                case "UnitInStock":
                    int quantity = Int32.Parse(txtProductID.Text);
                    if (quantity > 0)
                    {
                        dgvProduct.DataSource = product.getProductsByStock(quantity);
                    }
                    else
                    {
                        MessageBox.Show("Format of searh value must be a number");
                    }
                    break;
            }
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            productAdding.ShowDialog();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void frmProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvProduct.DataSource = product.getProductsDTO();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((dgvProduct.SelectedCells[0].Value.ToString()));
            bool result = product.DeleteProduct(id);
            if (result)
            {
                dgvProduct.DataSource = product.getProductsDTO();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((dgvProduct.SelectedCells[0].Value.ToString()));
            
            TblProduct existedProduct = product.searchProductByID(id);
            if (existedProduct != null)
            {
                ProductUpdating productUpdating = new ProductUpdating(id, existedProduct.ProductName, existedProduct.CategoryId, existedProduct.UnitslnStock, existedProduct.UnitPrice, existedProduct.Weight);
                productUpdating.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main frmMain = new Main();
            frmMain.ShowDialog();
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((dgvProduct.SelectedCells[0].Value.ToString()));
            TblProduct existedProduct = product.searchProductByID(id);
            if (existedProduct != null)
            {
                OrderDetailObject dao = new OrderDetailObject();
                bool result = dao.getTblOrderDetailListByOrderId(id);
                if (result == true)
                {
                    OrderDetail frmOrderDetail = new OrderDetail();
                    frmOrderDetail.ShowDialog();

                }
                else
                {
                    Orders frmOrders = new Orders(existedProduct.ProductId, existedProduct.UnitPrice, existedProduct.UnitslnStock, discount);
                    frmOrders.Show();
                }
                
            }
        }
    }
}
