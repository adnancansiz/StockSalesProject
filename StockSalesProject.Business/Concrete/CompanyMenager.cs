using StockSalesProject.Business.Abstract;
using StockSalesProject.DataAccess.Abstract;
using StockSalesProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace StockSalesProject.Business.Concrete
{
    public class CompanyMenager : ICompanyService
    {
        private ICompanyDal _companyDal;

        public CompanyMenager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public void Add(Company entity)
        {
            _companyDal.Add(entity);
        }

        public void Delete(Company entity)
        {
            _companyDal.Delete(entity);
        }

        public Company Get(Expression<Func<Company, bool>> filter)
        {
            return _companyDal.Get(filter);
        }

        public List<Company> GetAll(Expression<Func<Company, bool>> filter = null)
        {
            return _companyDal.GetAll(filter);
        }

        public void Update(Company entity)
        {
            _companyDal.Update(entity);
        }
    }
}