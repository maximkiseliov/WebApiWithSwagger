using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TechnicalTestWebApi.Configurations;
using TechnicalTestWebApi.DB;

namespace TechnicalTestWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<RegistrationAppDbContext>(opt => opt.UseSqlServer(
            //        $"Data Source=LAPTOP-4S9643A1\\SQLEXPRESS;Initial Catalog={nameof(RegistrationAppDbContext)};Integrated Security=True"));
            services.AddDbContext<RegistrationAppDbContext>(opt => opt.UseInMemoryDatabase("InMemoryDb"));
            services.AddControllers();

            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var swaggerConfig = new SwaggerConfig();
            Configuration.GetSection(nameof(SwaggerConfig)).Bind(swaggerConfig);
            app.UseSwagger(opt => { opt.RouteTemplate = swaggerConfig.JsonRoute; });
            app.UseSwaggerUI(opt => { opt.SwaggerEndpoint(swaggerConfig.UiEndpoint, swaggerConfig.Description);});

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
