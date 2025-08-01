﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Education
{
    public sealed record EducationResponseDto(
        Guid Id,
        string School,
        string Section,
        decimal GPA,
        string Grade,
        string Organisation,
        DateTime StartDate,
        DateTime? EndDate
    ) : IResponseDto;

}
