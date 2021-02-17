using Core.DataAccess.Abstract;
using StockSalesProject.Entity.Concrete;

namespace StockSalesProject.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}