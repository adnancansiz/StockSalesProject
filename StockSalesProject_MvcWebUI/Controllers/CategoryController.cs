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
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            return View(_categoryService.GetAll());
        }

        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            _categoryService.Add(category);
            return RedirectToAction("Index");
        }

        public ActionResult RemoveCategory(int categoryId)
        {
            var category = _categoryService.Get(c => c.CategoryId == categoryId);
            if (category != null)
            {
                _categoryService.Delete(category);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult UpdateCategory(int categoryId)
        {
            Category category = _categoryService.Get(c => c.CategoryId == categoryId);
            return View(category);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            var updated = _categoryService.Get(c => c.CategoryId == category.CategoryId);
            _categoryService.Update(updated);

            return RedirectToAction("Index");
        }
    }
}