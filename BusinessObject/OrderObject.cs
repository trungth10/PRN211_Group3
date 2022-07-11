using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Models;

namespace BusinessObject
{
    public class OrderObject : OrderDAO
    {
        private FStoreContext context = new FStoreContext();

        public bool AddOrder(TblOrder order)
        {
            context.TblOrders.Add(order);
            int row = context.SaveChanges();
            return row > 0;
        }

        public bool DeleteOrder(int orderId)
        {
            TblOrder order = context.TblOrders.Find(orderId);
            context.TblOrders.Remove(order);
            int row = context.SaveChanges();
            if (row > 0)
            {
                return true;
            }
            return false;
        }

        public List<TblOrder> getTblOrdersList()
        {
            var result = from p in context.TblOrders
                         select new TblOrder(p.OrderId, p.MemberId, p.RequiredDate, p.OrderDate, p.ShippedDate, p.Freight);
            return result.ToList();
        }


        public bool UpdateOrder(TblOrder order)
        {
            TblOrder result = (from p in context.TblOrders
                               where p.OrderId == order.OrderId
                               select p).FirstOrDefault();
            if (result != null)
            {
                result.OrderId = order.OrderId;
                result.MemberId = order.MemberId;
                result.RequiredDate = order.RequiredDate;
                result.OrderDate = order.OrderDate;
                result.Freight = order.Freight;
                result.ShippedDate = order.ShippedDate;
                context.TblOrders.Update(result);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public TblOrder searchOrderByID(int orderId)
        {
            TblOrder result = (from p in context.TblOrders
                               where p.OrderId == orderId
                               select p).FirstOrDefault();
            return result;
        }
    }
}
