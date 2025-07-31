using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Ymyp67CvEntity.Concrete;
using Ymyp67CvEntity.Dtos.PersonalInfo;

namespace Ymyp67CvBusiness.Abstract;

public interface IPersonalInfoService : IGenericService<PersonalInfo, PersonalInfoResponseDto, PersonalInfoCreateRequestDto, PersonalInfoUpdateReQuestDto, PersonalInfoDetailResponseDto>
{
}
