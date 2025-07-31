using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results;
using Ymyp67CvEntity.Concrete;
using Ymyp67CvEntity.Dtos.About;
using Ymyp67CvEntity.Dtos.Certificate;

namespace Ymyp67CvBusiness.Abstract;



   public interface ICertificateService : IGenericService<Certificate, CertificateResponseDto, CertificateCreateRequestDto, CertificateUpdateRequestDto, CertificateDetailResponseDto>
{
    Task<IDataResult<IEnumerable<CertificateResponseDto>>> GetCertificatesByOrganisationAsync(string organisation);
}
