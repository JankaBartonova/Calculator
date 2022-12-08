using Calculator.Domain.Exceptions;

namespace Calculator.Domain.Calculations.Operations.Volume
{
    public class Cube : IUnaryOperation
    {
        public double Calculate(double a)
        {
            if (a < 0)
            {
                throw new NegativeNumberException();
            }

            if (double.IsNaN(a))
            {
                throw new NotANumberException();
            }

            return a * a * a;
        }
    }
}
