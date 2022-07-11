using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class TblProduct
    {
        public TblProduct()
        {
            TblOrderDetails = new HashSet<TblOrderDetail>();
        }

        public TblProduct(int productId, int categoryId, string productName, string weight, decimal unitPrice, int unitslnStock)
        {
            ProductId = productId;
            CategoryId = categoryId;
            ProductName = productName;
            Weight = weight;
            UnitPrice = unitPrice;
            UnitslnStock = unitslnStock;
            
        }

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; } = null!;
        public string Weight { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public int UnitslnStock { get; set; }

        public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; }
    }
}
