using Core.Utilities.Results;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRoomService
    {
        IDataResult<List<Room>> GetAll();
        IResult Add(Room room);
    }
}
