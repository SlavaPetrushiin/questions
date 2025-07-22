namespace Questions.Contracts;

public record UpdateQuestionDto(string title, string text, List<Guid> tags);
