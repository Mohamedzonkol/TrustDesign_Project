using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using TrustDesgin_Persistence.DbContext;
using TrustDesign_Core.Interfaces.Reporesitories;
using TrustDesign_Core.Interfaces.Wrappers.Parametars;

namespace TrustDesgin_Persistence.Reporsitoriers
{
    public class Reporsitory<T> : IReporostory<T> where T : class, new()
    {
        private readonly ApplicationDbContext _context;
        protected IQueryable<T> _query;
        protected DbSet<T> _dbSet;
        public Reporsitory(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
            _query = _dbSet.AsQueryable();
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<T> GetAll(Expression<Func<T, bool>> expression = null)
        {
            return await _query.FirstOrDefaultAsync(expression);

        }

        public async Task<T> GetById(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Update(Guid id, T entity)
        {
            var ExEntity = await _dbSet.FindAsync(id);
            if (ExEntity != null)
            {
                _context.Entry(ExEntity).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();
                return ExEntity;
            }
            return null;
        }

        public async Task Delete(Guid id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }

        }

        public Task<IQueryable<T>> GetPagedAsync(PagedRequest request, params Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includeprop)
        {
            if (request.IsSearch)
            {
                if (request.Fillters.GroubBy == "AND")
                {
                    foreach (var rule in request.Fillters.Rules)
                    {

                    }
                }
            }

        }
    }
}
