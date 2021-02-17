using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockSalesProject.Entity.Concrete
{
    public class Storeroom : IEntity
    {
        public int StoreroomId { get; set; }
        public string StoreroomName { get; set; }


        public virtual List<Product> Products { get; set; }
        
        public Company Company { get; set; }
        public int CompanyId { get; set; }

    }
}