using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Marktguru.DataLayer.Repository.Implementation;
using Marktguru.DataLayer.Repository.Interfaces;

namespace Marktguru.DataLayer.Extensions
{
    public static class RegisterDataLayer
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductModelRepository, ProductModelRepository>();

            services.AddDbContext<DataContext>(options =>
                {
                    options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
                });

            return services;
        }
    }
}