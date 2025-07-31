using Core.Entities;

namespace Ymyp67CvEntity.Dtos.PersonalInfo
{
    public sealed record PersonalInfoCreateRequestDto(
   
     string FirstName,
     string LastName,
     string ImageUrl,
     bool MaritalStatus,
     string Gender,
     string DrivingLicence,
     string Country,
     DateTime BirthDate,
     string BirthPlace,
     string Nationality
 ) : ICreateDto;

}
