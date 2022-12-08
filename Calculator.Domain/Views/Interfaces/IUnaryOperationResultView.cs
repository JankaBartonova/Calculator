namespace Calculator.Domain.Views.Interfaces
{
    /* Display a result of operation with one numerical argument for a given shape.  
     */
    public interface IUnaryOperationResultView
    {
        void DisplayResult(double a, string shape, string operation, double result);
    }
}
