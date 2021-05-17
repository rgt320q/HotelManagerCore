using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IRoomService
    {
        IDataResult<List<Room>> GetAll();
        IDataResult<Room> Get(Expression<Func<Room, bool>> filter);
        IResult Add(Room room);
    }
}
