using System;

namespace Calculator.Domain.Exceptions
{
    public class NotANumberException : Exception
    {
        public NotANumberException()
            : base("The input value has to be a number")
        {
        }
    }
}
