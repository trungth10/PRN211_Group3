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

namespace SalesWinApp
{
    public partial class OrderUpdating : Form
    {
        OrderObject order = new OrderObject();
        private int orderId, memberId;
        private decimal freight;
        private DateTime orderDate;
        private DateTime requiredDate;
        private DateTime shippedDate;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool result = order.UpdateOrder(new DataAccess.Models.TblOrder(Int32.Parse(txtOrderId.Text), Int32.Parse(txtMemberId.Text), txtOrderDate.Text, txtRequiredDate.Text, txtShippedDate.Text, decimal.Parse(txtFreight.Text)));
            if (result)
            {                
                this.Close();
                MessageBox.Show("Update Successfully");
            }
            else
            {
                MessageBox.Show("Update Order Fail ");
            }
        }


        public OrderUpdating()
        {
            InitializeComponent();
        }

        public OrderUpdating(int orderId, int memberId, string orderDate, string requiredDate, string shippedDate, decimal freight)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.memberId = memberId;
            this.orderDate = DateTime.Parse(orderDate);
            this.requiredDate = DateTime.Parse(requiredDate);
            this.shippedDate = DateTime.Parse(shippedDate);
            this.freight = freight;
        }

        public OrderUpdating(int id, int memberId, DateTime orderDate1, DateTime requiredDate1, DateTime shippedDate1, decimal freight)
        {
            InitializeComponent();
            this.orderId = id;
            this.memberId = memberId;
            this.orderDate = orderDate1;
            this.requiredDate = requiredDate1;
            this.shippedDate = shippedDate1;
            this.freight = freight;
        }

        private void OrderUpdating_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = orderId.ToString();
            txtMemberId.Text = memberId.ToString();
            txtFreight.Text = freight.ToString();
            txtOrderDate.Text = orderDate.ToString();
            txtRequiredDate.Text = requiredDate.ToString();
            txtShippedDate.Text = shippedDate.ToString();
        }       
    }
}
