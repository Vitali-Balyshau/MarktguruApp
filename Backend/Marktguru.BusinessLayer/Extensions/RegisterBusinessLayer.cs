using Marktguru.BusinessLayer.Implementation;
using Marktguru.BusinessLayer.Interfaces;
using Marktguru.DataLayer.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Marktguru.BusinessLayer.Extensions
{
    public static class RegisterBusinessLayer
    {
        public static IServiceCollection RegisterBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterRepositories(configuration);
            
            services.AddScoped<IProductModelBusiness, ProductModelBusiness>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserAccountBusiness, UserAccountBusiness>();

            return services;
        }
    }
}