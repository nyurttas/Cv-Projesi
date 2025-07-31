using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results;
using Ymyp67CvEntity.Concrete;
using Ymyp67CvEntity.Dtos.Contact;

namespace Ymyp67CvBusiness.Abstract;

public interface IContactService : IGenericService<Contact, ContactResponseDto, ContactCreateRequestDto, ContactUpdateRequestDto, ContactDetailResponseDto>
{
    Task<IDataResult<IEnumerable<ContactResponseDto>>> GetContactListByCityAsync(string city);
}