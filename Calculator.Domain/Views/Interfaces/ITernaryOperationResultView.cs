namespace Calculator.Domain.Views.Interfaces
{
    /* Display a result of operation with three numerical arguments for a given shape.  
     */
    public interface ITernaryOperationResultView
    {
        public void DisplayResult(double a, double b, double c, string shape, string operation, double result);
    }
}
