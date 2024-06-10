using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using ORM_Dapper;
//^^^^MUST HAVE USING DIRECTIVES^^^^

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
string connString = config.GetConnectionString("DefaultConnection");
IDbConnection conn = new MySqlConnection(connString);

//var deptRepo = new DepartmentRepo(conn);

//Console.WriteLine("What's the name of the department that you're creating?");
//var deptName = Console.ReadLine();

//deptRepo.InsertDepartment(deptName);

//var departments = deptRepo.GetAllDepartments();

//foreach(var dept in departments)
//{
//   Console.WriteLine($"ID: {dept.DepartmentID} | Name: {dept.Name}");
//}

var productRepo = new ProductRepo(conn);

var products = productRepo.GetAllProducts();

foreach(var product in products)
{
    Console.WriteLine($"Name: {product.Name} | ProductID: {product.ProductID} | Price: {product.Price} | CategoryID: {product.CategoryID} |{product.OnSale} | Stock Level: {product.StockLevel}");
}
