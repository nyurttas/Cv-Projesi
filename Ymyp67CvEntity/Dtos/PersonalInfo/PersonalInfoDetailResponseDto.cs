using Core.Entities;

namespace Ymyp67CvEntity.Dtos.PersonalInfo
{
    public sealed record PersonalInfoDetailResponseDto(
     Guid Id,
     string FirstName,
     string LastName,
     string ImageUrl,
     bool MaritalStatus,
     string Gender,
     string DrivingLicence,
     string Country,
     DateTime BirthDate,
     string BirthPlace,
     string Nationality,
     bool IsActive,
        bool IsDeleted
 ) : IDetailDto;

}
