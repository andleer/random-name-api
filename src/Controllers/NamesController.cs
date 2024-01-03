using Microsoft.AspNetCore.Mvc;
using RandomName.Api.Services;

namespace RandomName.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class NamesController : ControllerBase
{
    private readonly NameGeneratorService _nameGenerator;

    public NamesController()
    {
        _nameGenerator = new NameGeneratorService();
    }

    [HttpGet]
    public IActionResult Get([FromQuery] int count = 10)
    {
        var names = _nameGenerator.GenerateNames(count);
        return Ok(names);
    }
}
