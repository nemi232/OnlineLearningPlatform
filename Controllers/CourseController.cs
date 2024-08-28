using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineLearningPlatform.Application.Commands;
using OnlineLearningPlatform.Application.Queries;

namespace OnlineLearningPlatform.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CoursesController : ControllerBase
{
    private readonly IMediator _mediator;

    public CoursesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateCourse([FromBody] CreateCourseCommand command)
    {
        var courseId = await _mediator.Send(command);
        return Ok(courseId);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCourseDetails(int id)
    {
        var course = await _mediator.Send(new GetCourseDetailsQuery(id));
        return course != null ? Ok(course) : NotFound();
    }

    [HttpGet]
    public async Task<IActionResult> ListCourses()
    {
        var courses = await _mediator.Send(new ListCoursesQuery());
        return Ok(courses);
    }
}
