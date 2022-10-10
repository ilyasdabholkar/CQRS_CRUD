using ContactManagement.Persistence.Context;
using ContactManagement.Persistence.Interfaces;
using ContactManagement.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ContactManagement.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection ImplementPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(
                configuration.GetConnectionString("LocalDbConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
                ),
                ServiceLifetime.Transient
            );

            //services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
            services.AddScoped<IContactRepository, ContactRepository>();

            return services;
        }
    }
}