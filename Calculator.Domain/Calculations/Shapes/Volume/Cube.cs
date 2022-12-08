using Calculator.Domain.Exceptions;

namespace Calculator.Domain.Calculations.Shapes.Volume
{
    public class Cube : IMonoSideShape
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
