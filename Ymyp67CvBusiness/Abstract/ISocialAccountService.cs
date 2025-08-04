using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results;
using Ymyp67CvEntity.Concrete;
using Ymyp67CvEntity.Dtos.SocialAccount;

namespace Ymyp67CvBusiness.Abstract
{
    public interface ISocialAccountService : IGenericService<SocialAccount, SocialAccountResponseDto, SocialAccountCreateRequestDto, SocialAccountUpdateRequestDto, SocialAccountDetailResponseDto>
    {
        Task<IDataResult<SocialAccountResponseDto>> GetSocialAccountByNameAsync(string platform);
        Task<IDataResult<IEnumerable<SocialAccountResponseDto>>> GetSocialAccountsByUserNameAsync(string username);
    }
}
