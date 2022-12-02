using System;

namespace Calculator.Domain.Exceptions
{
    public class NegativeNumbersException : Exception
    {
        public override string Message
        {
            get
            {
                return "All the numbers have to be positive";
            }
        }
    }
}
