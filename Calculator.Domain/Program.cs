using System;
using CommandDotNet;
using Calculator.Domain.Calculations.Area;

namespace Calculator.Domain
{
    class Program
    {
        static void Main(string[] args)
        { 
            new AppRunner<Program>().Run(args);
        }

        public void SquareArea(double a)
        {
            var square = new Square();
            Console.WriteLine(square.Calculate(a));
        }
    }
}
