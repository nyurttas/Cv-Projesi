using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Contact
{
    public sealed record ContactUpdateRequestDto(
       Guid Id,
       string Address,
       string City,
       string Town,
       string Phone,
       string Email,
       bool IsActive,
       bool IsDeleted

       ) : IUpdateDto;


}
