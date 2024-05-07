using Social_HUMG.Common;
using Social_HUMG.Common.Entity;
using Social_HUMG.Data.Entities;

namespace Social_HUMG.Repository.IReprositoryServives
{
    public interface IGroupRepositoryServices : IBaseRepository<GroupEntity>
    {
        Task<List<GroupEntity>> GetAllAsync();
        Task<GroupEntity?> GetByIdAsync(Guid id);
        IQueryable<GroupEntity> GetQueryable();
        void Insert(GroupEntity entity);
        void Update(GroupEntity entity);
        void Delete(GroupEntity entity);
        Task SavechangeAsync();
    }
}
