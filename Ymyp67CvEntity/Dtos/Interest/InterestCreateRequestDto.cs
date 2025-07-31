using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Interest
{
    public sealed record InterestCreateRequestDto(
    
       string Description,
       byte Order
   ) : ICreateDto;

}
