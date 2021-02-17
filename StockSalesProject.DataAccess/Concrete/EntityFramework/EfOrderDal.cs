using Core.DataAccess.Concrete.EntityFramework;
using StockSalesProject.DataAccess.Abstract;
using StockSalesProject.DataAccess.Concrete.EntityFramework.Context;
using StockSalesProject.Entity.Concrete;


namespace StockSalesProject.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, StockSalesContext>, IOrderDal
    {
    }
}