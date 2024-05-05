namespace Social_HUMG.Common
{
    public interface IBaseRepository<TEntity>
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(Guid id);
        IQueryable<TEntity> GetQueryable();
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task SavechangeAsync();
    }
}
