using System;

namespace Calculator.Domain.Views
{
    public class DisplayResultSquare : IMonoSideDisplayResult
    {
        public void DisplayResult(double a, double result)
        {
            Console.WriteLine("Your square has a side = {0}", a);
            Console.WriteLine("Area of your square = {0}", result);
        }

    }
}
