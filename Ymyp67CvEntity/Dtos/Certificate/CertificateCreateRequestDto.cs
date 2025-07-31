using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Certificate
{
    public sealed record CertificateCreateRequestDto(
    string Title,
    string Degree,
    string Organisation,
    string Description,
    DateTime DateAt

   ) : ICreateDto;
}
