using Microsoft.Extensions.DependencyInjection;
using WebApiCars.Api.GraphQL;
using WebApiCars.Api.GraphQL.Types;
using WebApiCars.Application.Repositories;
using WebApiCars.Application.Services;

namespace WebApiCars.Api.Configs
{
    public class IocStartup
    {
        public void Configure(IServiceCollection services)
        {
            ConfigureServices(services);
            ConfigureGraphQLObjects(services);
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IAutoMakerRepository, AutoMakerRepository>();
            services.AddScoped<IAutoMakerServices, AutoMakerServices>();
        }

        private void ConfigureGraphQLObjects(IServiceCollection services)
        {
            services.AddScoped<ApiScheme>();
            services.AddScoped<ApiQuery>();
            services.AddScoped<ApiMutation>();
            services.AddScoped<AutoMakerType>();
            services.AddScoped<AutoMakerInputType>();
        }
    }
}