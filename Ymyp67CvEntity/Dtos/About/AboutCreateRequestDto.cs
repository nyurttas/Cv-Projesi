using Core.Entities;

namespace Ymyp67CvEntity.Dtos.About
{
    public sealed record AboutCreateRequestDto(
      
       string Description,
       byte Order
   ) : ICreateDto;




}
