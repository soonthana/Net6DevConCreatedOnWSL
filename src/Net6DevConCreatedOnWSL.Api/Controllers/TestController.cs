using Microsoft.AspNetCore.Mvc;

namespace Net6DevConCreatedOnWSL.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public ActionResult Get()
    {
        var result = "Hello Test .NET 6, project created on WSL";

        return Ok(result);
    }
}