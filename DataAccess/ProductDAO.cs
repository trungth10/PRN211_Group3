using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
namespace DataAccess
{
    public interface ProductDAO
    {
        public List<ProductDTO> getProductsDTO();
        public List<ProductDTO> getProductsByProductID(int productID);
        public TblProduct searchProductByID(int productID);
        public List<ProductDTO> getProductsByProductName(string productName);
        public List<ProductDTO> getProductsByUnitPrice(decimal price);
        public List<ProductDTO> getProductsByStock(int quantity);
        public bool AddProduct(TblProduct product);
        public bool UpdateProduct(TblProduct productID);
        public bool DeleteProduct(int productID);
    }
}
