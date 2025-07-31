using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Experince
{
    public sealed record ExperienceUpdateRequestDto(
       Guid Id,
       string Title,
       string Company,
       DateTime StartDate,
       DateTime? EndDate,
       string Description,
        bool isActive,
        bool isDeleted

   ) : IUpdateDto;

}
