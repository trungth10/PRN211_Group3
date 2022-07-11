﻿using System;
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
    public partial class OrderDetail : Form
    {
        OrderDetailObject orderDetail = new OrderDetailObject();
        private int orderId, productId, quantity;
        private float discount;
        private decimal unitprice;

        public OrderDetail()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            dgvOrderDetail.DataSource = orderDetail.getTblOrderDetailList();
        }

        public OrderDetail(int orderId, int productId, decimal unitprice, int quantity, float discount)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.productId = productId;
            this.quantity = quantity;
            this.unitprice = unitprice;
            this.discount = discount;
        }

        
    }
}
