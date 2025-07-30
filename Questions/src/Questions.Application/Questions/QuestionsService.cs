using Questions.Domain.Questions;

namespace Questions.Application.Questions;

public class QuestionsService : IQuestionsService
{

    private readonly IQuestionRepository _questionRepository;

    private readonly ILogger _logger;

    private readonly IValidator<CreateQuestionDto> _validator;

    public QuestionsService(IQuestionRepository questionRepository, IValidator<CreateQuestionDto> validator, ILogger<QuestionsService> logger)
    {
        _questionRepository = questionRepository;
        _logger = logger;
        _validator = validator;
    }

    //public async Task Get(GetQuestionDto questionDto, CancellationToken cancellationToken)
    //{

    //}


    //public async Task GetById(Guid question_id, CancellationToken cancellationToken)
    //{

    //}


    public async Task<Guid> Create(CreateQuestionDto questionDto, CancellationToken cancellationToken)
    {

        FluentValidation.Results.ValidationResult validationResult = await _validator.ValidateAsync(questionDto, cancellationToken);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }

        int unresolvedQuestions = await _questionRepository.GetUnresolvedUserQuestionAsync(questionDto.userId, cancellationToken);

        if (unresolvedQuestions > 3)
        {
            throw new Exception("У вас больше 3 открытых вопросов");
        }

        var questionId = Guid.NewGuid();
        var question = new Question(
            questionId,
            questionDto.title,
            questionDto.text,
            questionDto.userId,
            questionDto.tags
        );

        await _questionRepository.CreateAsync(question, cancellationToken);

        _logger.LogInformation("Создан вопрос с id: {questionId}", questionId);

        return questionId;
    }




    //public async Task Update(Guid question_id, UpdateQuestionDto questionDto, CancellationToken cancellationToken)
    //{

    //}


    //public async Task Delete(Guid question_id, CancellationToken cancellationToken)
    //{

    //}


    //public async Task AddAnswer(Guid question_id, AddAnswerDto questionDto, CancellationToken cancellationToken)
    //{

    //}


    //public async Task SelectSolution(Guid question_id, Guid answerId, CancellationToken cancellationToken)
    //{
    //}
}
