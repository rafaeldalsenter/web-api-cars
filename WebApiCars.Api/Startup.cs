using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.GraphiQL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApiCars.Api.Configs;
using WebApiCars.Api.GraphQL;
using WebApiCars.Application.Services;
using WebApiCars.CrossCutting;
using WebApiCars.CrossCutting.Dtos;

namespace WebApiCars.Api
{
    public class Startup
    {
        private readonly IocStartup _iocStartup;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _iocStartup = new IocStartup();
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<WebApiCarsContext>(options => options.UseInMemoryDatabase("InMemoryDatabase"));
            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));

            _iocStartup.Configure(services);

            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            services.AddGraphQL(o => { o.ExposeExceptions = true; }).AddWebSockets();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            IAutoMakerServices autoMakerService)
        {
            autoMakerService.Create(new AutoMakerDto { Name = "Gurgel", Country = "Brazil" });
            autoMakerService.Create(new AutoMakerDto { Name = "Ford", Country = "United States" });

            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseWebSockets();

            app.UseGraphQLWebSockets<ApiScheme>();
            app.UseGraphQL<ApiScheme>();
            app.UseGraphiQLServer(new GraphiQLOptions());

            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }
}