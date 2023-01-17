using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NotifyBot.Data.MySql;

namespace NotifyBot.CrossCutting.IoC.Configurations
{
    public static class EntityFrameworkConfiguration
    {
        public static void AddEntityFrameworkConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["SQL_CONNECTION"];

            services.AddDbContext<ApplicationDbContext>(options => {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)).UseSnakeCaseNamingConvention();
            }, ServiceLifetime.Scoped);
        }
    }
}
