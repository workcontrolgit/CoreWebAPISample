using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
[ApiController]
public class MathController : ControllerBase
{

    [HttpGet]
    public decimal Divide(decimal Numerator=5, decimal Denominator=1)
    {
        return (Numerator / Denominator);
    }
}