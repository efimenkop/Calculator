using PangoCalculator.ApiControllers;
using System.Threading.Tasks;

namespace PangoCalculator.Services
{
    public interface ICalculator
    {
        Task<decimal> Calculate(decimal argument1, decimal argument2, Operation operation);
    }
}
