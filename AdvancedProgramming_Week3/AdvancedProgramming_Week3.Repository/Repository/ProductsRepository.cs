using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming_Week3.Repository.Repository
{
    public class ProductsRepository : RepositoryBase<Products>
    {

        public IEnumerable<Products> GetAllProducts()
        {
            return GetEntities();
        }

        public Products GetProductsByID(int pID)
        {
            return GetByID(pID);
        }

        public Products GetProductsByName(string pName)
        {
            return GetByName(pName);
        }

        public bool CreateProducts(Products product)
        {
            ProductDBEntities.Products.Add(product);
            return ProductDBEntities.SaveChanges() > 0;
        }

        public bool UpdateProducts(Products product)
        {
            return Update(product);
        }

        public bool DeleteProducts(Products product)
        {
            ProductDBEntities.Products.Remove(product);
            return ProductDBEntities.SaveChanges() > 0;
        }               
    }
}
