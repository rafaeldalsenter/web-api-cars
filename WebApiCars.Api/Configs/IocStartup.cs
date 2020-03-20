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
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IAutoMakerServices, AutoMakerServices>();
            services.AddScoped<ICarServices, CarServices>();
        }

        private void ConfigureGraphQLObjects(IServiceCollection services)
        {
            services.AddScoped<ApiScheme>();
            services.AddScoped<ApiQuery>();
            services.AddScoped<ApiMutation>();
            services.AddScoped<AutoMakerType>();
            services.AddScoped<AutoMakerInputType>();
            services.AddScoped<CarType>();
            services.AddScoped<CarInputType>();
        }
    }
}