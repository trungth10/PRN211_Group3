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
    public partial class Orders : Form
    {
        OrderAdding orderAdding = new OrderAdding();
        OrderObject order = new OrderObject();
        private int productId, quantity;
        private float discount;
        private decimal unitprice;
        public Orders()
        {
            InitializeComponent();
        }
        public Orders(int productId, decimal unitprice, int quantity, float discount)
        {
            InitializeComponent();
            this.productId = productId;
            this.unitprice = unitprice;
            this.quantity = quantity;
            this.discount = discount;
            orderAdding.Show();
            
        }


        private void frmOrders_Load(object sender, EventArgs e)
        {
            dgvOrder.DataSource = order.getTblOrdersList();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            orderAdding.Show();
        }

        private void frmOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvOrder.DataSource = order.getTblOrdersList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((dgvOrder.SelectedCells[0].Value.ToString()));
            bool result = order.DeleteOrder(id);
            if (result)
            {
                dgvOrder.DataSource = order.getTblOrdersList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvOrder.SelectedCells[0].Value.ToString());

            TblOrder paramOrder = order.searchOrderByID(id);
            if(paramOrder != null)
            {
                OrderUpdating orderUpdating = new OrderUpdating(id, Convert.ToInt32(paramOrder.MemberId), paramOrder.OrderDate, paramOrder.RequiredDate, paramOrder.ShippedDate, paramOrder.Freight);
                orderUpdating.Show();
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((dgvOrder.SelectedCells[0].Value.ToString()));

            TblOrder existDetail = order.searchOrderByID(id);
            if(existDetail != null)
            {
                
                OrderDetailObject dao = new OrderDetailObject();
                List<TblOrderDetail> tblOrderDetails = dao.getTblOrderDetailListByOrderId(id);
                if (tblOrderDetails.Count > 0 )
                {
                    OrderDetail detail = new OrderDetail(id, this.productId, this.unitprice, this.quantity, this.discount);
                    detail.Show();
                }
                else
                {
                    bool result = dao.AddOrderDetail(new TblOrderDetail(id, this.productId, this.unitprice, this.quantity, this.discount));
                    if (result == true)
                    {
                        OrderDetail detail = new OrderDetail(id, this.productId, this.unitprice, this.quantity, this.discount);
                        detail.Show();
                    }
                }
                
                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main frmMain = new Main();
            frmMain.Show();
        }
    }
}
