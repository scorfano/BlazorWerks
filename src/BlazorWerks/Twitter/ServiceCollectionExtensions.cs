using Microsoft.Extensions.DependencyInjection;
using BlazorWerks.Twitter;
using BlazorWerks.WebStorage;

namespace BlazorWerks.Twitter
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTwitterBootstrap(this IServiceCollection services)
        {
            services.AddSingleton<IBootstrap, Bootstrap>();

            return services;
        }
    }
}
