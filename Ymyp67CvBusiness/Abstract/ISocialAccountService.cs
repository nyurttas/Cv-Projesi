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
    public interface ISocialAccountService : IGenericService<SocialAccount>
    {
        // Burada IGenericService<T> interface'ini implement eden SocialAccount entity'si için özel metotlar ekleyebiliriz.
        // Örneğin, belirli bir sosyal medya platformuna göre filtreleme gibi.
        Task<IDataResult<SocialAccount>> GetSocialAccountByNameAsync();
        Task<IDataResult<IEnumerable<SocialAccount>>> GetSocialAccountByUserNameAsync();
    }
}
