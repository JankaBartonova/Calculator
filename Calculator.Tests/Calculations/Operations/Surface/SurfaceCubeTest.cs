using Xunit;
using Calculator.Domain.Calculations.Operations.Surface;
using Calculator.Domain.Exceptions;

namespace Calculator.Tests.Calculations.Surface
{
    public class SurfaceCubeTest
    {
        [Theory]
        [InlineData(1, 6)]
        [InlineData(2, 24)]
        [InlineData(1.5, 13.5)]
        [InlineData(double.MaxValue, double.PositiveInfinity)]
        public void SurfaceCube_ArgsGiven_ReturnsCalculatedValue(double a, double expected)
        {
            var cube = new Cube();

            double actual = cube.Calculate(a);

            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(double.MinValue)]
        public void SurfaceCube_ArgIsLessThanZero_ReturnsException(double a)
        {
            var cube = new Cube();

            Assert.Throws<NegativeNumberException>(() => cube.Calculate(a));
        }

        [Fact]
        public void SurfaceCube_ArgIsNotANumber_ReturnsArgumentException()
        {
            var cube = new Cube();

            Assert.Throws<NotANumberException>(() => cube.Calculate(double.NaN));
        }
    }
}
