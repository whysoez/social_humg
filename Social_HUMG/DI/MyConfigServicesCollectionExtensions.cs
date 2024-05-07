using Social_HUMG.Repository.IReprositoryServives;
using Social_HUMG.Repository.RepositoryServices;
using Social_HUMG.Services.IServices;
using Social_HUMG.Services.ServicesImplement;
using System.Runtime.CompilerServices;

namespace Social_HUMG.DI
{
    public static class MyConfigServicesCollectionExtensions
    {
        public static IServiceCollection AddConfig(
            this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }

        public static IServiceCollection AddMyDenpendencyServicesGroup(
            this IServiceCollection services)
        {
            services.AddScoped<IGroupServices, GroupServices>();
            services.AddScoped<IPostServices, PostServices>();
            services.AddScoped<IEmployeeServices, EmployeeServices>();
            return services;
        }
        public static IServiceCollection AddMyDenpendencyRepositoryServicesGroup(
            this IServiceCollection services)
        {
            services.AddScoped<IGroupRepositoryServices, GroupRepositoryServices>();
            services.AddScoped<IPostRepositoryServices, PostRepositoryServices>();
            services.AddScoped<IEmployeeRepositoryServices, EmployeeRepositoryServices>();
            return services;
        }
    }
}
