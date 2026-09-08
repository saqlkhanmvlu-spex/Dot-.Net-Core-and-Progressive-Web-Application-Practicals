using Microsoft.AspNetCore.Mvc;
namespace Practical_9B.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpGet("factorial/{number}")]
        public IActionResult GetFactorial(int number)
        {
            if (number < 0)
            {
                return BadRequest("Factorial not possible for -ve nos.");
            }
            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return Ok(new
            {
                Number = number,
                Factorial = factorial
            });
        }
    }
}
