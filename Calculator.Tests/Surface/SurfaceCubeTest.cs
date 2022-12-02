using System;
using Xunit;
using Calculator.Domain.Surface;

namespace Calculator.Tests.Surface
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

            Assert.Throws<ArgumentException>(() => cube.Calculate(a));
        }

        [Fact]
        public void SurfaceCube_ArgIsNotANumber_ReturnsArgumentException()
        {
            var cube = new Cube();

            Assert.Throws<ArgumentException>(() => cube.Calculate(double.NaN));
        }
    }
}
