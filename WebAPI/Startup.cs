using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStore.EF;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Ticketing
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;

        public Startup(IWebHostEnvironment env)
        {
            this._env = env;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            //using in memory db ONLY during dev
            //if (_env.IsDevelopment())
            //{
                services.AddDbContext<TicketsContext>(options =>
                {
                    options.UseInMemoryDatabase("Tickets");
                });
            //}

            services.AddApiVersioning(options =>
            {
                options.ReportApiVersions = true;
                options.AssumeDefaultVersionWhenUnspecified = true;
                //options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                //options.ApiVersionReader = new HeaderApiVersionReader("X-API-Version");
            });

            //services.AddVersionedApiExplorer(options => options.GroupNameFormat = "'v'VVV");
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("https://localhost:44383")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });

            services.AddSwaggerGen();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, TicketsContext context)
        {
            
            //if (_env.IsDevelopment())
            //{
                app.UseDeveloperExceptionPage();
                //Create the in-memory database for dev environment
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();


                //Configure OpenAPI
                app.UseSwagger();
                app.UseSwaggerUI();
                //app.UseSwaggerUI(
                //        options =>
                //        {
                //            options.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1");
                //        });
           // }

            app.UseRouting();

            //app.UseAuthorization();
            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
