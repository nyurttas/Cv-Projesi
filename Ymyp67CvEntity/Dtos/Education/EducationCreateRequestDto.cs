using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Education
{
    public sealed record EducationCreateRequestDto(
    
      string School,
      string Department,
      string Section,
      decimal GPA,
      string Grade,
    
      DateTime StartDate,
      DateTime? EndDate
  ) : ICreateDto;

}
