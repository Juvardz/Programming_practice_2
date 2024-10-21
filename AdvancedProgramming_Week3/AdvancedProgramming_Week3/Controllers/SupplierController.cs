
using System.Web.Mvc;
using AdvancedProgramming_Week3.Services;
using AdvancedProgramming_Week3.Repository;

namespace AdvancedProgramming_Week3.Controllers
{
    public class SupplierController : Controller
    {
        private readonly SupplierService _supplierService;

        public SupplierController()
        {
            _supplierService = new SupplierService();
        }

        public ActionResult Index()
        {
            return View(_supplierService.GetAllSuppliers());
        }

        public ActionResult Details(int id)
        {
            var supplier = _supplierService.GetSupplierByID(id);
            if (supplier == null)
            {
                return HttpNotFound();
            }
            return View(supplier);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Suppliers supplier)
        {
            if (ModelState.IsValid)
            {
                _supplierService.CreateSupplier(supplier);
                return RedirectToAction("Index");
            }
            return View(supplier);
        }

        public ActionResult Edit(int id)
        {
            var supplier = _supplierService.GetSupplierByID(id);
            if (supplier == null)
            {
                return HttpNotFound();
            }
            return View(supplier);
        }

        [HttpPost]
        public ActionResult Edit(Suppliers supplier)
        {
            if (ModelState.IsValid)
            {
                _supplierService.UpdateSupplier(supplier);
                return RedirectToAction("Index");
            }
            return View(supplier);
        }

        public ActionResult Delete(int id)
        {
            var supplier = _supplierService.GetSupplierByID(id);
            if (supplier == null)
            {
                return HttpNotFound();
            }
            return View(supplier);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var supplier = _supplierService.GetSupplierByID(id);
            if (supplier != null)
            {
                _supplierService.DeleteSupplier(supplier);
            }
            return RedirectToAction("Index");
        }
    }
}
