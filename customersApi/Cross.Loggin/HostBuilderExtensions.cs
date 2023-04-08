using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace Cross.Logging
{
    public static class HostBuilderExtensions
    {
        public static IServiceCollection AddLogWriting(this IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("loggingsettings.json", optional:false)
                .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
            
            services.AddSingleton(Log.Logger);

            return services;
        }
    }
}
