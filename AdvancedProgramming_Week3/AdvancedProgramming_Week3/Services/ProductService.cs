
using AdvancedProgramming_Week3.Repository.Repository;
using AdvancedProgramming_Week3.Repository;
using System.Collections.Generic;

namespace AdvancedProgramming_Week3.Services
{
    public class ProductService
    {
        private readonly ProductsRepository _repository;

        public ProductService()
        {
            _repository = new ProductsRepository();
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }

        public Products GetProductByID(int id)
        {
            return _repository.GetProductsByID(id);
        }

        public bool CreateProduct(Products product)
        {
            return _repository.CreateProducts(product);
        }

        public bool UpdateProduct(Products product)
        {
            return _repository.UpdateProducts(product);
        }

        public bool DeleteProduct(Products product)
        {
            return _repository.DeleteProducts(product);
        }
    }
}
