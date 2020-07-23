using Microsoft.AspNetCore.Mvc;
using NCalc;

namespace PangoCalculator.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        public CalculateResponse Get([FromQuery] CalculateRequest request)
        {
            var value = new Expression(request.Expression).Evaluate();
            var result =  decimal.Parse(value.ToString());

            return new CalculateResponse { Result = result };
        }
    }
}
