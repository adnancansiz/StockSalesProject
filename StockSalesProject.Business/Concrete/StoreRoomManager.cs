using StockSalesProject.Business.Abstract;
using StockSalesProject.DataAccess.Abstract;
using StockSalesProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace StockSalesProject.Business.Concrete
{
    public class StoreRoomManager : IStoreroomService
    {
        private IStoreroomDal _storeroomDal;

        public StoreRoomManager(IStoreroomDal storeroomDal)
        {
            _storeroomDal = storeroomDal;
        }

        public void Add(Storeroom entity)
        {
            _storeroomDal.Add(entity);
        }

        public void Delete(Storeroom entity)
        {
            _storeroomDal.Delete(entity);
        }

        public Storeroom Get(Expression<Func<Storeroom, bool>> filter)
        {
            return _storeroomDal.Get(filter);
        }

        public List<Storeroom> GetAll(Expression<Func<Storeroom, bool>> filter = null)
        {
            return _storeroomDal.GetAll(filter);
        }

        public void Update(Storeroom entity)
        {
            _storeroomDal.Update(entity);
        }
    }
}