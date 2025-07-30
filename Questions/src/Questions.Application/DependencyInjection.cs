using Microsoft.Extensions.DependencyInjection;
using Questions.Application.Questions;

namespace Questions.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);
        services.AddScoped<IQuestionsService, QuestionsService>();

        return services;
    }
}
