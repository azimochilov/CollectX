﻿using CollectX.Data.DbContexts;
using CollectX.Data.IRepositories;
using CollectX.Domain.Commons;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CollectX.Data.Repositories;
public class Repository<T> : IRepository<T> where T : Auditable
{
    protected readonly AppDbContext dbContext;
    protected readonly DbSet<T> dbSet;
    public Repository(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
        this.dbSet = dbContext.Set<T>();
    }

    public async ValueTask<bool> DeleteAsync(Expression<Func<T, bool>> expression)
    {
        var entity = await SelectAsync(expression);
        if (entity is not null)
        {
            entity.IsDeleted = true;
            return true;
        }

        return false;
    }

    public async ValueTask<T> InsertAsync(T entity)
    {
        var entityEntry = await dbSet.AddAsync(entity);

        return entityEntry.Entity;
    }

    public async ValueTask SaveAsync()
    {
        await dbContext.SaveChangesAsync();
    }

    public IQueryable<T> SelectAll(Expression<Func<T, bool>> expression = null)
    {
        IQueryable<T> query = expression is null ? this.dbSet : this.dbSet.Where(expression);
        return query;
    }

    public async ValueTask<T> SelectAsync(Expression<Func<T, bool>> expression)
           => await this.SelectAll(expression).FirstOrDefaultAsync(t => !t.IsDeleted);

    public T Update(T entity)
    {
        EntityEntry<T> entityEntry = this.dbContext.Update(entity);

        return entityEntry.Entity;
    }
}
