using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PangoCalculator.Services;

namespace PangoCalculator.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculator _calculator;

        public CalculatorController(ICalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpGet]
        public async Task<CalculateResponse> Get([FromQuery] CalculateRequest request)
        {
            var result = await _calculator.Calculate(request.Argument1, request.Argument2, request.Operator);

            return new CalculateResponse { Result = result };
        }
    }
}
