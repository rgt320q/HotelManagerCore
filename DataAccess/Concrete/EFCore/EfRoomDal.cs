using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EFCore
{
    public class EfRoomDal : EfEntityRepositoryBase<Room, MainContext>, IRoomDal
    {
    }
}
