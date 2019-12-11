using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudAngalurDemo.Models;
using CrudAngalurDemo.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;

namespace CrudAngalurDemo
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

            //use clean
        var installerClass= typeof(Startup).Assembly.ExportedTypes.Where(x => typeof(Iinstaller).IsAssignableFrom(x) && !x.IsInterface && 
        !x.IsAbstract).Select(Activator.CreateInstance).Cast<Iinstaller>().ToList();

            installerClass.ForEach(installer => installer.installServies(Configuration, services));




        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //var swaggerOption = new SwaggerOption();
            //Configuration.GetSection(nameof(SwaggerOption)).Bind(swaggerOption);
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseCors(option => option.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader());
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }

    public class MvcInstaller : Iinstaller
    {
        public void installServies(IConfiguration Configuration, IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddJsonOptions(options =>
            {
                var resolver = options.SerializerSettings.ContractResolver;
                if (resolver != null)
                    (resolver as DefaultContractResolver).NamingStrategy = null;
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });


            services.AddTransient<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();

            services.AddCors();
        }
    }

    public class DataInstaller : Iinstaller
    {
        public void installServies(IConfiguration Configuration, IServiceCollection services)
        {
            services.AddDbContext<PaymentDbContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("PaymentDemoCore"));

            });
        }
    }

    public interface Iinstaller
    {
        void installServies(IConfiguration Configuration, IServiceCollection services);
    }
}
