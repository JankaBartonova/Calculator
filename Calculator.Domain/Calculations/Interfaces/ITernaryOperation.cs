namespace Calculator.Domain.Calculations
{
    /*
     * Calculate a result from operation having three numerical arguments.
     */
    public interface ITernaryOperation
    {
        double Calculate(double a, double b, double c);
    }
}
