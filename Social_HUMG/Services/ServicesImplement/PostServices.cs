using AutoMapper;
using Social_HUMG.Common.Entity;
using Social_HUMG.Models;
using Social_HUMG.Repository.IReprositoryServives;
using Social_HUMG.Services.IServices;

namespace Social_HUMG.Services.ServicesImplement
{
    public class PostServices : IPostServices
    {
        private readonly IPostRepositoryServices _postRepositoryServices;
        private readonly IMapper _mapper;
        public PostServices(IPostRepositoryServices postRepositoryServices, IMapper mapper)
        {
            _postRepositoryServices = postRepositoryServices;
            _mapper = mapper;
        }

        public async Task Create(PostModel model)
        {
            var entity = _mapper.Map<PostEntity>(model);
            _postRepositoryServices.Insert(entity);
            await _postRepositoryServices.SavechangeAsync();
        }

        public async Task<bool> Delete(Guid id)
        {
            await _postRepositoryServices.SetDelete(id);
            return true;
        }

        public async Task<List<PostModel>> GetAll()
        {
            var list = await _postRepositoryServices.GetAllAsync();
            var result = _mapper.Map<List<PostModel>>(list);
            return result;
        }

        public async Task<PostModel> GetById(Guid id)
        {
            var resultEntity = await _postRepositoryServices.GetByIdAsync(id);
            var result = _mapper.Map<PostModel>(resultEntity);
            return result;
        }

        public async Task<List<PostDto>> GetListPostByGroup(Guid groupId)
        {
            var listPost = await _postRepositoryServices.GetListPostByGroup(groupId);
            var listPostModel = _mapper.Map<List<PostModel>>(listPost);
            var groupPost = listPostModel.GroupBy(x => x.GroupId).Select(x => new PostDto() { Posts =  x.OrderBy(a => a.CreatedDate).ToList() } );
            return groupPost.ToList();
        }

        public async Task<bool> Update(PostModel model)
        {
            var entity = _mapper.Map<PostEntity>(model);
            _postRepositoryServices.Update(entity);
            await _postRepositoryServices.SavechangeAsync();
            return true;
        }
    }
}
