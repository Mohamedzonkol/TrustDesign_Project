using Microsoft.EntityFrameworkCore.Query;
using TrustDesign_Core.Interfaces.Wrappers.Parametars;

namespace TrustDesign_Core.Interfaces.Reporesitories
{
    public interface IReporostory<T> : IDisposable where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task<T> Add(T entity);
        Task<T> Update(Guid id, T entity);
        Task<T> Delete(Guid id);
        Task<IQueryable<T>> GetPagedAsync(PagedRequest request, params Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includeprop);
    }
}
