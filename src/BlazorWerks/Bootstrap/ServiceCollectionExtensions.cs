using Microsoft.Extensions.DependencyInjection;

namespace BlazorWerks.Bootstrap
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBootstrapTools(this IServiceCollection services)
        {
            services.AddSingleton<IBootstrap, Bootstrap>();

            return services;
        }
    }
}
