using Microsoft.EntityFrameworkCore;
using Social_HUMG.Data;

namespace Social_HUMG.Common
{
    public class BaseRepositoryServices<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly SocialDbContext _context;
        public BaseRepositoryServices(SocialDbContext context)
        {
            _context = context;
        }
        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(Guid id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return _context.Set<TEntity>();
        }

        public void Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public Task SavechangeAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
    }
}
