using System;

namespace Calculator.Domain.Exceptions
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException()
            : base("The number must be positive")
        {
        }
    }
}
