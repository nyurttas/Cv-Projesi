using Core.Entities;

namespace Ymyp67CvEntity.Dtos.About
{
    public sealed record AboutDetailResponseDto(
       Guid Id,
       string Description,
       byte Order,
       bool IsActive,
       bool IsDeleted
   ) : IDetailDto;




}
