using Microsoft.AspNetCore.Mvc;
using Questions.Application.Questions;

namespace Questions.Presenters.Controllers;
[ApiController]
[Route("[controller]")]
public class QuestionsController : ControllerBase
{
    private readonly IQuestionsService _questionsService;
    public QuestionsController(IQuestionsService questionsService)
    {
        _questionsService = questionsService;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetQuestionDto questionDto, CancellationToken cancellationToken)
    {
        return Ok("Get All");
    }

    [HttpGet("{question_id:guid}")]
    public async Task<IActionResult> GetById([FromRoute] Guid question_id, CancellationToken cancellationToken)
    {
        return Ok("GetById");
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateQuestionDto questionDto, CancellationToken cancellationToken)
    {
        return Ok(await _questionsService.Create(questionDto, cancellationToken));
    }

    [HttpPut("{question_id:guid}")]
    public async Task<IActionResult> Update([FromRoute] Guid question_id, [FromBody] UpdateQuestionDto questionDto, CancellationToken cancellationToken)
    {
        return Ok("Updated Question");
    }

    [HttpDelete("{question_id:guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid question_id, CancellationToken cancellationToken)
    {
        return Ok("Deleted Question");
    }

    [HttpPost("{question_id:guid}/answers")]
    public async Task<IActionResult> AddAnswer([FromRoute] Guid question_id, [FromBody] AddAnswerDto questionDto, CancellationToken cancellationToken)
    {
        return Ok("Created answer for Question");
    }

    [HttpPut("{question_id:guid}/solution")]
    public async Task<IActionResult> SelectSolution([FromRoute] Guid question_id, [FromQuery] Guid answerId, CancellationToken cancellationToken)
    {
        return Ok("solution answer for Question");
    }
}
