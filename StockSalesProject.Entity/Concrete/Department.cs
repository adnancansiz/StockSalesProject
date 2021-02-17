using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockSalesProject.Entity.Concrete
{
    public class Department : IEntity
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}