using HR.LeaveManagement.Persistence.DatabaseContext;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using HR.LeaveManagement.Persistence.Repositories;
using HR.LeaveManagement.Application.Contracts.Persistence;

namespace HR.LeaveManagement.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceService(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.AddDbContext<HrDatabaseContext>(options =>
            {
                options.UseMySql(
                   configuration.GetConnectionString("HrDatabaseContextDefault"),
                   new MySqlServerVersion(new Version(8, 0, 23))); 
            });

            services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
            services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
            services.AddScoped<ILeaveAllocationRepository, LeaveAllocationRepository>();
            services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();

            return services;
        }
    }
}
