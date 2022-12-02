using System;

namespace Calculator.Domain.Exceptions
{
    public class NotANumberException : Exception
    {
        public override string Message
        {
            get
            {
                return "The input value has to be a number";
            }
        }
    }
}
