using JackDaniels.Core.Interfaces.Repositories;
using JackDaniels.Infrastructure.DatabaseContext;
using JackDaniels.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JackDaniels.Infrastructure.InfrastructureModule
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddRepositories();

            services.AddDbContext<ApplicationDbContext>(opts =>
            {
                string connectionSql = configuration.GetConnectionString("JackSQL")!;
                opts.UseSqlServer(connectionSql);

            });

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {

            services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
            services.AddScoped(typeof(IProductOrderRepository), typeof(ProductOrder));


            return services;
        }
    }
}
