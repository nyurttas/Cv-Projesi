using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Ymyp67CvEntity.Concrete;
using Ymyp67CvEntity.Dtos.About;

namespace Ymyp67CvBusiness.Abstract
{
    public interface IAboutService : IGenericService<About, AboutResponseDto, AboutCreateRequestDto, AboutUpdateRequestDto, AboutDetailResponseDto>
    {
    }
}
