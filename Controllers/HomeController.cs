using Microsoft.AspNetCore.Mvc;

namespace OnlineLearningPlatform.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("Welcome to the Online Learning Platform API");
    }
}
