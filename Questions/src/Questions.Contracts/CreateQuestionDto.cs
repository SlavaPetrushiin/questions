namespace Questions.Contracts;

public record CreateQuestionDto(string title, string text, Guid userId, List<Guid> tags);
