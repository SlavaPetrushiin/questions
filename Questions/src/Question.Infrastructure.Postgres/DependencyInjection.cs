using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Question.Infrastructure.Postgres.Repositiries;
using Questions.Application.Questions;

namespace Question.Infrastructure.Postgres;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructurePostgres(this IServiceCollection services, IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString("PostgresConnection");

        services.AddDbContext<QuestionsDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });

        services.AddScoped<IQuestionRepository, QuestionsRepository>();

        return services;
    }
}
