using Core.Utilities.Results;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBaseConfigurationService
    {
        IDataResult<List<BaseConfiguration>> GetAll();
        IDataResult<BaseConfiguration> GetLastOrDefault();
        IResult Add(BaseConfiguration baseConfiguration);
    }
}
