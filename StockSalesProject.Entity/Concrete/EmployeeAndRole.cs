using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockSalesProject.Entity.Concrete
{
    public class EmployeeAndRole : IEntity
    {
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }

    }
}