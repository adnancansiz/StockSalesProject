using StockSalesProject.Business.Abstract;
using StockSalesProject.Entity.Concrete;
using StockSalesProject_MvcWebUI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace StockSalesProject_MvcWebUI.Controllers
{
    
    public class LoginController : Controller
    {
        IEmployeeService _employeeService;

        public LoginController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                Employee employee = _employeeService.Get(x => x.UserName == loginVM.UserName && x.Password == loginVM.Password);
                if (User != null)
                {
                    FormsAuthentication.SetAuthCookie(employee.UserName, true);
                }
            }
            return RedirectToAction(nameof(StockSalesProject_MvcWebUI.Controllers.HomeController.Index), "Home/Index");
        }
    }
}