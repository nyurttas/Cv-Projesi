using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Education
{
    public sealed record EducationUpdateRequestDto(
      Guid Id,
      string School,
      string Section,
      decimal GPA,
      string Grade,
      string Organisation,
      DateTime StartDate,
      DateTime? EndDate,
        bool isActive,
        bool isDeleted
  ) : IUpdateDto;

}
