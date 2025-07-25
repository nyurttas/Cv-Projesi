using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results;
using Ymyp67CvEntity.Concrete;

namespace Ymyp67CvBusiness.Abstract
{
    public interface IEducationService : IGenericService<Education>
    {
        Task<IDataResult<Education>> GetEducationAsync(string grade);
        Task<IResult> AnyContinueAsync();

    }
}
