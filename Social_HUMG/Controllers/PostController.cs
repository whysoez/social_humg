using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Social_HUMG.Models;
using Social_HUMG.Services.IServices;
using Social_HUMG.SignalR;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Social_HUMG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostServices _postServices;
        private readonly IHubContext<SignalrHub, IHubClient> _signalrHub;
        public PostController(IPostServices postServices, IHubContext<SignalrHub, IHubClient> signalrHub)
        {
            _postServices = postServices;
            _signalrHub = signalrHub;
        }

        // GET: api/<GroupController>
        [HttpGet()]
        [Route("getall")]
        public async Task<List<PostModel>> GetAll()
        {
            return await _postServices.GetAll();
        }

        [HttpGet()]
        [Route("getlistpostbygroup")]
        public async Task<List<PostDto>> GetListPostByGroup(Guid id)
        {
            var result = await _postServices.GetListPostByGroup(id);
            await _signalrHub.Clients.All.PostMessage(result);
            return result;
        }

        // GET api/<GroupController>/5
        [HttpGet()]
        [Route("getbyid")]
        public async Task<PostModel> Get(Guid id)
        {
            return await _postServices.GetById(id);
        }

        // POST api/<GroupController>
        [HttpPost()]
        [Route("createpost")]
        public async Task Create(PostModel model)
        {
            await _postServices.Create(model);
        }

        // PUT api/<GroupController>/5
        [HttpPost()]
        [Route("update")]
        public async Task Update(PostModel model)
        {
            await _postServices.Update(model);
        }

        // DELETE api/<GroupController>/5
        [HttpDelete()]
        [Route("delete")]
        public async Task Delete(Guid id)
        {
            await _postServices.Delete(id);
        }
    }
}
