namespace Calculator.Domain.Calculations
{
    /*
     * Calculate a result from operation having one numerical argument.
     */
    public interface IUnaryOperation
    {
        double Calculate(double a);
    }
}
