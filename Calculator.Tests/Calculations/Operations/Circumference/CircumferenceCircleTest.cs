using Xunit;
using Calculator.Domain.Calculations.Operations.Circumference;
using Calculator.Domain.Exceptions;

namespace Calculator.Tests.Calculations.Circumference
{
    public class CircumferenceCircleTest
    {
        [Theory]
        [InlineData(1, 6.28319)]
        [InlineData(1.5, 9.42478)]
        [InlineData(double.MaxValue, double.PositiveInfinity)]
        public void CircumferenceCircle_ArgsGiven_ReturnsCalculatedValue(double a, double expected)
        {
            var circle = new Circle();

            double actual = circle.Calculate(a);

            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(double.MinValue)]
        public void AreaCircle_ArgIsLessThanZero_ReturnsException(double a)
        {
            var circle = new Circle();

            Assert.Throws<NegativeNumberException>(() => circle.Calculate(a));
        }

        [Fact]
        public void AreaCircle_ArgIsNotANumber_ReturnsArgumentException()
        {
            var circle = new Circle();

            Assert.Throws<NotANumberException>(() => circle.Calculate(double.NaN));
        }
    }
}
