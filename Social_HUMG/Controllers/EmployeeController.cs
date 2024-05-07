using Microsoft.AspNetCore.Mvc;
using Social_HUMG.Models;
using Social_HUMG.Services.IServices;

namespace Social_HUMG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeServices _employeeServices;

        public EmployeeController(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;
        }

        [HttpPost()]
        [Route("getbyid")]
        public async Task<EmployeeModel> GetById(Guid id)
        {
            return await _employeeServices.GetById(id);
        }

        [HttpGet()]
        [Route("getallemployee")]
        public async Task<List<EmployeeModel>> GetAllEmployees()
        {
            return await _employeeServices.GetAllEmployee();
        }

        [HttpPost()]
        [Route("createemployee")]
        public async Task CreateEmployee([FromBody]EmployeeModel model)
        {
            await _employeeServices.CreateEmployee(model);
        }
    }
}
