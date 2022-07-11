using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Models;

namespace BusinessObject
{
    public class ProductObject : ProductDAO
    {
        private FStoreContext context = new FStoreContext();

        public bool AddProduct(TblProduct product)
        {
            context.TblProducts.Add(product);
            int row = context.SaveChanges();
            return row > 0;
        }

        public bool DeleteProduct(int productID)
        {
            TblProduct product = context.TblProducts.Find(productID);
            context.TblProducts.Remove(product);
            int row = context.SaveChanges();
            if(row > 0)
            {
                return true;
            }
            return false;
        }

        

        public List<ProductDTO> getProductsByProductID(int productID)
        {


            var result = from p in context.TblProducts
                         where p.ProductId == productID
                         select new ProductDTO(p.ProductId, p.ProductName, p.UnitPrice, p.UnitslnStock);
            return result.ToList();
        }

        public List<ProductDTO> getProductsByProductName(string productName)
        {
            var result = from p in context.TblProducts
                         where p.ProductName.Contains(productName)
                         select new ProductDTO(p.ProductId, p.ProductName, p.UnitPrice, p.UnitslnStock);
            return result.ToList();
        }

        public List<ProductDTO> getProductsByStock(int quantity)
        {
            var result = from p in context.TblProducts
                         where p.UnitslnStock == quantity
                         select new ProductDTO(p.ProductId, p.ProductName, p.UnitPrice, p.UnitslnStock);
            return result.ToList();
        }

        public List<ProductDTO> getProductsByUnitPrice(decimal price)
        {
            var result = from p in context.TblProducts
                         where p.UnitPrice == price
                         select new ProductDTO(p.ProductId, p.ProductName, p.UnitPrice, p.UnitslnStock);
            return result.ToList();
        }

        public List<ProductDTO> getProductsDTO()
        {
            var result = from p in context.TblProducts
                         select new ProductDTO(p.ProductId, p.ProductName, p.UnitPrice, p.UnitslnStock);
            return result.ToList();
        }

        public TblProduct searchProductByID(int productID)
        {
            TblProduct result = (from p in context.TblProducts 
                                where p.ProductId == productID
                                select p).FirstOrDefault();
            return result;
        }

        public bool UpdateProduct(TblProduct product)
        {
            TblProduct result = (from p in context.TblProducts
                                 where p.ProductId == product.ProductId
                                 select p).FirstOrDefault();
            if (result != null)
            {
                result.ProductId = product.ProductId; 
                result.ProductName = product.ProductName; 
                result.UnitPrice = product.UnitPrice; 
                result.UnitslnStock = product.UnitslnStock;
                result.CategoryId = product.CategoryId;
                result.Weight = product.Weight;
                context.TblProducts.Update(result);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        
    }
}
