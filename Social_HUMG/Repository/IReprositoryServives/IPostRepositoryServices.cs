using Social_HUMG.Common;
using Social_HUMG.Common.Entity;

namespace Social_HUMG.Repository.IReprositoryServives
{
    public interface IPostRepositoryServices : IBaseRepository<PostEntity>
    {
        Task<List<PostEntity>> GetAllAsync();
        Task<PostEntity?> GetByIdAsync(Guid id);
        Task<List<PostEntity>> GetListPostByGroup(Guid id);
        IQueryable<PostEntity> GetQueryable();
        void Insert(PostEntity entity);
        void Update(PostEntity entity);
        void Delete(PostEntity entity);
        Task SavechangeAsync();
    }
}
