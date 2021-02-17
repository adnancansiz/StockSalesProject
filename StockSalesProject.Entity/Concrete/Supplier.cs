using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockSalesProject.Entity.Concrete
{
    public class Supplier : IEntity
    {
        public int SupplierId { get; set; }
        public string SupplierCompanyName { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }


        public virtual List<Product> Products { get; set; }

    }
}