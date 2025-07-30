using Questions.Domain.Questions;

namespace Questions.Application.Questions;
public interface IQuestionRepository
{
    public Task<Guid> CreateAsync(Question question, CancellationToken cancellationToken);

    public Task<Guid> UpdateAsync(Question question, CancellationToken cancellationToken);

    public Task<Guid> DeleteAsync(Guid questionId, CancellationToken cancellationToken);

    public Task<IEnumerable<Question>> GetAsync(CancellationToken cancellationToken);

    public Task<Question> GetByIdAsync(Guid questionId, CancellationToken cancellationToken);

    public Task<int> GetUnresolvedUserQuestionAsync(Guid userId, CancellationToken cancellationToken);
}
