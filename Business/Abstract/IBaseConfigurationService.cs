using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IBaseConfigurationService
    {
        IDataResult<List<BaseConfiguration>> GetAll();
        IDataResult<BaseConfiguration> GetLastOrDefault(Expression<Func<BaseConfiguration, object>> filter);
        IResult Add(BaseConfiguration baseConfiguration);
    }
}
