using System;

namespace Calculator.Domain.Views.Interfaces
{
    public interface IDoubleSideDisplayResult
    {
        public void DisplayResult(double a, double b, string shape, string operation, double result);
    }
}
