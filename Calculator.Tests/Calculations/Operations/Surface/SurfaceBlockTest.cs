using Xunit;
using Calculator.Domain.Calculations.Operations.Surface;
using Calculator.Domain.Exceptions;

namespace Calculator.Tests.Calculations.Surface
{
    public class SurfaceBlockTest
    {
        [Theory]
        [InlineData(1, 1, 1, 6)]
        [InlineData(1.5, 1, 1, 8)]
        [InlineData(1, 1.5, 1, 8)]
        [InlineData(1, 1, 1.5, 8)]
        [InlineData(double.MaxValue, 1, 1, double.PositiveInfinity)]
        public void SurfaceBlock_ArgsGiven_ReturnsCalculatedValue(double a, double b, double c, double expected)
        {
            var block = new Block();

            double actual = block.Calculate(a, b, c);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1, 1, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(1, 1, -1)]
        [InlineData(double.MinValue, 1, 1)]
        [InlineData(1, double.MinValue, 1)]
        [InlineData(1, 1, double.MinValue)]
        public void SurfaceBlock_ArgsAreLessThanZero_ReturnsException(double a, double b, double c)
        {
            var block = new Block();

            Assert.Throws<NegativeNumbersException>(() => block.Calculate(a, b, c));
        }

        [Theory]
        [InlineData(double.NaN, 1, 1)]
        [InlineData(1, double.NaN, 1)]
        [InlineData(1, 1, double.NaN)]
        public void SurfaceBlock_ArgsAreNotANumber_ReturnsArgumentException(double a, double b, double c)
        {
            var block = new Block();

            Assert.Throws<NotANumbersException>(() => block.Calculate(a, b, c));
        }
    }
}
