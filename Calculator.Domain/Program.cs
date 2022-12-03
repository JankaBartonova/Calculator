using System;
using CommandDotNet;

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

        public void SquareArea(double a)
        {
            var square = new Calculations.Area.Square();
            Console.WriteLine(square.Calculate(a));
        }

        public void SquareCircumference(double a)
        {
            var square = new Calculations.Circumference.Square();
            Console.WriteLine(square.Calculate(a));
        }


        public void RectangleArea(double a, double b)
        {
            var rectangle = new Calculations.Area.Rectangle();
            Console.WriteLine(rectangle.Calculate(a, b));
        }

        public void RectangleCircumference(double a, double b)
        {
            var rectangle = new Calculations.Circumference.Rectangle();
            Console.WriteLine(rectangle.Calculate(a, b));
        }


        public void CubeSurface(double a, double b, double c)
        {
            var block = new Calculations.Surface.Block();
            Console.WriteLine(block.Calculate(a, b, c));
        }

        public void CubeVolume(double a, double b, double c)
        {
            var block = new Calculations.Volume.Block();
            Console.WriteLine(block.Calculate(a, b, c));
        }


        public void BlockSurface(double a, double b, double c)
        {
            var block = new Calculations.Surface.Block();
            Console.WriteLine(block.Calculate(a, b, c));
        }

        public void BlockVolume(double a, double b, double c)
        {
            var block = new Calculations.Volume.Block();
            Console.WriteLine(block.Calculate(a, b, c));
        }
    }
}
