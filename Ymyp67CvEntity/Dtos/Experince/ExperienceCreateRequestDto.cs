using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Experince
{
    public sealed record ExperienceCreateRequestDto(
   
       string Title,
       string Company,
       DateTime StartDate,
       DateTime? EndDate,
       string Description

   ) : ICreateDto;

}
