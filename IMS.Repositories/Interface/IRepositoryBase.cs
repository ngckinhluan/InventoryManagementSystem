using System.Linq.Expressions;

namespace IMS.Repositories.Interface
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChange);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChange);
        Task CreateAsync(T entity);  // Convert to Task
        Task UpdateAsync(T entity);  // Convert to Task
        Task DeleteAsync(T entity);

    }
}
