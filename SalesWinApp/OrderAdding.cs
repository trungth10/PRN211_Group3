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
    public partial class OrderAdding : Form
    {
        OrderObject order = new OrderObject();
        public OrderAdding()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result = order.AddOrder(new DataAccess.Models.TblOrder(Int32.Parse(txtOrderId.Text), Int32.Parse(txtMemberId.Text), txtOrderDate.Text, txtRequiredDate.Text, txtShippedDate.Text, decimal.Parse(txtFreight.Text)));
            if (result)
            {
                this.Close();
                MessageBox.Show("Add Successfully");
            }
            else
            {
                MessageBox.Show("Add Order Fail ");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderAdding_Load(object sender, EventArgs e)
        {

        }
    }
}
