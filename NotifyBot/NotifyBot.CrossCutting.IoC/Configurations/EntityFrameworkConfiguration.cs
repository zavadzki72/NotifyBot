using Microsoft.AspNetCore.Identity;
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
            var connectionStringIdentity = configuration["SQL_CONNECTION_IDENTITY"];

            services.AddDbContext<ApplicationDbContext>(options => {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)).UseSnakeCaseNamingConvention();
            }, ServiceLifetime.Scoped);

            services.AddDbContext<IdentityContext>(options => {
                options.UseMySql(connectionStringIdentity, ServerVersion.AutoDetect(connectionStringIdentity));
            });

            services.AddIdentityCore<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<ApplicationDbContext>();
        }
    }
}
