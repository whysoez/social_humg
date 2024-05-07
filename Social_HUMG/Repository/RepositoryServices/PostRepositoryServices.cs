using Microsoft.EntityFrameworkCore;
using Social_HUMG.Common;
using Social_HUMG.Common.Entity;
using Social_HUMG.Data;
using Social_HUMG.Repository.IReprositoryServives;

namespace Social_HUMG.Repository.RepositoryServices
{
    public class PostRepositoryServices : BaseRepositoryServices<PostEntity>, IPostRepositoryServices
    {
        private readonly ILogger<EmployeeRepositoryServices> _logger;
        public PostRepositoryServices(SocialDbContext context, ILogger<EmployeeRepositoryServices> logger) : base(context)
        {
            _logger = logger;
        }
        public void Delete(PostEntity entity)
        {
            base.Delete(entity);
        }

        public async Task<List<PostEntity>> GetAllAsync()
        {
            return await base.GetAllAsync();
        }

        public async Task<PostEntity?> GetByIdAsync(Guid id)
        {
            return await base.GetByIdAsync(id);
        }

        public IQueryable<PostEntity> GetQueryable()
        {
            throw new NotImplementedException();
        }

        public void Insert(PostEntity entity)
        {
            base.Insert(entity);
        }

        public async Task SavechangeAsync()
        {
            await base.SavechangeAsync();
        }

        public void Update(PostEntity entity)
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

        public async Task<List<PostEntity>> GetListPostByGroup(Guid id)
        {
            return await base._context.Post.Where(x => !x.Delete && x.GroupId == id).ToListAsync();
        }
    }
}
