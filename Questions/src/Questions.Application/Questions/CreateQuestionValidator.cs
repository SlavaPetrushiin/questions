namespace Questions.Application.Questions;
public class CreateQuestionValidator : AbstractValidator<CreateQuestionDto>
{
    public CreateQuestionValidator()
    {
        RuleFor(question => question.title).NotEmpty().MaximumLength(50).WithMessage("Невалидный заголовок вопроса");
        RuleFor(question => question.text).NotEmpty().MaximumLength(500).WithMessage("Невалидный текст вопроса");
        RuleFor(question => question.userId).NotEmpty().WithMessage("Невалидный userId");
    }
}
