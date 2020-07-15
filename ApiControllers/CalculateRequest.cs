using System.ComponentModel.DataAnnotations;

namespace PangoCalculator.ApiControllers
{
    public class CalculateRequest
    {
        [Display(Name = "First argument")]
        public decimal Argument1 { get; set; }

        [Display(Name = "Operation")]
        [EnumDataType(typeof(Operation))]
        public Operation Operation { get; set; }

        [Display(Name = "Second argument")]
        public decimal Argument2 { get; set; }
    }

    public enum Operation
    {
        Add,
        Substract,
        Divide,
        Multiply
    }
}
