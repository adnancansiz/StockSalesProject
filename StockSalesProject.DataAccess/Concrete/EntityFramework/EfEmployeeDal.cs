using Core.DataAccess.Concrete.EntityFramework;
using StockSalesProject.DataAccess.Abstract;
using StockSalesProject.DataAccess.Concrete.EntityFramework.Context;
using StockSalesProject.Entity.Concrete;
using System;
using System.Linq.Expressions;

namespace StockSalesProject.DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, StockSalesContext>, IEmployeeDal
    {
    }
}