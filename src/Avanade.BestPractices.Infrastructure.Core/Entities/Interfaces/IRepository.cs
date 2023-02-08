using System.Linq.Expressions;

namespace Avanade.BestPractices.Infrastructure.Core.Entities.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        #region Add
        Task AddAsync(T entity);
        Task AddRangAsync(List<T> entities);
        #endregion

        #region Find
        Task<List<T>> FindAsync(Expression<Func<T, bool>> expression);
        #endregion

        #region Get
        Task<T> GetByIdAsync(Guid id);
        Task<List<T>> GetAllAsync();
        #endregion

        #region Update
        void Update(T entity);
        void UpdatRange(List<T> entities);
        #endregion

        #region Remove
        void Remove(T entity);
        void RemoveRange(List<T> entities);
        #endregion

        #region Queryable
        IQueryable<T> Query();
        #endregion
    }
}
