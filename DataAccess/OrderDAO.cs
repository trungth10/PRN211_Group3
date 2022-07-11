using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess
{
    public interface OrderDAO
    {
        public bool AddOrder(TblOrder order);
        public bool DeleteOrder(int orderId);
        public List<TblOrder> getTblOrdersList();
        public bool UpdateOrder(TblOrder order);
    }
}
