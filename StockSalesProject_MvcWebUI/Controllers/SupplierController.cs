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
    public class SupplierController : Controller
    {
        ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        public ActionResult Index()
        {
            return View(_supplierService.GetAll());
        }

        public ActionResult AddSupplier()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSupplier(Supplier supplier)
        {
            _supplierService.Add(supplier);
            return View("Index");
        }

        public ActionResult RemoveSupplier(int supplierId)
        {
            var supplier = _supplierService.Get(x => x.SupplierId == supplierId);
            if (supplier != null)
            {
                _supplierService.Delete(supplier);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult UpdateSupplier(int supplierId)
        {
            var supplier = _supplierService.Get(x => x.SupplierId == supplierId);
            return View(supplier);
        }

        [HttpPost]
        public ActionResult UpdateSupplier(Supplier supplier)
        {
            var updated = _supplierService.Get(x => x.SupplierId == supplier.SupplierId);
            _supplierService.Update(updated);
            return RedirectToAction("Index");
        }
    }
}