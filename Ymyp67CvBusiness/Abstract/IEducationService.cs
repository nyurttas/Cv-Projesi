using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results;
using Ymyp67CvEntity.Concrete;
using Ymyp67CvEntity.Dtos.Education;

namespace Ymyp67CvBusiness.Abstract;

    public interface IEducationService : IGenericService<Education, EducationResponseDto, EducationCreateRequestDto, EducationUpdateRequestDto, EducationDetailResponseDto>
    {
        Task<IDataResult<EducationResponseDto>> GetEducationAsync(string grade);
        Task<IResult> AnyContinueAsync();
    }
