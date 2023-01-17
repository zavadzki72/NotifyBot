using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NotifyBot.CrossCutting.IoC.Configurations;

namespace NotifyBot.CrossCutting.IoC
{
    public static class WebConfiguration
    {
        public static void ApplyApiConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEntityFrameworkConfiguration(configuration);

            services.AddGeneralConfiguration();
        }
    }
}