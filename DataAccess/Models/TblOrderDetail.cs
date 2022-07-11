using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class TblOrderDetail
    {
        public TblOrderDetail(int orderId, int productId, decimal unitPrice, int quantity, double discount)
        {
            OrderId = orderId;
            ProductId = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Discount = discount;
        }

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }

        public virtual TblOrder Order { get; set; } = null!;
        public virtual TblProduct Product { get; set; } = null!;
    }
}
