using Core.Entities;

namespace Ymyp67CvEntity.Dtos.About
{
    public sealed record AboutUpdateRequestDto(
       Guid Id,
       string Description,
       byte Order,
       bool IsActive,
       bool IsDeleted
   ) : IUpdateDto;




}
