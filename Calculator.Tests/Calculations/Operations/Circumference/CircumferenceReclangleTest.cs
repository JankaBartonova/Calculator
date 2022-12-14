using Xunit;
using Calculator.Domain.Calculations.Operations.Circumference;
using Calculator.Domain.Exceptions;

namespace Calculator.Tests.Calculations.Circumference
{
    public class CircumferenceReclangleTest
    {
        [Theory]
        [InlineData(1, 2, 6)]
        [InlineData(1.5, 2, 7)]
        [InlineData(2, 1.5, 7)]
        [InlineData(double.MaxValue, 1, double.PositiveInfinity)]
        public void CircumferenceRectangle_ArgsGiven_ReturnsCalculatedValue(double a, double b, double expected)
        {
            var rectangle = new Rectangle();

            double actual = rectangle.Calculate(a, b);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1, 1)]
        [InlineData(1, -1)]
        [InlineData(double.MinValue, 1)]
        [InlineData(1, double.MinValue)]
        public void CircumferenceRectangle_ArgsAreLessThanZero_ReturnsException(double a, double b)
        {
            var rectangle = new Rectangle();

            Assert.Throws<NegativeNumbersException>(() => rectangle.Calculate(a, b));
        }

        [Theory]
        [InlineData(double.NaN, 1)]
        [InlineData(1, double.NaN)]
        public void CircumferenceRectangle_ArgAreNotANumber_ReturnsArgumentException(double a, double b)
        {
            var rectangle = new Rectangle();

            Assert.Throws<NotANumbersException>(() => rectangle.Calculate(a, b));
        }
    }
}
