using PangoCalculator.ApiControllers;
using System;
using System.Threading.Tasks;

namespace PangoCalculator.Services
{
    public class Calculator : ICalculator
    {
        public Task<decimal> Calculate(decimal argument1, decimal argument2, Operator operation)
        {
            return operation switch
            {
                Operator.Add => Task.FromResult(argument1 + argument2),
                Operator.Substract => Task.FromResult(argument1 - argument2),
                Operator.Divide => Task.FromResult(argument1 / argument2),
                Operator.Multiply => Task.FromResult(argument1 * argument2),
                _ => throw new InvalidOperationException("Operation not supported"),
            };
        }
    }
}
