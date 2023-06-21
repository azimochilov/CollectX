﻿using CollectX.Domain.Commons;
using System.Linq.Expressions;

namespace CollectX.Data.IRepositories;
public interface IRepository<T> where T : Auditable
{
    ValueTask<T> InsertAsync(T entity);
    T Update(T entity);
    IQueryable<T> SelectAll(Expression<Func<T, bool>> expression = null);
    ValueTask<T> SelectAsync(Expression<Func<T, bool>> expression);
    ValueTask<bool> DeleteAsync(Expression<Func<T, bool>> expression);
    ValueTask SaveAsync();
}
