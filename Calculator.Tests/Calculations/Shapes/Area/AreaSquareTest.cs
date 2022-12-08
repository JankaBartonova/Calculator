using Xunit;
using Calculator.Domain.Calculations.Shapes.Area;
using Calculator.Domain.Exceptions;

namespace Calculator.Tests.Calculations.Area
{
    public class AreaSquareTest
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(1.5, 2.25)]
        [InlineData(double.MaxValue, double.PositiveInfinity)]
        public void AreaSquare_ArgGiven_ReturnsCalculatedValue(double a, double expected)
        {
            var square = new Square();

            double actual = square.Calculate(a);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(double.MinValue)]
        public void AreaSquare_ArgIsLessThanZero_ReturnsException(double a)
        {
            var square = new Square();

            Assert.Throws<NegativeNumberException>(() => square.Calculate(a));
        }

        [Fact]
        public void AreaSquare_ArgIsNotANumber_ReturnsArgumentException()
        {
            var square = new Square();

            Assert.Throws<NotANumberException>(() => square.Calculate(double.NaN));
        }
    }
}
