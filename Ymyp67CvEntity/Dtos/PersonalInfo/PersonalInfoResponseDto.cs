using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Ymyp67CvEntity.Dtos.PersonalInfo
{
    public sealed record PersonalInfoResponseDto(
      Guid Id,
    string FirstName,
    string LastName,
    string ImageUrl,
    bool MaritalStatus,
    string Gender,
    string DrivingLicence,
    DateTime BirthDate,
    string BirthPlace,
    string Nationality
    ) : IResponseDto;

}
