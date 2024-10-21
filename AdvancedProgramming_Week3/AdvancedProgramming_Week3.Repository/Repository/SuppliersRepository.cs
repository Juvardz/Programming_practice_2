using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming_Week3.Repository.Repository
{
    public class SuppliersRepository : RepositoryBase<Suppliers>
    {

        public IEnumerable<Suppliers> GetAllSuppliers()
        {
            return GetEntities();
        }

        public Suppliers GetSuppliersByID(int pID)
        {
            return GetByID(pID);
        }

        public Suppliers GetSuppliersByName(string pName)
        {
            return GetByName(pName);
        }

        public bool CreateSuppliers(Suppliers supplier)
        {
            ProductDBEntities.Suppliers.Add(supplier);
            return ProductDBEntities.SaveChanges() > 0;
        }

        public bool UpdateSuppliers(Suppliers supplier)
        {
            return Update(supplier);
        }

        public bool DeleteSuppliers(Suppliers supplier)
        {
            ProductDBEntities.Suppliers.Remove(supplier);
            return ProductDBEntities.SaveChanges() > 0;
        }               
    }
}
