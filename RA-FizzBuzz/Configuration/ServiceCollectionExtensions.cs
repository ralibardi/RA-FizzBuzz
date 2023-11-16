namespace RA_FizzBuzz.Configuration;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services)
    {
        services.ConfigureDependencies();

        return services;
    }

    public static IServiceCollection ConfigureDependencies(this IServiceCollection services)
    {
        services.AddSingleton<IFizzBuzz, FizzBuzz>();
        services.AddSingleton<IFizzBuzzRule, FizzRule>();
        services.AddSingleton<IFizzBuzzRule, BuzzRule>();
        services.AddSingleton<IFizzBuzzRule, FizzBuzzRule>();

        return services;
    }
}
