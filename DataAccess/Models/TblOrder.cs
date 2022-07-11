using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class TblOrder
    {
        public TblOrder()
        {
            TblOrderDetails = new HashSet<TblOrderDetail>();
        }

        public TblOrder(int orderId, int memberId, string orderDate, string requiredDate, string shippedDate, decimal freight)
        {
            OrderId = orderId;
            MemberId = memberId;
            OrderDate = DateTime.Parse(orderDate);
            RequiredDate = DateTime.Parse(requiredDate);
            ShippedDate = DateTime.Parse(shippedDate);
            Freight = freight;
        }

        public TblOrder(int orderId, int memberId, DateTime requiredDate, DateTime orderDate, DateTime shippedDate, decimal freight)
        {
            OrderId = orderId;
            MemberId = memberId;
            RequiredDate = requiredDate;
            OrderDate = orderDate;
            ShippedDate = shippedDate;
            Freight = freight;
        }

        public int OrderId { get; set; }
        public int MemberId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public decimal Freight { get; set; }

        public virtual TblMember Member { get; set; } = null!;
        public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; }
    }
}
