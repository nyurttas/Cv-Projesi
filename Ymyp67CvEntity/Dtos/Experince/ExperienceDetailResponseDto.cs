using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Experince
{
    public sealed record ExperienceDetailResponseDto(
       Guid Id,
    string Title,
    string Company,
    string Description,
    DateTime StartDate,
    DateTime? EndDate,
    bool IsActive,
    bool IsDeleted

   ) : IDetailDto;

}
