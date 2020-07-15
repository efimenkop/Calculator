using PangoCalculator.ApiControllers;
using System;
using System.Threading.Tasks;

namespace PangoCalculator.Services
{
    public class Calculator : ICalculator
    {
        public Task<decimal> Calculate(decimal argument1, decimal argument2, Operation operation)
        {
            return operation switch
            {
                Operation.Add => Task.FromResult(argument1 + argument2),
                Operation.Substract => Task.FromResult(argument1 - argument2),
                Operation.Divide => Task.FromResult(argument1 / argument2),
                Operation.Multiply => Task.FromResult(argument1 * argument2),
                _ => throw new InvalidOperationException("Operation not supported"),
            };
        }
    }
}
