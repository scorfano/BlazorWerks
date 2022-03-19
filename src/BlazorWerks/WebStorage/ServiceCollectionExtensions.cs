using Microsoft.Extensions.DependencyInjection;

namespace BlazorWerks.WebStorage
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWebStorageTools(this IServiceCollection services)
        {
            services.AddTransient<ILocalStorage, LocalStorage>();
            services.AddTransient<ISessionStorage, SessionStorage>();

            return services;
        }
    }
}
