using System;

namespace Calculator.Domain.Views.Interfaces
{
    public interface IMonoSideDisplayResult
    {
        void DisplayResult(double a, string shape, string operation, double result);
    }
}
