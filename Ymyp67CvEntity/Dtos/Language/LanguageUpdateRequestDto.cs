using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Language
{
    public sealed record LanguageUpdateRequestDto(
       Guid Id,
       string Name,
       byte Level,
       bool IsActive,
       bool IsDeleted
   ) : IUpdateDto;




}
