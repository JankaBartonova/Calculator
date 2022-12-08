namespace Calculator.Domain.Views.Interfaces
{
    /* Display a result of operation with two numerical arguments for a given shape.  
     */
    public interface IBinaryOperationResultView
    {
        public void DisplayResult(double a, double b, string shape, string operation, double result);
    }
}
