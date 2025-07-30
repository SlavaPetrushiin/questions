using Questions.Application;

namespace Questions.Web;

public static class DependencyInjection
{
    public static IServiceCollection AddProgram(this IServiceCollection services)
    {

        return services
            .AddWebDependencies()
            .AddApplication();
    }

    private static IServiceCollection AddWebDependencies(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddOpenApi();

        return services;
    }
}
