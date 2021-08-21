using Infolog.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infolog.Web
{
    public static class DependencyInjectionExtensions
    {
        public const string ConnectionString = "dev";
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
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

            return services;
        }
    }
}