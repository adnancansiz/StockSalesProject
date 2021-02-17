using StockSalesProject.Business.Abstract;
using StockSalesProject.DataAccess.Abstract;
using StockSalesProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace StockSalesProject.Business.Concrete
{
    public class SupplierManager : ISupplierService
    {
        private ISupplierDal _supplierDal;

        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }

        public void Add(Supplier entity)
        {
            _supplierDal.Add(entity);
        }

        public void Delete(Supplier entity)
        {
            _supplierDal.Delete(entity);
        }

        public Supplier Get(Expression<Func<Supplier, bool>> filter)
        {
            return _supplierDal.Get(filter);
        }

        public List<Supplier> GetAll(Expression<Func<Supplier, bool>> filter = null)
        {
            return _supplierDal.GetAll(filter);
        }

        public void Update(Supplier entity)
        {
            _supplierDal.Update(entity);
        }
    }
}