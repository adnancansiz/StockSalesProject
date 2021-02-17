using Core.DataAccess.Abstract;
using StockSalesProject.Entity.Concrete;

namespace StockSalesProject.DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}