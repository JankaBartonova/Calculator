using Calculator.Domain.Exceptions;

namespace Calculator.Domain.Calculations.Operations.Area
{
    public class Rectangle : IBinaryOperation
    {
        public double Calculate(double a, double b)
        {
            if ((a < 0) || (b < 0))
            {
                throw new NegativeNumbersException();
            }

            if (double.IsNaN(a) || double.IsNaN(b))
            {
                throw new NotANumbersException();
            }

            return a * b;
        }
    }
}
