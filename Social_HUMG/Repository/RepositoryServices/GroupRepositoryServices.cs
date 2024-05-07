using Social_HUMG.Common;
using Social_HUMG.Common.Entity;
using Social_HUMG.Data;
using Social_HUMG.Data.Entities;
using Social_HUMG.Repository.IReprositoryServives;

namespace Social_HUMG.Repository.RepositoryServices
{
    public class GroupRepositoryServices : BaseRepositoryServices<GroupEntity>, IGroupRepositoryServices
    {
        private readonly ILogger<GroupRepositoryServices> _logger;
        public GroupRepositoryServices(SocialDbContext context, ILogger<GroupRepositoryServices> logger) : base(context)
        {
            _logger = logger;
        }
        public void Delete(GroupEntity entity)
        {
            base.Delete(entity);
        }

        public async Task<List<GroupEntity>> GetAllAsync()
        {
            return await base.GetAllAsync();
        }

        public async Task<GroupEntity?> GetByIdAsync(Guid id)
        {
            return await base.GetByIdAsync(id);
        }

        public IQueryable<GroupEntity> GetQueryable()
        {
            throw new NotImplementedException();
        }

        public void Insert(GroupEntity entity)
        {
            base.Insert(entity);
        }

        public async Task SavechangeAsync()
        {
            await base.SavechangeAsync();
        }

        public void Update(GroupEntity entity)
        {
            base.Update(entity);
        }

        public async Task SetDelete(Guid id)
        {
            var result = await base.GetByIdAsync(id);
            result.Delete = true;
            base.Update(result);
            await base.SavechangeAsync();
        }
    }
}
