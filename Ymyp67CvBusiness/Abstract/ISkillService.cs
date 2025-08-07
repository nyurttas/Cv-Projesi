using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results;
using Ymyp67CvEntity.Concrete;
using Ymyp67CvEntity.Dtos.Skill;

namespace Ymyp67CvBusiness.Abstract
{
    public interface ISkillService : IGenericService<Skill, SkillResponseDto, SkillCreateRequestDto, SkillUpdateRequestDto, SkillDetailResponseDto>
    {
        Task<IDataResult<IEnumerable<SkillResponseDto>>> GetSkillsProgramLanguagesAsync();
        Task<IDataResult<IEnumerable<SkillResponseDto>>> GetWorkflowsAsync();
    }
}
