using Calculator.Domain.Exceptions;

namespace Calculator.Domain.Calculations.Operations.Surface
{
    public class Block : ITrippleSideShape
    {
        public double Calculate(double a, double b, double c)
        {
            if ((a < 0) || (b < 0) || (c < 0))
            {
                throw new NegativeNumbersException();
            }

            if (double.IsNaN(a) || double.IsNaN(b) || double.IsNaN(c))
            {
                throw new NotANumbersException();
            }

            return 2 * ((a * b) + (b * c) + (c * a));
        }
    }
}
