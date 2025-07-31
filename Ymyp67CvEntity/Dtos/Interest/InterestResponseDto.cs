using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Interest
{
    public sealed record InterestResponseDto(
        Guid Id,
        string Description,
        byte Order
    ) : IResponseDto;

}
