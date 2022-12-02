using System;

namespace Calculator.Domain.Exceptions
{
    public class NotANumbersException : Exception
    {
        public override string Message
        {
            get
            {
                return "All the inputs have to be numbers";
            }
        }
    }
}
