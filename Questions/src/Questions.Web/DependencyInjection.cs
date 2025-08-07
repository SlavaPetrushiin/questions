using Question.Infrastructure.Postgres;
using Questions.Application;

namespace Questions.Web;

public static class DependencyInjection
{
    public static IServiceCollection AddProgram(this IServiceCollection services, IConfiguration configuration)
    {

        return services
            .AddWebDependencies()
            .AddApplication()
            .AddInfrastructurePostgres(configuration);
    }

    private static IServiceCollection AddWebDependencies(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddOpenApi();

        return services;
    }
}
