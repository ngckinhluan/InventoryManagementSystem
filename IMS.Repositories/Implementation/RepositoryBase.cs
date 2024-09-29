using IMS.BusinessObjects.Models;
using IMS.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IMS.Repositories.Implementation
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected InventoryManagementSystemContext Context;

        public RepositoryBase(InventoryManagementSystemContext context) => Context = context;
        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
                Context.Set<T>()
                    .AsNoTracking() :
                Context.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
            bool trackChanges) =>
            !trackChanges ?
                Context.Set<T>()
                    .Where(expression)
                    .AsNoTracking() :
                Context.Set<T>()
                    .Where(expression);

        public async Task CreateAsync(T entity)
        {
            await Context.Set<T>().AddAsync(entity); 
            await Context.SaveChangesAsync(); 
        }

        public async Task UpdateAsync(T entity)
        {
            Context.Set<T>().Update(entity); 
            await Context.SaveChangesAsync(); 
        }

        public async Task DeleteAsync(T entity)
        {
            Context.Set<T>().Remove(entity); 
            await Context.SaveChangesAsync(); 
        }
    }
}
