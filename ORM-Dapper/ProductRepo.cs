using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public class ProductRepo : IProductRepo
    {
        private readonly IDbConnection _conn;

        public ProductRepo(IDbConnection conn)
        {
            _conn = conn;
        }

        public void CreateProduct(string name, int productID, double price, int categoryID, bool onSale, int stockLevel)
        {
            _conn.Execute("INSERT INTO products(Name, ProductID, Price, CategoryID, OnSale, StockLevel) VALUES (@name, @ProductID, @price, @CategoryID, @OnSale, @StockLevel)", new { name, productID, price, categoryID, onSale, stockLevel });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("Select * FROM products;");
        }
    }
}      