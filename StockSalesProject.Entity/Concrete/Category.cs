using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockSalesProject.Entity.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        public string Description { get; set; }



        public virtual List<Product> Products { get; set; }

    }
}