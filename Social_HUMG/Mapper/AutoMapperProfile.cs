using AutoMapper;
using Social_HUMG.Data.Entities;
using Social_HUMG.Models;

namespace Social_HUMG.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EmployeeModel, EmployeeEntity>();
            CreateMap<EmployeeEntity, EmployeeModel>();
        }
    }
}
