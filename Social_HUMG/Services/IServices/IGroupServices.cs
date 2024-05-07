using Social_HUMG.Models;

namespace Social_HUMG.Services.IServices
{
    public interface IGroupServices
    {
        Task<List<GroupModel>> GetAll();
        Task Create(GroupModel employee);
        Task<GroupModel> GetById(Guid employeeId);
        Task<bool> Update(GroupModel employee);
        Task<bool> Delete(Guid employeeId);
    }
}
