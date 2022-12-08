using Xunit;
using Calculator.Domain.Calculations.Shapes.Volume;
using Calculator.Domain.Exceptions;

namespace Calculator.Tests.Calculations.Volume
{
    public class VolumeBlockTest
    {
        [Theory]
        [InlineData(1, 1, 1, 1)]
        [InlineData(1.5, 1, 1, 1.5)]
        [InlineData(1, 1.5, 1, 1.5)]
        [InlineData(1, 1, 1.5, 1.5)]
        [InlineData(double.MaxValue, 1, 1, double.MaxValue)]
        [InlineData(double.MaxValue, 1, 2, double.PositiveInfinity)]
        public void VolumeBlock_ArgGiven_ReturnsCalculatedValue(double a, double b, double c, double expected)
        {
            var block = new Block();

            double actual = block.Calculate(a, b, c);

            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(-1, 1, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(1, 1, -1)]
        [InlineData(double.MinValue, 1, 1)]
        [InlineData(1, double.MinValue, 1)]
        [InlineData(1, 1, double.MinValue)]
        public void VolumeBlock_ArgsAreLessThanZero_ReturnsException(double a, double b, double c)
        {
            var block = new Block();

            Assert.Throws<NegativeNumbersException>(() => block.Calculate(a, b, c));
        }

        [Theory]
        [InlineData(double.NaN, 1, 1)]
        [InlineData(1, double.NaN, 1)]
        [InlineData(1, 1, double.NaN)]
        public void VolumeBlock_ArgsAreNotANumber_ReturnsArgumentException(double a, double b, double c)
        {
            var block = new Block();

            Assert.Throws<NotANumbersException>(() => block.Calculate(a, b, c));
        }
    }
}
