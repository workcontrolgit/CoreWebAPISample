using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
[ApiController]
public class MathController : ControllerBase
{

    [HttpGet]
    public decimal Divide(decimal Numerator, decimal Denominator)
    {
        return (Numerator / Denominator);
    }
}