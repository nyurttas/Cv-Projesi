using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results;
using Ymyp67CvEntity.Concrete;
using Ymyp67CvEntity.Dtos.Experince;

namespace Ymyp67CvBusiness.Abstract
{
    public interface IExperienceService : IGenericService<Experience, ExperienceResponseDto, ExperienceCreateRequestDto, ExperienceUpdateRequestDto, ExperienceDetailResponseDto>
    {
        Task<IDataResult<IEnumerable<ExperienceResponseDto>>> GetExperiencesByCompanyAsync(string company);
    }
}
