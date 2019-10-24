using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;
using TagShop.Api.AutoMapper;
using TagShop.Business;
using TagShop.Business.Interfaces;
using TagShop.Repository;
using TagShop.Repository.Interfaces;
using TagShop.Repository.Utilities;
using TagShop.Services;
using TagShop.Services.Interfaces;

namespace TagShop.Api
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
            services.AddControllers();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            DependencyInjection(services);
        }



        public void DependencyInjection(IServiceCollection services)
        {
            // AutoMapper
            var mapperConfig = AutoMapperConfig.RegisterMappings();
            services.AddSingleton(mapperConfig.CreateMapper());

            services.AddSingleton<IConnectionFactory, ConnectionFactory>();
            services.AddSingleton<ICategoryRepository, CategoryRepository>();
            services.AddTransient<ICategoryBusiness, CategoryBusiness>();
            services.AddTransient<ICategoryServices, CategoryServices>();

            //services.AddTransient<IHttpFactory, HttpFactory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Ativando middlewares para uso do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "API TAG-Shop");
            });

            if (env.EnvironmentName == "Development")
            {
                app.UseDeveloperExceptionPage();
            }

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
