using System.ComponentModel.DataAnnotations;

namespace PangoCalculator.ApiControllers
{
    public class CalculateRequest
    {
        [Display(Name = "First argument")]
        public decimal Argument1 { get; set; }

        [Display(Name = "Operator")]
        [Required]
        [EnumDataType(typeof(Operator))]
        public Operator? Operator { get; set; }

        [Display(Name = "Second argument")]
        public decimal Argument2 { get; set; }
    }

    public enum Operator
    {
        Add,
        Substract,
        Divide,
        Multiply
    }
}
