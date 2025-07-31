using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Interest
{
    public sealed record InterestDetailResponseDto(
       Guid Id,
       string Description,
       byte Order,
       bool IsActive,
       bool IsDeleted
   ) : IDetailDto;

}
