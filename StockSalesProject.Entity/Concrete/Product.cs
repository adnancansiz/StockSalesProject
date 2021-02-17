using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockSalesProject.Entity.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public virtual List<OrderProduct> OrderProducts { get; set; }
        public int StoreroomId { get; set; }
        public virtual Storeroom Storeroom { get; set; }



    }
}