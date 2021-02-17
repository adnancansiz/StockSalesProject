using StockSalesProject.Business.Abstract;
using StockSalesProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockSalesProject_MvcWebUI.Controllers
{
    [Authorize(Roles = "yonetici")]
    public class ProductController : Controller
    {
        ICategoryService _categoryService;
        ISupplierService _supplierService;
        IStoreroomService _storeroomService;
        IProductService _productService;

        public ProductController(ICategoryService categoryService, ISupplierService supplierService, IStoreroomService storeroomService, IProductService productService)
        {
            _categoryService = categoryService;
            _supplierService = supplierService;
            _storeroomService = storeroomService;
            _productService = productService;
        }

        public ActionResult Index()
        {
            ViewBag.Category = _categoryService.GetAll();
            ViewBag.Supplier = _supplierService.GetAll();
            ViewBag.Storeroom = _storeroomService.GetAll();
            return View(_productService.GetAll());
        }

        public ActionResult AddProduct()
        {
            ViewBag.Category = _categoryService.GetAll();
            ViewBag.Supplier = _supplierService.GetAll();
            ViewBag.Storeroom = _storeroomService.GetAll();
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            ViewBag.Category = _categoryService.GetAll();
            ViewBag.Supplier = _supplierService.GetAll();
            ViewBag.Storeroom = _storeroomService.GetAll();
            _productService.Add(product);
            return View();
        }

        public ActionResult DeleteProduct(int productId)
        {
            var product = _productService.Get(x => x.ProductId == productId);
            if (product != null)
            {
                _productService.Delete(product);
                return View("Index");
            }

            return View();
        }

        public ActionResult UpdateProduct(int productId)
        {
            ViewBag.Category = _categoryService.GetAll();
            ViewBag.Supplier = _supplierService.GetAll();
            ViewBag.Storeroom = _storeroomService.GetAll();
            var product = _productService.Get(x => x.ProductId == productId);
            return View(product);
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            ViewBag.Category = _categoryService.GetAll();
            ViewBag.Supplier = _supplierService.GetAll();
            ViewBag.Storeroom = _storeroomService.GetAll();
            _productService.Update(product);

            return RedirectToAction("Index");
        }
    }
}