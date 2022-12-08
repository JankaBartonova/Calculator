using System;

namespace Calculator.Domain.Exceptions
{
    public class NegativeNumbersException : Exception
    {
        public NegativeNumbersException()
            : base("All the numbers have to be positive")
        {
        }
    }
}
