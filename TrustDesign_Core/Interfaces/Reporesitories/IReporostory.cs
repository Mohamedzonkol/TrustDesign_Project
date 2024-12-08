using Microsoft.EntityFrameworkCore.Query;

namespace TrustDesign_Core.Interfaces.Reporesitories
{
    public interface IReporostory<T> : IDisposable where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
        Task<IQueryable<T>> GetPagedAsync(PagedRequest request, params Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includeprop);
    }
}
