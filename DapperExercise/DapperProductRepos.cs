using System;
using System.Data;
using Dapper;

namespace DapperExercise
{
    public class DapperProductRepos : IProductRepos
    {
        private readonly IDbConnection _connection;

        public DapperProductRepos(IDbConnection connection)
        {
            _connection = connection;
        }

        public void CreateProduct(string name, double price, int categoryID)
        {
            _connection.Execute("Insert Into Products (Name, Price, CategoryID)"
                + "VALUES (@name, @price, @categoryID);",
                new { name = name, price = price, categoryID = categoryID });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("Select * From Products;");
        }
    }
}

