using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using TrustDesign_Core.Interfaces.Wrappers.Parametars;

namespace TrustDesign_Core.Interfaces.Reporesitories
{
    public interface IReporostory<T> : IDisposable where T : class, new()
    {
        Task<T> GetAll(Expression<Func<T, bool>> expression = null);
        Task<T> GetById(Guid id);
        Task<T> Add(T entity);
        Task<T> Update(Guid id, T entity);
        Task Delete(Guid id);
        Task<IQueryable<T>> GetPagedAsync(PagedRequest request, params Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includeprop);
    }
}
