using JackDaniels.Application.Services;
using JackDaniels.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JackDaniels.Application.ApplicationModule
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddServices();

            services.AddDbContext<ApplicationDbContext>(opts =>
            {
                string connectionSql = configuration.GetConnectionString("JackSQL")!;
                opts.UseSqlServer(connectionSql);

            });

            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {

            services.AddScoped(typeof(IProductOrderItems), typeof(Services.ProductOrderItems));
            services.AddScoped(typeof(IProductService), typeof(ProductService));
            //services.AddScoped(typeof(IProdutoRepository), typeof(ProdutoRepository));


            return services;
        }
    }
}
