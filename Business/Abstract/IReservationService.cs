using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IReservationService
    {
        IDataResult<List<Reservation>> GetAll(Expression<Func<Reservation, bool>> filter);

        IDataResult<Reservation> GetOneInclude(
            Expression<Func<Reservation, object>> 
            include,Expression<Func<Reservation, bool>> filter);

        IDataResult<Reservation> GetTwoIncludes(
            Expression<Func<Reservation, object>> includeOne, 
            Expression<Func<Reservation, object>> includeTwo, 
            Expression<Func<Reservation, bool>> filter);

        IDataResult<Reservation> GetThreeIncludes(
            Expression<Func<Reservation, object>> includeOne, 
            Expression<Func<Reservation, object>> includeTwo, 
            Expression<Func<Reservation, object>> includeThree,           
            Expression<Func<Reservation, bool>> filter);

        IDataResult<Reservation> Get(Expression<Func<Reservation, bool>> filter);
        IResult Add(Reservation reservation);
        IResult Update(Reservation reservation);
        IResult Delete(Reservation reservation);
        IResult HardDelete(Reservation reservation);

    }
}
