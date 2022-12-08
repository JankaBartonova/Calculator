using System;

namespace Calculator.Domain.Exceptions
{
    public class NotANumbersException : Exception
    {
        public NotANumbersException()
            : base("All the inputs have to be numbers")
        {
        }
    }
}
