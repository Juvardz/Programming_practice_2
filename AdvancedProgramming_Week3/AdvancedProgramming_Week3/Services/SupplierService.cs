
using AdvancedProgramming_Week3.Repository.Repository;
using AdvancedProgramming_Week3.Repository;
using System.Collections.Generic;


namespace AdvancedProgramming_Week3.Services
{
    public class SupplierService
    {
        private readonly SuppliersRepository _repository;

        public SupplierService()
        {
            _repository = new SuppliersRepository();
        }

        public IEnumerable<Suppliers> GetAllSuppliers()
        {
            return _repository.GetAllSuppliers();
        }

        public Suppliers GetSupplierByID(int id)
        {
            return _repository.GetSuppliersByID(id);
        }

        public bool CreateSupplier(Suppliers supplier)
        {
            return _repository.CreateSuppliers(supplier);
        }

        public bool UpdateSupplier(Suppliers supplier)
        {
            return _repository.UpdateSuppliers(supplier);
        }

        public bool DeleteSupplier(Suppliers supplier)
        {
            return _repository.DeleteSuppliers(supplier);
        }
    }
}
