using System.ComponentModel.DataAnnotations;

namespace PangoCalculator.ApiControllers
{
    public class CalculateRequest
    {
        [RegularExpression(@"[+\-]?(([0-9]+\.[0-9]+)|([0-9]+\.?)|(\.?[0-9]+))([+\-\/*](([0-9]+\.[0-9]+)|([0-9]+\.?)|(\.?[0-9]+)))*")]
        public string Expression { get; set; }
    }
}
