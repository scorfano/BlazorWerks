using Microsoft.Extensions.DependencyInjection;

namespace BlazorWerks.WebStorage
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWebStorage(this IServiceCollection services)
        {
            services.AddTransient<ILocalStorage, LocalStorage>();
            services.AddTransient<ISessionStorage, SessionStorage>();

            return services;
        }
    }
}
