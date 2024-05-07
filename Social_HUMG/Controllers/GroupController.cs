using Microsoft.AspNetCore.Mvc;
using Social_HUMG.Models;
using Social_HUMG.Services.IServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Social_HUMG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupServices _groupServices;

        public GroupController(IGroupServices groupServices)
        {
            _groupServices = groupServices;
        }

        // GET: api/<GroupController>
        [HttpGet()]
        [Route("getall")]
        public async Task<List<GroupModel>> GetAll()
        {
            return await _groupServices.GetAll();
        }

        // GET api/<GroupController>/5
        [HttpGet()]
        [Route("getbyid")]
        public async Task<GroupModel> Get(Guid id)
        {
            return await _groupServices.GetById(id);
        }

        // POST api/<GroupController>
        [HttpPost()]
        [Route("creategroup")]
        public async Task CreateGroup(GroupModel model)
        {
            await _groupServices.Create(model);
        }

        // PUT api/<GroupController>/5
        [HttpPost()]
        [Route("updategroup")]
        public async Task UpdateGroup(GroupModel model)
        {
            await _groupServices.Update(model);
        }

        // DELETE api/<GroupController>/5
        [HttpDelete()]
        [Route("delete")]
        public async Task Delete(Guid id)
        {
            await _groupServices.Delete(id);
        }
    }
}
