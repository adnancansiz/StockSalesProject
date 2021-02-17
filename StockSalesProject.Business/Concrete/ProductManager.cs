using StockSalesProject.Business.Abstract;
using StockSalesProject.DataAccess.Abstract;
using StockSalesProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace StockSalesProject.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product entity)
        {
            _productDal.Add(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            return _productDal.Get(filter);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _productDal.GetAll(filter);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}