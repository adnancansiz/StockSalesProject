
using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockSalesProject.Entity.Concrete
{
    public class Company : IEntity
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int TotalStock { get; set; }
        public decimal TotalAssets { get; set; }


        public virtual List<Storeroom> Storerooms { get; set; }
        public virtual List<Order> Orders { get; set; }


    }
}