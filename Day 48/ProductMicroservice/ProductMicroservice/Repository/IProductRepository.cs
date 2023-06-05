using ProductMicroservice.Models;
using System.Collections.Generic;


namespace ProductMicroservice.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetProductById(int Productid);
        void InsertProduct(Product Product);
        void UpdateProduct(Product Product);
        void DeleteProduct(int Productid);
        void Save();
        object GetProducts();
    }
}
