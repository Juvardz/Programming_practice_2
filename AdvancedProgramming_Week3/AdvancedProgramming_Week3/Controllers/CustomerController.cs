
using System.Web.Mvc;
using AdvancedProgramming_Week3.Services;
using AdvancedProgramming_Week3.Repository;

namespace AdvancedProgramming_Week3.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerService _customerService;

        public CustomerController()
        {
            _customerService = new CustomerService();
        }

        public ActionResult Index()
        {
            return View(_customerService.GetAllCustomers());
        }

        public ActionResult Details(int id)
        {
            var customer = _customerService.GetCustomerByID(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customerService.CreateCustomer(customer);
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        public ActionResult Edit(int id)
        {
            var customer = _customerService.GetCustomerByID(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customerService.UpdateCustomer(customer);
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        public ActionResult Delete(int id)
        {
            var customer = _customerService.GetCustomerByID(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var customer = _customerService.GetCustomerByID(id);
            if (customer != null)
            {
                _customerService.DeleteCustomer(customer);
            }
            return RedirectToAction("Index");
        }
    }
}
