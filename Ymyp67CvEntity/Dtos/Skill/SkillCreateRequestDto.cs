using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Skill
{
    public sealed record SkillCreateRequestDto(
       string Title,
       string Icon,
       bool IsProgramLanguageAndTool
   ) : ICreateDto;
}
