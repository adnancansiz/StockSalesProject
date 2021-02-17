using StockSalesProject.Business.Abstract;
using StockSalesProject.DataAccess.Abstract;
using StockSalesProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace StockSalesProject.Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public void Add(Department entity)
        {
            _departmentDal.Add(entity);
        }

        public void Delete(Department entity)
        {
            _departmentDal.Delete(entity);
        }

        public Department Get(Expression<Func<Department, bool>> filter)
        {
            return _departmentDal.Get(filter);
        }

        public List<Department> GetAll(Expression<Func<Department, bool>> filter = null)
        {
            return _departmentDal.GetAll(filter);
        }

        public void Update(Department entity)
        {
            _departmentDal.Update(entity);
        }
    }
}