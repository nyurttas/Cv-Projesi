using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Certificate
{
    public sealed record CertificateResponseDto (
    Guid Id,
    string Title,
    string Degree,
    string Organisation,
    string Description,
    DateTime DateAt
    ) : IResponseDto;
}
