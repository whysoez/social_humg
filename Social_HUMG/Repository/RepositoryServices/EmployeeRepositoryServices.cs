using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Social_HUMG.Common;
using Social_HUMG.Data;
using Social_HUMG.Data.Entities;
using Social_HUMG.Repository.IReprositoryServives;

namespace Social_HUMG.Repository.RepositoryServices
{
    public class EmployeeRepositoryServices : BaseRepositoryServices<EmployeeEntity>, IEmployeeRepositoryServices
    {
        private readonly ILogger<EmployeeRepositoryServices> _logger;
        public EmployeeRepositoryServices(SocialDbContext context, ILogger<EmployeeRepositoryServices> logger) : base(context)
        {
            _logger = logger;
        }

        public void Delete(EmployeeEntity entity)
        {
            base.Delete(entity);
        }

        public async Task<List<EmployeeEntity>> GetAllAsync()
        {
            return await base.GetAllAsync();
        }

        public async Task<EmployeeEntity?> GetByIdAsync(Guid id)
        {
            return await base.GetByIdAsync(id);
        }

        public IQueryable<EmployeeEntity> GetQueryable()
        {
            throw new NotImplementedException();
        }

        public void Insert(EmployeeEntity entity)
        {
            base.Insert(entity);
        }

        public async Task SavechangeAsync()
        {
             await base.SavechangeAsync();
        }

        public void Update(EmployeeEntity entity)
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
