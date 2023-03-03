using Microsoft.AspNetCore.Mvc;
namespace MovieApp.Api;


[ApiController]
[Route("api/[controller]")]
public class HomeApiController : ControllerBase
{
    private readonly ILogger<HomeApiController> _logger;
    public HomeApiController(ILogger<HomeApiController> logger)
    {
        _logger = logger;
    }

    [HttpGet("myhome")]
    public IEnumerable<Dictionary<string, string>> GetHome()
    {

        yield return new Dictionary<string, string>()
        {
            {"Status", "200"},
            {"Name", "Home"}

        };
        
    }

}