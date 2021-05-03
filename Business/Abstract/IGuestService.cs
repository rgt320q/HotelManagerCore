using Core.Utilities.Results;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IGuestService
    {
        IDataResult<List<Guest>> GetAll();
        IResult Add(Guest guest);
    }
}
