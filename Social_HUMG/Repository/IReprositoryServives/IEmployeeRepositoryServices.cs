using Social_HUMG.Common;
using Social_HUMG.Data.Entities;

namespace Social_HUMG.Repository.IReprositoryServives
{
    public interface IEmployeeRepositoryServices : IBaseRepository<EmployeeEntity>
    {
        Task<List<EmployeeEntity>> GetAllAsync();
        Task<EmployeeEntity?> GetByIdAsync(Guid id);
        IQueryable<EmployeeEntity> GetQueryable();
        void Insert(EmployeeEntity entity);
        void Update(EmployeeEntity entity);
        void Delete(EmployeeEntity entity);
        Task SavechangeAsync();
    }
}
