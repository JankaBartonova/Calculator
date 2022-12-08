using System;
using CommandDotNet;
using Calculator.Domain.Views;

namespace Calculator.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calulator");
            Console.WriteLine("---------");
            Console.WriteLine();

            new AppRunner<Program>().Run(args);
        }

        [Command(
        Description = "Calculate area of a square of given size",
        UsageLines = new[]
        {
            "%AppName% %CmdPath% <a>"
        })]
        public void SquareArea(double a)
        {
            var square = new Calculations.Shapes.Area.Square();
            double result = square.Calculate(a);

            var displayResult = new MonoSideDisplayResult();
            displayResult.DisplayResult(a, "square", "area", result);
        }

        [Command(
        Description = "Calculate circumference of a square of given size",
        UsageLines = new[]
        {
            "%AppName% %CmdPath% <a>"
        })]
        public void SquareCircumference(double a)
        {
            var square = new Calculations.Shapes.Circumference.Square();
            double result = square.Calculate(a);

            var displayResult = new MonoSideDisplayResult();
            displayResult.DisplayResult(a, "square", "circumference", result);
        }


        [Command(
        Description = "Calculate area of a rectangle of given size",
        UsageLines = new[]
        {
            "%AppName% %CmdPath% <a> <b>"
        })]
        public void RectangleArea(double a, double b)
        {
            var rectangle = new Calculations.Shapes.Area.Rectangle();
            double result = rectangle.Calculate(a, b);

            var displayResult = new DoubleSideDisplayResult();
            displayResult.DisplayResult(a, b, "rectangle", "area", result);
        }

        [Command(
        Description = "Calculate circumference of a rectangle of given size",
        UsageLines = new[]
        {
            "%AppName% %CmdPath% <a> <b>"
        })]
        public void RectangleCircumference(double a, double b)
        {
            var rectangle = new Calculations.Shapes.Circumference.Rectangle();
            double result = rectangle.Calculate(a, b);

            var displayResult = new DoubleSideDisplayResult();
            displayResult.DisplayResult(a, b, "rectangle", "circumference", result);
        }


        [Command(
        Description = "Calculate surface of a cube of given size",
        UsageLines = new[]
        {
            "%AppName% %CmdPath% <a>"
        })]
        public void CubeSurface(double a)
        {
            var cube = new Calculations.Shapes.Surface.Cube();
            double result = cube.Calculate(a);

            var displayResult = new MonoSideDisplayResult();
            displayResult.DisplayResult(a, "cube", "surface", result);

        }

        [Command(
        Description = "Calculate volume of a cube of given size",
        UsageLines = new[]
        {
            "%AppName% %CmdPath% <a>"
        })]
        public void CubeVolume(double a)
        {
            var cube = new Calculations.Shapes.Volume.Cube();
            double result = cube.Calculate(a);

            var displayResult = new MonoSideDisplayResult();
            displayResult.DisplayResult(a, "cube", "volume", result);
        }


        [Command(
        Description = "Calculate surface of a block of given size",
        UsageLines = new[]
        {
            "%AppName% %CmdPath% <a> <b> <c>"
        })]
        public void BlockSurface(double a, double b, double c)
        {
            var block = new Calculations.Shapes.Surface.Block();
            double result = block.Calculate(a, b, c);

            var displayResult = new TrippleSideDIsplayResult();
            displayResult.DisplayResult(a, b, c, "block", "surface", result);
        }

        [Command(
        Description = "Calculate volume of a block of given size",
        UsageLines = new[]
        {
            "%AppName% %CmdPath% <a> <b> <c>"
        })]
        public void BlockVolume(double a, double b, double c)
        {
            var block = new Calculations.Shapes.Volume.Block();
            double result = block.Calculate(a, b, c);

            var displayResult = new TrippleSideDIsplayResult();
            displayResult.DisplayResult(a, b, c, "block", "volume", result);
        }


        [Command(
        Description = "Calculate area of circle of given radius",
        UsageLines = new[]
        {
            "%AppName% %CmdPath% <a>"
        })]
        public void CircleArea(double a)
        {
            var circle = new Calculations.Area.Circle();
            double result = circle.Calculate(a);

            var displayResult = new MonoSideDisplayResult();
            displayResult.DisplayResult(a, "circle", "area", result);
        }

        [Command(
        Description = "Calculate circumference of circle of given radius",
        UsageLines = new[]
        {
            "%AppName% %CmdPath% <a>"
        })]
        public void CircleCircumference(double a)
        {
            var circle = new Calculations.Circumference.Circle();
            double result = circle.Calculate(a);

            var displayResult = new MonoSideDisplayResult();
            displayResult.DisplayResult(a, "circle", "circumference", result);
        }
    }
}
