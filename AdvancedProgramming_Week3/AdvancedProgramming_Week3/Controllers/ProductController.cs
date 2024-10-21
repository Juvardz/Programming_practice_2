
using System.Web.Mvc;
using AdvancedProgramming_Week3.Services;
using AdvancedProgramming_Week3.Repository;

namespace AdvancedProgramming_Week3.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();
        }

        public ActionResult Index()
        {
            return View(_productService.GetAllProducts());
        }

        public ActionResult Details(int id)
        {
            var product = _productService.GetProductByID(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Products product)
        {
            if (ModelState.IsValid)
            {
                _productService.CreateProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public ActionResult Edit(int id)
        {
            var product = _productService.GetProductByID(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Products product)
        {
            if (ModelState.IsValid)
            {
                _productService.UpdateProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public ActionResult Delete(int id)
        {
            var product = _productService.GetProductByID(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var product = _productService.GetProductByID(id);
            if (product != null)
            {
                _productService.DeleteProduct(product);
            }
            return RedirectToAction("Index");
        }
    }
}
