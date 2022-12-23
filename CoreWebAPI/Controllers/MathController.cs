using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
[ApiController]
public class MathController : ControllerBase
{
    private readonly ILogger<MathController> _logger;

    public MathController(ILogger<MathController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public decimal Divide(decimal a, decimal b)
    {
        return (a / b);
        //try
        //{
        //    return (a / b);
        //}
        //catch (Exception ex)
        //{
        //    _logger.LogInformation("Error in Divide Method - Value of a is {a}", a);
        //    _logger.LogInformation("Error in Divide Method - Value of b is {b}", b);
        //    _logger.LogError(ex, "Error in Divide Method");
        //    return 0;
        //}
    }
}