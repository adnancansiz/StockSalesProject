using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockSalesProject.Entity.Concrete
{
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public virtual List<OrderProduct> OrderProducts { get; set; }
        public int CompanyId { get; set; }

        public Company Company { get; set; }

    }
}