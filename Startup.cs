using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCReactPortfolioTextParseService
{
    public class Startup
    {
        static readonly string CORS_NAME= "NCReactPortfolioWebsite";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services
                .AddControllers()
                .AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NCReactPortfolioTextParseService", Version = "v1" });
            });

#if !DEBUG
            // Without this, receive CORS errors :(
            // See https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-5.0 for more info.
            services.AddCors(options =>
            {
                options.AddPolicy(CORS_NAME,
                    builder => builder.WithOrigins("https://chrissiddall.azurefd.net"));
            });
#endif
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "NCReactPortfolioTextParseService v1"));
            }

            app.UseRouting();
            app.UseCors(CORS_NAME);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
