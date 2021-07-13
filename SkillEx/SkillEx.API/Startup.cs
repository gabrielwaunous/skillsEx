using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SkillEx.Repository.Core.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using SkillEx.Repository.Core;
using SkillEx.Repository.Core.Interfaces;
using SkillEx.Repository.Helpers;
using SkillEx.Repository.Helpers.Loggers;
using SkillEx.Repository.Helpers.Serializers;
using SkillEx.Repository.Helpers.Seeds;
using ILogger = SkillEx.Repository.Core.Interfaces.ILogger;

namespace SkillEx.API
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
            services.AddControllers();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo() { Title = "Pharmacy Business Manager Solution", Version = "v0.1" });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //options.IncludeXmlComments(xmlPath);
                options.UseInlineDefinitionsForEnums();
            });

            services.AddCors();
            services.AddScoped<IClaimEngine, ClaimEngine>();
            services.AddScoped<IClaimsSource, JsonFileClaimSource>();
            services.AddScoped<IClaimSerializer, JsonClaimSerializer>();
            services.AddScoped<IImportProcess, ImportProcess>();
            services.AddScoped<ILogger, FileLogger>();
            services.AddScoped<IClaimFactory, ClaimFactory>();
            
            

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseSwagger(o => o.SerializeAsV2 = true);

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Pharmacy Business Manager Solution v0.1");
            });

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
