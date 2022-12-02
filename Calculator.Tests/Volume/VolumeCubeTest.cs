using System;
using Xunit;
using Calculator.Domain.Volume;

namespace Calculator.Tests.Volume
{
    public class VolumeCubeTest
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 8)]
        [InlineData(1.5, 3.375)]
        [InlineData(double.MaxValue, double.PositiveInfinity)]
        public void VolumeCube_ArgGiven_ReturnsCalculatedValue(double a, double expected)
        {
            var cube = new Cube();

            double actual = cube.Calculate(a);

            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(double.MinValue)]
        public void VolumeCube_ArgIsLessThanZero_ReturnsException(double a)
        {
            var cube = new Cube();

            Assert.Throws<ArgumentException>(() => cube.Calculate(a));
        }

        [Fact]
        public void VolumeCube_ArgIsNotANumber_ReturnsArgumentException()
        {
            var cube = new Cube();

            Assert.Throws<ArgumentException>(() => cube.Calculate(double.NaN));
        }
    }
}
