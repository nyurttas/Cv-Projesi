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
    public interface IExperienceService : IGenericService<Experience>
    {
        // Burada IGenericService<T> interface'ini implement eden Experience entity'si için özel metotlar ekleyebiliriz.
        // Örneğin, belirli bir iş deneyimini şirkete göre filtrelemek gibi.
        Task<IDataResult<IEnumerable<Experience>>> GetExperiencesByCompanyAsync(string company);

      
    }
}
