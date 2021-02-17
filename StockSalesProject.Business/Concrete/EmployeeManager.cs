using StockSalesProject.Business.Abstract;
using StockSalesProject.DataAccess.Abstract;
using StockSalesProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace StockSalesProject.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void Add(Employee entity)
        {
            _employeeDal.Add(entity);
        }

        public void Delete(Employee entity)
        {
            _employeeDal.Delete(entity);
        }

        public Employee Get(Expression<Func<Employee, bool>> filter)
        {
            return _employeeDal.Get(filter);
        }

        public List<Employee> GetAll(Expression<Func<Employee, bool>> filter = null)
        {
            return _employeeDal.GetAll(filter);
        }

        public void Update(Employee entity)
        {
            _employeeDal.Update(entity);
        }
    }
}