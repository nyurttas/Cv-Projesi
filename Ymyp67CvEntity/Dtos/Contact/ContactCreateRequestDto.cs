using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Contact
{
    public sealed record ContactCreateRequestDto(
    string Address,
    string City,
    string Town,
    string Phone,
    string Email

       ) : ICreateDto;


}
