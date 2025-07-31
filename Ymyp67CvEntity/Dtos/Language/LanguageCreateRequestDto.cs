using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Language
{
    public sealed record LanguageCreateRequestDto(
      
       string Name,
       byte Level
   ) : ICreateDto;




}
