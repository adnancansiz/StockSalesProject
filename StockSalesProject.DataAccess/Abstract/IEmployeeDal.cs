using Core.DataAccess.Abstract;
using StockSalesProject.Entity.Concrete;
using System;
using System.Linq.Expressions;

namespace StockSalesProject.DataAccess.Abstract
{
    public interface IEmployeeDal : IEntityRepository<Employee>
    {
    }
}