using Core.DataAccess.Abstract;
using StockSalesProject.Entity.Concrete;

namespace StockSalesProject.DataAccess.Abstract
{
    public interface IOrderDal : IEntityRepository<Order>
    {
    }
}