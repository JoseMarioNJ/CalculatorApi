using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("sum")]
        public IActionResult GetSum([FromQuery] int a, [FromQuery] int b)

        {
            var result = a + b;
            return Ok(new { a, b, result });

        }

        [HttpGet("rest")]
        public IActionResult GetRest([FromQuery] int a, [FromQuery] int b)
        {
            var result = a - b;
            return Ok(new { a, b, result });
        }

        [HttpGet("producto")]

        public IActionResult GetProducto([FromQuery] int a, [FromQuery] int b)
        {
            var result = a * b;
            return Ok(new { a, b, result });
        }

        [HttpGet("division")]
        public IActionResult GetDivision([FromQuery] int a, [FromQuery] int b)
        {
            var result = a / b;
            return Ok(new { a, b, result });
        }
    }
}