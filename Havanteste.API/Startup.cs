using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HavanTeste.Domain.Interfaces;
using HavanTeste.Services.Services;
using HavanTeste.Domain.Entity;
using HavanTeste.Domain.Interfaces.Repository;
using HavanTeste.Domain.Repository;

namespace Havanteste.API
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

            services.AddDbContext<HavanContext>(options => options.UseNpgsql(Configuration.GetConnectionString("HavanConect")));
            

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Havanteste.API", Version = "v1" });
                c.ResolveConflictingActions(x => x.First());
            });


            //services.AddDbContext<HavanContext>(options =>
            //    options.UseNpgsql(Configuration.GetConnectionString("Connectionstring")));
            services.AddMemoryCache();

            services.AddScoped<IProdutoService, ProdutoServices>();
            services.AddScoped<IFamiliaProdutoService, FamiliaProdutoServices>();

            services.AddScoped<IProdutoRepository, RepositoryProduto>();
            services.AddScoped<IFamiliaProdutoRepository, RepositoryFamiliaProduto>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Havanteste.API");
                });
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseHttpsRedirection();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
