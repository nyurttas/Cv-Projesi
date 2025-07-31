using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Education
{
    public sealed record EducationCreateRequestDto(
    
      string School,
      string Section,
      decimal GPA,
      string Grade,
      string Organisation,
      DateTime StartDate,
      DateTime? EndDate
  ) : ICreateDto;

}
