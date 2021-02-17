using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockSalesProject.Entity.Concrete
{
    public class Role : IEntity
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual List<EmployeeAndRole> EmployeeAndRoles { get; set; }
    }
}