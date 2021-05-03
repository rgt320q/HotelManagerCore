using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    class BaseConfigurationManager : IBaseConfigurationService
    {
        IBaseConfigurationDal _baseConfigurationDal;

        public BaseConfigurationManager(IBaseConfigurationDal baseConfigurationDal)
        {
            _baseConfigurationDal = baseConfigurationDal;
        }

        public IResult Add(BaseConfiguration baseConfiguration)
        {
            _baseConfigurationDal.Add(baseConfiguration);

            return new SuccessResult("Base Configuration successfully added.");
        }

        public IDataResult<List<BaseConfiguration>> GetAll()
        {
            return new SuccessDataResult<List<BaseConfiguration>>(_baseConfigurationDal.GetAll());
        }

        public IDataResult<BaseConfiguration> GetLastOrDefault()
        {
            return new SuccessDataResult<BaseConfiguration>(_baseConfigurationDal.GetAll().LastOrDefault());
        }
    }
}
