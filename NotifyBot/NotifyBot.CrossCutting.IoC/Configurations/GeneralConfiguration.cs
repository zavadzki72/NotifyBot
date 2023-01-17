using Microsoft.Extensions.DependencyInjection;
using NotifyBot.Data.MySql;
using NotifyBot.Domain.Models.Interfaces;

namespace NotifyBot.CrossCutting.IoC.Configurations
{
    public static class GeneralConfiguration
    {
        public static void AddGeneralConfiguration(this IServiceCollection services)
        {
            services.AddApplicationConfiguration();
            services.AddDomainConfiguration();
            services.AddInfraConfiguration();
        }

        private static void AddApplicationConfiguration(this IServiceCollection services)
        {
        }

        private static void AddDomainConfiguration(this IServiceCollection services)
        {
        }

        private static void AddInfraConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
