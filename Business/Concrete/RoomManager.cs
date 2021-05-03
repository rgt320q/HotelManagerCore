using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class RoomManager : IRoomService
    {
        IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public IResult Add(Room room)
        {
            _roomDal.Add(room);

            return new SuccessResult("Room successfully added.");
        }

        public IDataResult<List<Room>> GetAll()
        {
            return new SuccessDataResult<List<Room>>(_roomDal.GetAll());
        }
    }
}
