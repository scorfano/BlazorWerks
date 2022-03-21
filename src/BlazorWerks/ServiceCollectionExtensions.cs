using Microsoft.Extensions.DependencyInjection;
using BlazorWerks.Twitter;
using BlazorWerks.WebStorage;

namespace BlazorWerks
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazorWerks(this IServiceCollection services)
        {
            services.AddTwitterBootstrap();

            services.AddWebStorage();

            return services;
        }
    }
}
