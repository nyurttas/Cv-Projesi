using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Language
{
    public sealed record LanguageDetailResponseDto(
    Guid Id,
       string Name,
       byte Level,
       bool IsActive,
       bool IsDeleted
   ) : IDetailDto;




}
