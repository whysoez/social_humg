using Microsoft.AspNetCore.Mvc;
using Social_HUMG.Models;
using Social_HUMG.Services.IServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Social_HUMG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostServices _postServices;

        public PostController(IPostServices postServices)
        {
            _postServices = postServices;
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
            return await _postServices.GetListPostByGroup(id);
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
