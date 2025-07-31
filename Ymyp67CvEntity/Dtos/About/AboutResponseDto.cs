using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Ymyp67CvEntity.Dtos.About
{
    public sealed record AboutResponseDto(
        Guid Id,  
        string Description,
        byte Order       
    ): IResponseDto;




}
