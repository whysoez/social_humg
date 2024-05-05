using AutoMapper;
using Social_HUMG.Data.Entities;
using Social_HUMG.Models;
using Social_HUMG.Repository.IReprositoryServives;
using Social_HUMG.Services.IServices;

namespace Social_HUMG.Services.ServicesImplement
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeRepositoryServices _employeeRepositoryServices;
        private readonly IMapper _mapper;
        public EmployeeServices(IEmployeeRepositoryServices employeeRepositoryServices, IMapper mapper)
        {
            _employeeRepositoryServices = employeeRepositoryServices;
            _mapper = mapper;
        }

        public async Task CreateEmployee(EmployeeModel employee)
        {
            var employeeEntity = _mapper.Map<EmployeeEntity>(employee);
            _employeeRepositoryServices.Insert(employeeEntity);
            await _employeeRepositoryServices.SavechangeAsync();
        }

        public async Task<List<EmployeeModel>> GetAllEmployee()
        {
            var result = await _employeeRepositoryServices.GetAllAsync();
            return new();
        }
    }
}
