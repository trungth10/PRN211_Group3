using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDTO
    {
        public ProductDTO(int productID, string productName, decimal price, int quantity)
        {
            this.productID = productID;
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }

        public int productID { get; set; }
        public string productName { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }


    }
}
