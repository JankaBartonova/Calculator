using System;

namespace Calculator.Domain.Exceptions
{
    public class NegativeNumberException : Exception
    {
        public override string Message
        {
            get
            {
                return "The number must be positive";
            }
        }
    }
}
