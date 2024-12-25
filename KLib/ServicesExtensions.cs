using KLib.Services;
using Microsoft.Extensions.DependencyInjection;

namespace KLib;

public static class ServicesExtensions
{
    public static IServiceCollection AddKLib(this IServiceCollection services)
    {
        services.AddSingleton<ISessionService, SessionService>();
        if (!services.Any(x => x.ServiceType.Name.Contains("MessagePipe")))
            services.AddMessagePipe();
        services.AddScoped<IKLibService, KLibService>();
        return services;
    }
}