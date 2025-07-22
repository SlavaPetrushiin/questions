namespace Questions.Contracts;

public record GetQuestionDto(string search, List<Guid> tags, int page, int limit);
