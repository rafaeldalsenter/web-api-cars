using GraphQL;
using GraphQL.Http;
using GraphQL.Server;
using GraphQL.Server.Ui.GraphiQL;
using GraphQL.Server.Ui.Playground;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApiCars.Api.GraphQl;
using WebApiCars.Application.Repositories;
using WebApiCars.Application.Services;
using WebApiCars.CrossCutting;
using WebApiCars.CrossCutting.Dtos;

namespace WebApiCars.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<WebApiCarsContext>(options
                => options.UseInMemoryDatabase("InMemoryDatabase"));

            services.AddScoped<IAutoMakerRepository, AutoMakerRepository>();
            services.AddScoped<IAutoMakerServices, AutoMakerServices>();

            services.AddScoped<IDependencyResolver>(s =>
                      new FuncDependencyResolver(s.GetRequiredService));

            services.AddScoped<ApiScheme>();
            services.AddScoped<ApiQuery>();
            services.AddScoped<AutoMakerType>();

            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            services.AddGraphQL(o => { o.ExposeExceptions = true; }).AddWebSockets();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            IAutoMakerServices autoMakerService)
        {
            autoMakerService.Create(new AutoMakerDto { Name = "Teste" });
            autoMakerService.Create(new AutoMakerDto { Name = "Teste2" });

            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseWebSockets();

            app.UseGraphQLWebSockets<ApiScheme>("/graphql");
            app.UseGraphQL<ApiScheme>("/graphql");
            app.UseGraphiQLServer(new GraphiQLOptions());
            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }
}