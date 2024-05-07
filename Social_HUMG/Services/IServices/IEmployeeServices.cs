using Social_HUMG.Data.Entities;
using Social_HUMG.Models;

namespace Social_HUMG.Services.IServices
{
    public interface IEmployeeServices
    {
        Task<List<EmployeeModel>> GetAllEmployee();
        Task CreateEmployee(EmployeeModel employee);
        Task<EmployeeModel> GetById(Guid employeeId);
        Task<bool> UpdateEmployee(EmployeeModel employee);
        Task<bool> Delete(Guid employeeId);
    }
}
