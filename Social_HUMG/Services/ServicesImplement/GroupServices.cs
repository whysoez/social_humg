using AutoMapper;
using Social_HUMG.Common.Entity;
using Social_HUMG.Data.Entities;
using Social_HUMG.Models;
using Social_HUMG.Repository.IReprositoryServives;
using Social_HUMG.Services.IServices;

namespace Social_HUMG.Services.ServicesImplement
{
    public class GroupServices : IGroupServices
    {
        private readonly IGroupRepositoryServices _groupRepositoryServices;
        private readonly IMapper _mapper;
        public GroupServices(IGroupRepositoryServices groupRepositoryServices, IMapper mapper)
        {
            _groupRepositoryServices = groupRepositoryServices;
            _mapper = mapper;
        }

        public async Task Create(GroupModel model)
        {
            var entity = _mapper.Map<GroupEntity>(model);
            _groupRepositoryServices.Insert(entity);
            await _groupRepositoryServices.SavechangeAsync();
        }

        public async Task<bool> Delete(Guid id)
        {
            await _groupRepositoryServices.SetDelete(id);
            return true;
        }

        public async Task<List<GroupModel>> GetAll()
        {
            var list = await _groupRepositoryServices.GetAllAsync();
            var result = _mapper.Map<List<GroupModel>>(list);
            return result;
        }

        public async Task<GroupModel> GetById(Guid id)
        {
            var resultEntity = await _groupRepositoryServices.GetByIdAsync(id);
            var result = _mapper.Map<GroupModel>(resultEntity);
            return result;
        }

        public async Task<bool> Update(GroupModel model)
        {
            var entity = _mapper.Map<GroupEntity>(model);
            _groupRepositoryServices.Update(entity);
            await _groupRepositoryServices.SavechangeAsync();
            return true;
        }
    }
}
