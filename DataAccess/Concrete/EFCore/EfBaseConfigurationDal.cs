using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EFCore
{
    public class EfBaseConfigurationDal : EfEntityRepositoryBase<BaseConfiguration, MainContext>, IBaseConfigurationDal
    {
    }
}
