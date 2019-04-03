using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EFGetStarted.AspNetCore.NewDb.Models;
using Microsoft.EntityFrameworkCore;
using Vendas.Service;
using Vendas.Service.Impl;
using AutoMapper;

namespace Vendas
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
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddAutoMapper();

            //services.AddScoped<IMapper, Mapper>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                        .AddJsonOptions(
            options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
        );

            var connection = @"Server=(localdb)\mssqllocaldb;Database=EFVendas.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<ContextoBanco>
                (options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IMapper autoMapper,)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<ContextoBanco>();
                context.Database.Migrate();
            }


            autoMapper.ConfigurationProvider.AssertConfigurationIsValid();
            
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
