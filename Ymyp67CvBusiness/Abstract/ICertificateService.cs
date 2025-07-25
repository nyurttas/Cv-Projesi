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
    public interface ICertificateService : IGenericService<Certificate>
    {
        // Burada IGenericService<T> interface'ini implement eden Certificate entity'si için özel metotlar ekleyebiliriz.
        // Örneğin, belirli bir sertifikayı kuruma göre filtrelemek gibi.
        Task<IDataResult<IEnumerable<Certificate>>> GetCertificatesByOrganisationAsync();
    }
}
