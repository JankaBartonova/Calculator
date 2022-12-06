﻿using System;
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

        [Command(
        Description = "Calculate area of a square of given size",
        UsageLines = new[]
        {
            "%AppName% %CmdPath% <a>"
        })]
        public void SquareArea(double a)
        {
            var square = new Calculations.Area.Square();
            Console.WriteLine(square.Calculate(a));
        }

        [Command(
        Description = "Calculate circumference of a square of given size",
        UsageLines = new[]
        {
            "%AppName% %CmdPath% <a>"
        })]
        public void SquareCircumference(double a)
        {
            var square = new Calculations.Circumference.Square();
            Console.WriteLine(square.Calculate(a));
        }


        [Command(
        Description = "Calculate area of a rectangle of given size",
        UsageLines = new[]
        {
            "%AppName% %CmdPath% <a> <b>"
        })]
        public void RectangleArea(double a, double b)
        {
            var rectangle = new Calculations.Area.Rectangle();
            Console.WriteLine(rectangle.Calculate(a, b));
        }

        [Command(
        Description = "Calculate Circumference of a rectangle of given size",
        UsageLines = new[]
        {
            "%AppName% %CmdPath% <a> <b>"
        })]
        public void RectangleCircumference(double a, double b)
        {
            var rectangle = new Calculations.Circumference.Rectangle();
            Console.WriteLine(rectangle.Calculate(a, b));
        }


        [Command(
        Description = "Calculate surface of a cube of given size",
        UsageLines = new[]
        {
            "%AppName% %CmdPath% <a>"
        })]
        public void CubeSurface(double a)
        {
            var cube = new Calculations.Surface.Cube();
            Console.WriteLine(cube.Calculate(a));
        }

        [Command(
        Description = "Calculate volume of a cube of given size",
        UsageLines = new[]
        {
            "%AppName% %CmdPath% <a>"
        })]
        public void CubeVolume(double a)
        {
            var cube = new Calculations.Volume.Cube();
            Console.WriteLine(cube.Calculate(a));
        }


        [Command(
        Description = "Calculate surface of a block of given size",
        UsageLines = new[]
        {
            "%AppName% %CmdPath% <a> <b> <c>"
        })]
        public void BlockSurface(double a, double b, double c)
        {
            var block = new Calculations.Surface.Block();
            Console.WriteLine(block.Calculate(a, b, c));
        }

        [Command(
        Description = "Calculate volume of a block of given size",
        UsageLines = new[]
        {
            "%AppName% %CmdPath% <a> <b> <c>"
        })]
        public void BlockVolume(double a, double b, double c)
        {
            var block = new Calculations.Volume.Block();
            Console.WriteLine(block.Calculate(a, b, c));
        }
    }
}
