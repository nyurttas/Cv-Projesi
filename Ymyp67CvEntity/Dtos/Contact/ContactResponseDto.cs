using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Ymyp67CvEntity.Dtos.Contact
{
    public sealed record ContactResponseDto (
        Guid Id,
        string Address,
        string City,
        string Town,
        string Phone,
        string Email

        ) : IResponseDto;


}
