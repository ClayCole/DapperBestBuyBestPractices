using System;
namespace DapperExercise
{
    public interface IProductRepos
    {
        public IEnumerable<Product> GetAllProducts();
        public void CreateProduct(string name, double price, int categoryID);


    }
}

