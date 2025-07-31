using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Experince
{
    public sealed record ExperienceResponseDto(
        Guid Id,
        string Title,
        string Company,
        DateTime StartDate,
        DateTime? EndDate,
        string Description
        
    ) : IResponseDto;

}
