using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Models;

namespace BusinessObject
{
    public class OrderDetailObject : OrderDetailDAO
    {
        private FStoreContext context = new FStoreContext();

        public List<TblOrderDetail> getTblOrderDetailList()
        {
            var result = from p in context.TblOrderDetails
                         select new TblOrderDetail(p.OrderId, p.ProductId, p.UnitPrice, p.Quantity, p.Discount);
            return result.ToList();
        }

        public bool getTblOrderDetailListByOrderId(int productId)
        {
            var result = from p in context.TblOrderDetails
                         where p.ProductId == productId
                         select new TblOrderDetail(p.OrderId, p.ProductId, p.UnitPrice, p.Quantity, p.Discount);
            return result.Count() > 0;
        }

        public bool AddOrderDetail(TblOrderDetail orderDetail)
        {
            context.TblOrderDetails.Add(orderDetail);
            int row = context.SaveChanges();
            return row > 0;
        }
    }
}
