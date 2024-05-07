using Social_HUMG.Models;

namespace Social_HUMG.Services.IServices
{
    public interface IPostServices
    {
        Task<List<PostModel>> GetAll();
        Task Create(PostModel employee);
        Task<PostModel> GetById(Guid employeeId);
        Task<bool> Update(PostModel employee);
        Task<bool> Delete(Guid employeeId);
        Task<List<PostDto>> GetListPostByGroup(Guid groupId);
    }
}
