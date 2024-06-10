using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public interface IProductRepo
    {
        public IEnumerable<Product> GetAllProducts();

        public void CreateProduct(string name, int productID, double price, int categoryID, bool onSale, int inStock);
    }
}
