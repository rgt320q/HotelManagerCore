using Core.Utilities.Results;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IReservationService
    {
        IDataResult<List<Reservation>> GetAll();
        IResult Add(Reservation reservation);
    }
}
