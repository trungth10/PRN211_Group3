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
namespace SalesWinApp;

public partial class ProductAdding : Form
{
    ProductObject product = new ProductObject();
    private int productId, categoryId, unitInStock;
    private decimal price;
    private string productName, weight;
    public ProductAdding()
    {
        InitializeComponent();
    }

    public ProductAdding(int productId, string productName, int categoryId, int unitInStock, decimal price, string weight)
    {
        InitializeComponent();
        this.productId = productId;
        this.productName = productName;
        this.categoryId = categoryId;
        this.unitInStock = unitInStock;
        this.price = price;
        this.weight = weight;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        bool result = product.AddProduct(new DataAccess.Models.TblProduct(Int32.Parse(txtProductID.Text), Int32.Parse(txtCategoryId.Text), txtProductName.Text, txtWeight.Text, decimal.Parse(txtPrice.Text), Int32.Parse(txtQuantity.Text)));
        if (result)
        {
            MessageBox.Show("Add Successfully");
        }
        else
        {
            MessageBox.Show("Add Fail Product " + txtProductID.Text + "existed");
        }
    }

    

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void ProductAdding_Load(object sender, EventArgs e)
    {
        txtProductID.Text = productId.ToString();
        txtProductName.Text = productName;
        txtCategoryId.Text = categoryId.ToString();
        txtPrice.Text = price.ToString();
        txtWeight.Text = weight;
        txtQuantity.Text = unitInStock.ToString();
    }
}
