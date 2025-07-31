﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Utilities.Results;

namespace Core.Business;
public interface IGenericService<TEntity, TResponse, in TCreate, in TUpdate, TDetail>
    where TEntity : BaseEntity, new()
    where TResponse : class, IResponseDto
    where TCreate : class, ICreateDto
    where TUpdate : class, IUpdateDto
    where TDetail : class, IDetailDto
{
    Task<IDataResult<TResponse>> AddAsync(TCreate dto);
    Task<IResult> UpdateAsync(TUpdate dto);
    Task<IResult> RemoveAsync(Guid id);
    Task<IDataResult<TResponse>> GetByIdAsync(Guid id);
    Task<IDataResult<IEnumerable<TResponse>>> GetAllAsync();
}