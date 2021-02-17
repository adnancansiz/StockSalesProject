using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockSalesProject.Entity.Concrete
{
    public class Employee : IEntity
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }


        public virtual List<Order> Orders { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public virtual List<EmployeeAndRole> EmployeeAndRoles { get; set; }


    }
}