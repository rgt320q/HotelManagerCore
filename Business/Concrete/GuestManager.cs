using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class GuestManager : IGuestService
    {
        IGuestDal _guestDal;

        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public IResult Add(Guest guest)
        {
            _guestDal.Add(guest);

            return new SuccessResult("Guest successfully added.");
        }

        public IDataResult<List<Guest>> GetAll()
        {
            return new SuccessDataResult<List<Guest>>(_guestDal.GetAll());
        }
    }
}
