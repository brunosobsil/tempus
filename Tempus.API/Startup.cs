using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Tempus.BLL.Services;
using Tempus.Data.Model;
using Tempus.Data.Repository;
using NHibernate.Tool.hbm2ddl;

namespace Tempus.API
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Tempus.API", Version = "v1" });
            });

            // Services
            services.AddTransient<IFuncaoService, FuncaoService>();
            services.AddTransient<IDepartamentoService, DepartamentoService>();
            services.AddTransient<IFuncionarioService, FuncionarioService>();
            services.AddTransient<IEmpresaService, EmpresaService>();
            services.AddTransient<IRelogioService, RelogioService>();

            //Repositories
            services.AddTransient<IFuncaoRepository, FuncaoRepository>();
            services.AddTransient<IDepartamentoRepository, DepartamentoRepository>();
            services.AddTransient<IEmpresaRepository, EmpresaRepository>();

            // Session Factory
            var connStr = Configuration.GetConnectionString("DefaultConnection");
            var sessionFactory = Fluently.Configure()
                   .Database(PostgreSQLConfiguration.PostgreSQL82.ConnectionString(connStr))
                   .Mappings(m => m.FluentMappings.AddFromAssemblyOf<FuncaoMap>())
                   .ExposeConfiguration(cfg => {
                       new SchemaUpdate(cfg).Execute(true, true);
                   })
                   .BuildSessionFactory();
            
            services.AddScoped(factory => {
                return sessionFactory.OpenSession();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tempus.API v1"));
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
