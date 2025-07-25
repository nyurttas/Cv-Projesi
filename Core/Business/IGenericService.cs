using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Utilities.Results;

namespace Core.Business
{
    public interface IGenericService<T> where T : class, IEntity, new()
    {

        Task<IDataResult<T>> AddAsync(T entity);
        Task<IResult> UpdateAsync(T entity);
        Task<IResult> RemoveAsync(Guid id);

        Task<IDataResult<T>> GetByIdAsync(Guid id);
      
        Task<IDataResult<IEnumerable<T>>> GetAllAsync();
        


    }
}
