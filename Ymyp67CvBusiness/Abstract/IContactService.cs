using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results;
using Ymyp67CvEntity.Concrete;

namespace Ymyp67CvBusiness.Abstract
{
    public interface IContactService : IGenericService<Contact>
    {
        // Burada IGenericService<T> interface'ini implement eden Contact entity'si için özel metotlar ekleyebiliriz.
        // Örneğin, belirli bir iletişim bilgilerini şehire göre filtrelemek gibi.
        Task<IDataResult<IEnumerable<Contact>>> GetContactListByCityAsync();
    }
}
