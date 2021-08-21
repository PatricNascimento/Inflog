using Infolog.DataAccess;
using Infolog.DataAccess.Repositores;
using Infolog.Domain.Repositores;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infolog.Web
{
    public static class DependencyInjectionExtensions
    {
        public const string ConnectionString = "server=127.0.0.1;port=3306;user=root;password=123456;database=dev_infolog";
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            #region Configurações MySql EF Core
            services.AddEntityFrameworkMySql()
             .AddDbContext<InfologDbContext>(options =>
             {
                 options.UseLazyLoadingProxies();
                 options.UseMySql(ConnectionString, ServerVersion.AutoDetect(ConnectionString),
                      opts =>
                      {
                          opts.MigrationsAssembly(typeof(InfologDbContext).Assembly.GetName().Name);
                      });
             });
            #endregion

            #region Repositories
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            #endregion

            return services;
        }
    }
}