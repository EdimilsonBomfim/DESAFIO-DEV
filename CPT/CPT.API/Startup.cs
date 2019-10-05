using CPT.Business;
using CPT.Business.Interface;
using CPT.Repository;
using CPT.Repository.Factories;
using CPT.Repository.Factories.Interfaces;
using CPT.Repository.Interface;
using CPT.Services;
using CPT.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CPT.API
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
            services.AddSingleton(Configuration);

            services.AddSingleton<IConnectionFactory, ConnectionFactory>();        

            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoBusiness, ProdutoBusiness>();
            services.AddScoped<IProdutoServices, ProdutoService>();

            services.AddCors();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(c =>
            {
                c.AllowAnyHeader();
                c.AllowAnyMethod();
                c.AllowAnyOrigin();
            });

            app.UseMvc();
        }
    }
}
