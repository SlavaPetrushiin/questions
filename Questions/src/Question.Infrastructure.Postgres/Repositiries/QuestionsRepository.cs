using Questions.Application.Questions;

namespace Question.Infrastructure.Postgres.Repositiries;

public class QuestionsRepository(QuestionsDbContext questionsDbContext) : IQuestionRepository
{
    public async Task<Guid> CreateAsync(Questions.Domain.Questions.Question question, CancellationToken cancellationToken)
    {
        await questionsDbContext.Questions.AddAsync(question, cancellationToken);

        await questionsDbContext.SaveChangesAsync();

        return question.Id;
    }

    public Task<Guid> DeleteAsync(Guid questionId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Questions.Domain.Questions.Question>> GetAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Questions.Domain.Questions.Question> GetByIdAsync(Guid questionId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetUnresolvedUserQuestionAsync(Guid userId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Guid> UpdateAsync(Questions.Domain.Questions.Question question, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
